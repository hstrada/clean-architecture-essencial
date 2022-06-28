using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
      
        Task<CategoryDTO> ICategoryService.GetById(int? Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryDTO>> ICategoryService.GetCategories()
        {
            var categoriesEntity = _categoryRepository.GetCategories();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        Task ICategoryService.Remove(int? Id)
        {
            throw new NotImplementedException();
        }

        Task ICategoryService.Update(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        Task ICategoryService.Add(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
