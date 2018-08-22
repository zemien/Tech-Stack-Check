using System.Threading.Tasks;
using TechStackCheck.Web.Models;

namespace TechStackCheck.Web.Services
{
    public class FakeValuesService : IValuesService
    {
        public async Task<int> GetValue(int id)
        {
            return id;
        }

        public Task<Value[]> GetValues()
        {
            return Task.FromResult(new[] { new Value { PartitionKey = "123", RowKey = "456" } });
        }
    }
}
