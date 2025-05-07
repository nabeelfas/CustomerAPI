using ProductsAPI.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProductsAPI.Models;
using ProductsAPI.Services;

namespace CustomerApi.services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;
        public CustomerService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CustomerMaster>> GetCustomersList()
        {
            return await _context.CustomerMasters.ToListAsync();

        }

        public async Task<CustomerMaster> GetCustomerById(int customercode)
        {
            return await _context.CustomerMasters.FirstOrDefaultAsync(m => m.CustomerCode == customercode);
        }

        public async Task<CustomerMaster> CreateCustomer(CustomerMaster customer)
        {
            _context.CustomerMasters.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task UpdateCustomer(CustomerMaster customer)
        {
            _context.CustomerMasters.Update(customer);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteCustomer(CustomerMaster customer)
        {
            _context.CustomerMasters.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}
