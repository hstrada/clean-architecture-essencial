using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> Create(Category category)
        {
            _context.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> GetById(int? Id)
        {
            return await _context.Categories.FindAsync(Id);
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> Remove(Category category)
        {
            _context.Remove(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Update(Category category)
        {
            _context.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
