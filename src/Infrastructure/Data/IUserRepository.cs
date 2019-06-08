using Microsoft.eShopWeb.Infrastructure.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Data
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetByName(string userName);
    }
}