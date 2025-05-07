using ProductsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsAPI.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerMaster>> GetCustomersList();
        Task<CustomerMaster> GetCustomerById(int customercode);
        Task<CustomerMaster> CreateCustomer(CustomerMaster customer);
        Task UpdateCustomer(CustomerMaster customer);
        Task DeleteCustomer(CustomerMaster customer);
    }
}