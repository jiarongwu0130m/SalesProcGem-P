using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.Models.Entity;

namespace WebApplication1.Services
{
    public class ProductsService
    {
        private readonly SalesProcGemContext _db;

        public ProductsService(SalesProcGemContext db)
        {
            _db = db;
        }
        public List<ProductsViewModel> GetProducts()
        {
            return _db.Products.Select(p => new ProductsViewModel
            {
                Productid = p.Id,
                ProductName = p.ProductName,
                ProductNO = p.ProductNo,
                Unit = p.Unit,
                PartNumber = p.PartNumber,
                CustomerNumber = p.CustomerNumber,
                Remarks = p.Remarks,

            }).ToList();
        }
    }
}
