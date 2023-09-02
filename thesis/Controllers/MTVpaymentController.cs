﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using thesis.Core.ViewModel;
using thesis.Data;
using thesis.Models;

namespace thesis.Controllers
{
	public class MTVpaymentController : Controller
	{
		private readonly thesisContext _context;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public MTVpaymentController(thesisContext context, IWebHostEnvironment webHostEnvironment)
		{
			_context = context;
			_webHostEnvironment = webHostEnvironment;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(MtvPaymentViewModel mtvPaymentVM)
		{
			var imageLicenseBack = "";
			if (mtvPaymentVM.PaymentReceipt != null && mtvPaymentVM.PaymentReceipt.Length > 0)
			{
				var uniqueFileName = $"{Guid.NewGuid()}{Path.GetExtension(mtvPaymentVM.PaymentReceipt.FileName)}";
				var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "img/MTV", uniqueFileName);
				imageLicenseBack = filePath;

				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					await mtvPaymentVM.PaymentReceipt.CopyToAsync(fileStream);
				}
			}

			var mtv = new Payment
			{
				PaymentReceipt = imageLicenseBack,
				SOA = mtvPaymentVM.SOA,
				Date = mtvPaymentVM.Date,
				Email = mtvPaymentVM.Email,
			};

			_context.Add(mtv);
			await _context.SaveChangesAsync();
			return RedirectToAction("Create", "MTVapplication");

		}
	}
}
