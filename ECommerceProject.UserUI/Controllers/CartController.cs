﻿using ECommerceProject.Business.Abstract;
using ECommerceProject.UserUI.Models;
using ECommerceProject.UserUI.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerceProject.UserUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _sessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService sessionService, ICartService cartService, IProductService productService)
        {
            _sessionService = sessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(int productId)
        {
            var productAdd = _productService.GetById(productId);
            var cart = _sessionService.GetCart();
            _cartService.AddToCart(cart, productAdd);
            _sessionService.SetCart(cart);
            //TempData.Add("message", String.Format("Ürün, {0}, başarılı bir şekilde eklendi", productAdd.Name));
            return RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
            var cart = _sessionService.GetCart();

            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };

            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _sessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _sessionService.SetCart(cart);
            TempData.Add("message", String.Format("Ürün, başarılı bir şekilde silinid"));
            return RedirectToAction("List");
        }
    }
}
