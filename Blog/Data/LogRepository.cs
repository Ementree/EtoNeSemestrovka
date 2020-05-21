using Blog.Interfaces;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class LogRepository : Repository<Log, ApplicationDbContext>, ILogRepository
    {
        public LogRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
