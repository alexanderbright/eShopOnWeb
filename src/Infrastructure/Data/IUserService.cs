using Microsoft.eShopWeb.Infrastructure.Identity;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.ApplicationCore.Services
{
    public interface IUserService
    {
        Task<ApplicationUser> GetByName(string userName);
    }
}