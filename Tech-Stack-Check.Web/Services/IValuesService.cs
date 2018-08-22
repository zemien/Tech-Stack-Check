using System.Threading.Tasks;
using TechStackCheck.Web.Models;

namespace TechStackCheck.Web.Services
{
    public interface IValuesService
    {
        Task<int> GetValue(int id);

        Task<Value[]> GetValues();
    }
}
