using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.BannerDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BannerController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public BannerController(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _bannerService.TGetListAsync();
            var bannerList = _mapper.Map<List<ResultBannerDTO>>(values);
            return View(bannerList);
        }

        public async Task<IActionResult> DeleteBanner(ObjectId id)
        {
            await _bannerService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateBanner()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDTO createBannerDTO)
        {
            var banner = _mapper.Map<Banner>(createBannerDTO);
            await _bannerService.TCreateAsync(banner);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBanner(ObjectId id)
        {
            var value = await _bannerService.TGetByIdAsync(id);
            var banner = _mapper.Map<UpdateBannerDTO>(value);
            return View(banner);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDTO updateBannerDTO)
        {
            var banner = _mapper.Map<Banner>(updateBannerDTO);
            await _bannerService.TUpdateAsync(banner);
            return RedirectToAction("Index");
        }
    }
}