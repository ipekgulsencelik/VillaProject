using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.MessageDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _messageService.TGetListAsync();
            var messageList = _mapper.Map<List<ResultMessageDTO>>(values);
            return View(messageList);
        }

        public async Task<IActionResult> DeleteMessage(ObjectId id)
        {
            await _messageService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDTO createMessageDTO)
        {
            var message = _mapper.Map<Message>(createMessageDTO);
            await _messageService.TCreateAsync(message);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> MessageDetails(ObjectId id)
        {
            var value = await _messageService.TGetByIdAsync(id);
            var message = _mapper.Map<ResultMessageDTO>(value);
            return View(message);
        }
    }
}