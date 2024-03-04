using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.Business.Validations.QuestionValidation;
using Villa.DTO.DTOs.QuestionDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class QuestionController : Controller
    {
        private readonly IFrequentlyQuestionService _questionService;
        private readonly IMapper _mapper;

        public QuestionController(IFrequentlyQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _questionService.TGetListAsync();
            var questionList = _mapper.Map<List<ResultQuestionDTO>>(values);
            return View(questionList);
        }

        public async Task<IActionResult> DeleteQuestion(ObjectId id)
        {
            await _questionService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateQuestion()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionDTO createQuestionDTO)
        {
            ModelState.Clear();
            var question = _mapper.Map<FrequentlyQuestion>(createQuestionDTO);
            var validator = new QuestionValidator();
            var result = validator.Validate(question);
            if (!result.IsValid)
            {
                result.Errors.ForEach(x =>
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                });
                return View();
            }
            await _questionService.TCreateAsync(question);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateQuestion(ObjectId id)
        {
            var value = await _questionService.TGetByIdAsync(id);
            var question = _mapper.Map<UpdateQuestionDTO>(value);
            return View(question);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuestion(UpdateQuestionDTO updateQuestionDTO)
        {
            var question = _mapper.Map<FrequentlyQuestion>(updateQuestionDTO);
            await _questionService.TUpdateAsync(question);
            return RedirectToAction("Index");
        }
    }
}