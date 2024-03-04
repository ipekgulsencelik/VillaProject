using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.SubHeaderDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class SubHeaderController : Controller
    {
        private readonly ISubHeaderService _headerService;
        private readonly IMapper _mapper;

        public SubHeaderController(ISubHeaderService headerService, IMapper mapper)
        {
            _headerService = headerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _headerService.TGetListAsync();
            var headerList = _mapper.Map<List<ResultSubHeaderDTO>>(values);
            return View(headerList);
        }

        public async Task<IActionResult> DeleteSubHeader(ObjectId id)
        {
            await _headerService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateSubHeader()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubHeader(CreateSubHeaderDTO createSubHeaderDTO)
        {
            var header = _mapper.Map<SubHeader>(createSubHeaderDTO);
            await _headerService.TCreateAsync(header);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSubHeader(ObjectId id)
        {
            var value = await _headerService.TGetByIdAsync(id);
            var header = _mapper.Map<UpdateSubHeaderDTO>(value);
            return View(header);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSubHeader(UpdateSubHeaderDTO updateSubHeaderDTO)
        {
            var header = _mapper.Map<SubHeader>(updateSubHeaderDTO);
            await _headerService.TUpdateAsync(header);
            return RedirectToAction("Index");
        }
    }
}