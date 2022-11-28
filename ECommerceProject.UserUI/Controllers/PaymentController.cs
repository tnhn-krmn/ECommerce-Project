using ECommerceProject.Entities.Concrete;
using ECommerceProject.UserUI.ExtensionMethods;
using ECommerceProject.UserUI.Models;
using ECommerceProject.UserUI.Services;
using IyzipayCore;
using IyzipayCore.Model;
using IyzipayCore.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ECommerceProject.UserUI.Controllers
{
    public class PaymentController : Controller
    {
        private ICartSessionService _sessionService;
        IHttpContextAccessor _httpContextAccessor;

        public PaymentController(ICartSessionService sessionService, IHttpContextAccessor httpContextAccessor)
        {
            _sessionService = sessionService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CheckOut()
        {
            var cart = _sessionService.GetCart();

            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };

            return View(cartListViewModel);
        }

        [HttpPost]
        public IActionResult CheckOut(OrderModel model)
        {
            Options options = new Options();
            options.ApiKey = "sandbox-wlCL29RVNOyfcDKYNeORlHihgTI2RIXt";
            options.SecretKey = "sandbox-8uES7eJvC3OOzmXF4Z6wF7DIeavfXqXZ";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");


            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = Guid.NewGuid().ToString();
            request.Price = cartToCheck.Total.ToString().Split(",")[0];
            request.PaidPrice = cartToCheck.Total.ToString().Split(",")[0];
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = "B67832";
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = "John Doe";
            paymentCard.CardNumber = "5528790000000008";
            paymentCard.ExpireMonth = "12";
            paymentCard.ExpireYear = "2030";
            paymentCard.Cvc = "123";
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;

            Buyer buyer = new Buyer();
            buyer.Id = "BY789";
            buyer.Name = "John";
            buyer.Surname = "Doe";
            buyer.GsmNumber = "+905350000000";
            buyer.Email = "email@email.com";
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            buyer.Ip = "85.34.78.112";
            buyer.City = "Istanbul";
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;

            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;

            List<BasketItem> basketItems = new List<BasketItem>();
            foreach (var item in cartToCheck.CartLines)
            {
                BasketItem basketValues = new BasketItem();
                basketValues.Id = item.Product.ProductId.ToString();
                basketValues.Name = item.Product.Name;
                basketValues.Category1 = item.Product.Category.CategoryId.ToString();
                basketValues.ItemType = BasketItemType.PHYSICAL.ToString();
                basketValues.Price = item.Product.Price.ToString().Split(",")[0];
                basketItems.Add(basketValues);
            }

            request.BasketItems = basketItems;
            Payment payment = Payment.Create(request, options);

            if(payment.Status == "success")
            {
                return RedirectToAction("Success","Payment");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }

    }
}
