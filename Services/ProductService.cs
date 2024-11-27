using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using OrderFlowApp.Models;
using Microsoft.EntityFrameworkCore;

public class ProductService
{

    private readonly AppDbContext _dbContext;

    public ProductService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Product>> GetAllProductAsync(){
    return await _dbContext.Products.ToListAsync();
    
} 
    public async Task AddProduct(Product product){
    _dbContext.Products.Add(product);
    await _dbContext.SaveChangesAsync();
    
}

}

