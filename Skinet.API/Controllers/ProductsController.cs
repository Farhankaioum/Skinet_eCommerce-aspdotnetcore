﻿using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Skinet.API.Dtos;
using Skinet.API.Errors;
using Skinet.Core.Interfaces;

namespace Skinet.API.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly IProductRepository _productRepo;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productRepo.GetProductsAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async  Task<IActionResult> GetProduct(int id)
        {
            var product = await _productRepo.GetProductByIdAsync(id);

            if (product == null)
                return NotFound(new ApiResponse(404));

            var returnProduct = _mapper.Map<ProductToReturnDto>(product);

            return Ok(returnProduct);
        }

        [HttpGet("brands")]
        public async Task<IActionResult> GetProductBrands()
        {
            var productBrands = await _productRepo.GetProductBrandsAsync();

            return Ok(productBrands);
        }

        [HttpGet("types")]
        public async Task<IActionResult> GetProductTypes()
        {
            var productTypes = await _productRepo.GetProductTypesAsync();

            return Ok(productTypes);
        }
    }
}
