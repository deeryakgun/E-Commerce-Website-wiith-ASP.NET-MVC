using System;
using Microsoft.AspNetCore.Mvc;
using proje_4.Data;
using proje_4.Dto;
using proje_4.Models;
using proje_4.Oturum;

namespace proje_4.Component
{
	public class CartSumList : ViewComponent
	{
		private readonly ApplicationDbContext _context;

		public CartSumList(ApplicationDbContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
			CartViewModel cartVM = new()
			{
				CartItems = cart,
				GrandTotal = cart.Sum(x => x.Quantity * x.Price)

			};

			return View(cartVM);

        }
	}
}

