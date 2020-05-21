using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Interfaces;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly IUnitOfWork _unitOfWork;

        PostController(IPostRepository postRepository, IUnitOfWork unitOfWork, SignInManager<ApplicationUser> signInManager)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            return Json(await _postRepository.Get(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(_postRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PostViewModel post)
        {
            var postModel = new Post
            {
                Body = post.Body,
                Category = post.Category,
                Comments = new List<Comment>(),
                Rating = 0,
                Title = post.Title,
                UserId = post.UserId,
                CategoryId = post.CategoryId
            };

            await _postRepository.Add(postModel);
            await _unitOfWork.CompleteAsync();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _postRepository.Delete(id);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }
    }
}