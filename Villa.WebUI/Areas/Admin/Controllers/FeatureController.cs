using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.FeatureDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _featureService.TGetListAsync();
            var featureList = _mapper.Map<List<ResultFeatureDTO>>(values);
            return View(featureList);
        }

        public async Task<IActionResult> DeleteFeature(ObjectId id)
        {
            await _featureService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDTO createFeatureDTO)
        {
            var feature = _mapper.Map<Feature>(createFeatureDTO);
            await _featureService.TCreateAsync(feature);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFeature(ObjectId id)
        {
            var value = await _featureService.TGetByIdAsync(id);
            var feature = _mapper.Map<UpdateFeatureDTO>(value);
            return View(feature);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDTO updateFeatureDTO)
        {
            var feature = _mapper.Map<Feature>(updateFeatureDTO);
            await _featureService.TUpdateAsync(feature);
            return RedirectToAction("Index");
        }
    }
}