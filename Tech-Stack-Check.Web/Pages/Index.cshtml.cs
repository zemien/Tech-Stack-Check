using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechStackCheck.Web.Models;
using TechStackCheck.Web.Services;

namespace TechStackCheck.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMapper mapper;
        private readonly IValuesService valuesService;

        public IndexModel(IMapper mapper, IValuesService valuesService){
            this.mapper = mapper;
            this.valuesService = valuesService;
        }

        public async Task OnGet()
        {
            //Demonstrate using AutoMapper
            var viewModel = mapper.Map<ValueViewModel[]>(await valuesService.GetValues());
        }
    }
}
