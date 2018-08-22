using System.Linq;
using System.Threading.Tasks;
using TechStackCheck.AzureStorage.Table;
using TechStackCheck.Web.Models;

namespace TechStackCheck.Web.Services
{
    public class TableStorageValuesService : IValuesService
    {
        private readonly IAzureTableStorage<Value> repository;

        public TableStorageValuesService(IAzureTableStorage<Value> repository)
        {
            this.repository = repository;
        }

        public async Task<int> GetValue(int id)
        {
            var allValues = await repository.GetList();
            return int.Parse(allValues.First().PartitionKey);
        }

        public async Task<Value[]> GetValues()
        {
            return (await repository.GetList()).ToArray();
        }
    }
}
