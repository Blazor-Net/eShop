using eShop.CoreBusiness.Models;

namespace eShop.CoreBusiness.Services.Interfaces
{
    public interface IOrderService
    {
        bool IsValidateCreateOrder(Order order);
        bool IsValidateProcessOrder(Order order);
        bool IsvalidateUpdateOrder(Order order);
        bool IsValidCustomerInformation(string name, string address, string city, string province, string country);
    }
}