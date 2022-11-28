using ECommerceProject.Entities.Concrete;

namespace ECommerceProject.UserUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
