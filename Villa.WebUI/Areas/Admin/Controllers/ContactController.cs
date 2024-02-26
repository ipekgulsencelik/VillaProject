using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.ContactDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _contactService.TGetListAsync();
            var contactList = _mapper.Map<List<ResultContactDTO>>(values);
            return View(contactList);
        }

        public async Task<IActionResult> DeleteContact(ObjectId id)
        {
            await _contactService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDTO createContactDTO)
        {
            var contact = _mapper.Map<Contact>(createContactDTO);
            await _contactService.TCreateAsync(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateContact(ObjectId id)
        {
            var value = await _contactService.TGetByIdAsync(id);
            var contact = _mapper.Map<UpdateContactDTO>(value);
            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDTO updateContactDTO)
        {
            var contact = _mapper.Map<Contact>(updateContactDTO);
            await _contactService.TUpdateAsync(contact);
            return RedirectToAction("Index");
        }
    }
}