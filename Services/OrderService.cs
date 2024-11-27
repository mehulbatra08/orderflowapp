using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using OrderFlowApp.Models;
using Microsoft.EntityFrameworkCore;

public class OrderService
{   
    private readonly AppDbContext _dbContext;

   
    public OrderService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

   
    public async Task<List<Order>> GetAllOrdersAsync()
    {
        return await _dbContext.Orders.ToListAsync();
    }

    // Get an order by ID
    public async Task<Order> GetOrderByIdAsync(int id)
    {
        return await _dbContext.Orders.FindAsync(id);
    }

    // Add a new order
    public async Task<int> AddOrder(Order order)

    {       
        _dbContext.Orders.Add(order); // Add order to DbContext
        Console.WriteLine("OrderService Testing");
        var flag = await _dbContext.SaveChangesAsync(); 
        return flag;
        
    }
    public async Task<int> EditOrder(Order order)
    {
        var existingOrder = await _dbContext.Orders.FindAsync(order.Id);
        _dbContext.Entry(existingOrder).CurrentValues.SetValues(order);
        return await _dbContext.SaveChangesAsync();
    }
}   
