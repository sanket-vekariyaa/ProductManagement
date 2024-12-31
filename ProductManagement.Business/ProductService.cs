using Microsoft.EntityFrameworkCore;
using ProductManagement.Data;
using ProductManagement.Providers;
using ProductManagement.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagement.Business
{
    public class ProductService
    {
        DefaultContext _context = new DefaultContext(new Connection());

        // Create
        public async Task CreateProductAsync(Products product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
        }

        // Read
        public async Task<List<Products>> GetProductsAsync()
        {
            return await _context.Product.Include(p => p.Category).ToListAsync();
        }
        public async Task<List<Category>> GetProductCategoriesAsync()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Products> GetProductByIdAsync(int id)
        {
            return await _context.Product.Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id) ?? new Products();
        }

        // Update
        public async Task UpdateProductAsync(Products product)
        {
            _context.Product.Update(product);
            await _context.SaveChangesAsync();
        }

        // Delete
        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }

}
