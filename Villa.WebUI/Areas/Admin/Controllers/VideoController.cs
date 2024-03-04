using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.VideoDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class VideoController : Controller
    {
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;

        public VideoController(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _videoService.TGetListAsync();
            var videoList = _mapper.Map<List<ResultVideoDTO>>(values);
            return View(videoList);
        }

        public async Task<IActionResult> DeleteVideo(ObjectId id)
        {
            await _videoService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateVideo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateVideo(CreateVideoDTO createVideoDTO)
        {
            var video = _mapper.Map<Video>(createVideoDTO);
            await _videoService.TCreateAsync(video);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateVideo(ObjectId id)
        {
            var value = await _videoService.TGetByIdAsync(id);
            var video = _mapper.Map<UpdateVideoDTO>(value);
            return View(video);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVideo(UpdateVideoDTO updateVideoDTO)
        {
            var video = _mapper.Map<Video>(updateVideoDTO);
            await _videoService.TUpdateAsync(video);
            return RedirectToAction("Index");
        }
    }
}