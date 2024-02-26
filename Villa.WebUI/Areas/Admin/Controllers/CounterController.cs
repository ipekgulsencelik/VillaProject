using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.CounterDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CounterController : Controller
    {
        private readonly ICounterService _counterService;
        private readonly IMapper _mapper;

        public CounterController(ICounterService counterService, IMapper mapper)
        {
            _counterService = counterService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _counterService.TGetListAsync();
            var counterList = _mapper.Map<List<ResultCounterDTO>>(values);
            return View(counterList);
        }

        public async Task<IActionResult> DeleteCounter(ObjectId id)
        {
            await _counterService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateCounter()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCounter(CreateCounterDTO createCounterDTO)
        {
            var counter = _mapper.Map<Counter>(createCounterDTO);
            await _counterService.TCreateAsync(counter);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCounter(ObjectId id)
        {
            var value = await _counterService.TGetByIdAsync(id);
            var counter = _mapper.Map<UpdateCounterDTO>(value);
            return View(counter);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCounter(UpdateCounterDTO updateCounterDTO)
        {
            var counter = _mapper.Map<Counter>(updateCounterDTO);
            await _counterService.TUpdateAsync(counter);
            return RedirectToAction("Index");
        }
    }
}