using System.Threading.Tasks;

namespace TechStackCheck.Web.Services
{
    public class FakeValuesService : IValuesService
    {
        public async Task<int> GetValue(int id)
        {
            return id;
        }
    }
}
