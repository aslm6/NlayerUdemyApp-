﻿using AutoMapper;
using Nlayer.Core;
using Nlayer.Core.DTOs;
using Nlayer.Core.Repositories;
using Nlayer.Core.Services;
using Nlayer.Core.UnitOfWorks;

namespace Nlayer.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }



        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();

            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200,productsDto);

        }
    }
}
