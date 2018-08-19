using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechStackCheck.AzureStorage.Table;
using TechStackCheck.Web.Hubs;
using TechStackCheck.Web.Models;
using TechStackCheck.Web.Services;

namespace TechStackCheck.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAzureTableStorage<Value>>(factory =>
            {
                return new AzureTableStorage<Value>(
                    new AzureTableSettings(Configuration["Table_StorageAccountConnectionString"]));
            });

            //Decide between using a fake table storage or Azure Table Storage
            if (bool.TryParse(Configuration["UseFakeTableStorage"], out var useFakeTableStorage) &&
                useFakeTableStorage == true)
            {
                services.AddScoped<IValuesService, FakeValuesService>();
            }
            else
            {
                services.AddScoped<IValuesService, TableStorageValuesService>();
            }

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseStaticFiles();
            app.UseSignalR(routes =>
            {
                routes.MapHub<NotificationHub>("/notificationHub");
            });
        }
    }
}
