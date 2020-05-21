using Blog.Interfaces;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class UserRepository : Repository<ApplicationUser, ApplicationDbContext>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
