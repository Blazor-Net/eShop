namespace eShop.UseCases.AdminPortal.OrderDetailScreen.AbstractClasses
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}