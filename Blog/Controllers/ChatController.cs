using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Interfaces;
using Blog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class ChatController : Controller
    {
        private IMessageRepository _messageRepository;
        private IUnitOfWork _unitOfWork;
        private UserManager<ApplicationUser> _userManager;
        public ChatController(IMessageRepository messageRepository, IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _messageRepository = messageRepository;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<IActionResult> Chat()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }
            var messages = _messageRepository.GetAll();
            return View(messages);
        }

        public async Task<IActionResult> Create(MessageModel message)
        {
            message.UserName = User.Identity.Name;
            var sender = await _userManager.GetUserAsync(User);
            message.UserId = sender.Id;
            await _messageRepository.Add(message);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }
    }
}
