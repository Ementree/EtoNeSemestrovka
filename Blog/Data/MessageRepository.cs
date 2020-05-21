using Blog.Interfaces;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class MessageRepository : Repository<MessageModel, ApplicationDbContext>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
