using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.DealDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class DealController : Controller
    {
        private readonly IDealService _dealService;
        private readonly IMapper _mapper;

        public DealController(IDealService dealService, IMapper mapper)
        {
            _dealService = dealService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _dealService.TGetListAsync();
            var dealList = _mapper.Map<List<ResultDealDTO>>(values);
            return View(dealList);
        }

        public async Task<IActionResult> DeleteDeal(ObjectId id)
        {
            await _dealService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateDeal()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeal(CreateDealDTO createDealDTO)
        {
            var deal = _mapper.Map<Deal>(createDealDTO);
            await _dealService.TCreateAsync(deal);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDeal(ObjectId id)
        {
            var value = await _dealService.TGetByIdAsync(id);
            var deal = _mapper.Map<UpdateDealDTO>(value);
            return View(deal);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDeal(UpdateDealDTO updateDealDTO)
        {
            var deal = _mapper.Map<Deal>(updateDealDTO);
            await _dealService.TUpdateAsync(deal);
            return RedirectToAction("Index");
        }
    }
}