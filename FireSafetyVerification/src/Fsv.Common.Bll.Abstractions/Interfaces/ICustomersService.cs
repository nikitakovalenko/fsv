using Fsv.Common.Entities;

namespace Fsv.Common.Bll.Abstractions;

public interface ICustomersService
{
    IEnumerable<Customer> GetCustomers();
    Customer CreateCustomer();
    void AddCustomer(Customer customer);
}
