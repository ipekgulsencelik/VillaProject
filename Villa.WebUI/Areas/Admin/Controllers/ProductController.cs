using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.DTO.DTOs.MessageDTOs;
using Villa.DTO.DTOs.ProductDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productService.TGetListAsync();
            var productList = _mapper.Map<List<ResultProductDTO>>(values);
            return View(productList);
        }

        public async Task<IActionResult> DeleteProduct(ObjectId id)
        {
            await _productService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDTO createProductDTO)
        {
            var product = _mapper.Map<Product>(createProductDTO);
            await _productService.TCreateAsync(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(ObjectId id)
        {
            var value = await _productService.TGetByIdAsync(id);
            var product = _mapper.Map<UpdateProductDTO>(value);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            var product = _mapper.Map<Product>(updateProductDTO);
            await _productService.TUpdateAsync(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetails(ObjectId id)
        {
            var value = await _productService.TGetByIdAsync(id);
            var product = _mapper.Map<ResultProductDTO>(value);
            return View(product);
        }
    }
}