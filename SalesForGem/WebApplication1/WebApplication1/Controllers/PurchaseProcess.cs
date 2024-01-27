using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Entity;

namespace WebApplication1.Controllers
{
    public class PurchaseProcess : Controller
    {
        private SalesProcGemContext _salesProcGemContext;

        public PurchaseProcess(SalesProcGemContext salesProcGemContext)
        {
            _salesProcGemContext = salesProcGemContext;
        }
        public IActionResult Inquiry()
        {
            _salesProcGemContext.Products.Select(p => new InquiryViewModel
            {
                ProductName = p.ProductName,
                Unit = p.Unit,
            });
            return View();
        }

        public IActionResult BuyRequest()
        {
            return View();
        }
        public IActionResult Purchased()
        {
            return View();
        }
    }
}
