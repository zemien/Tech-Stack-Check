using System.Threading.Tasks;

namespace TechStackCheck.Web.Services
{
    public interface IValuesService
    {
        Task<int> GetValue(int id);
    }
}
