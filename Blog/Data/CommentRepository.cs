using Blog.Interfaces;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class CommentRepository : Repository<Comment, ApplicationDbContext>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {

        }
    }
}
