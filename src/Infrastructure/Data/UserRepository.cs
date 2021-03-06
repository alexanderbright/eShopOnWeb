﻿using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.eShopWeb.Infrastructure.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.eShopWeb.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppIdentityDbContext _dbContext;

        public UserRepository(AppIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApplicationUser> GetByName(string userName)
        {
            //TODO: SQL concatenation with user strings causes SQL Injection
            //it's better to use string interpolation which will parametrise SQL
            var users = await  _dbContext.Users.FromSql("SELECT TOP 1 * FROM [AspNetUsers] WHERE [UserName] = '" + userName + "'").ToListAsync();
            return users.FirstOrDefault();
        }
    }
}
