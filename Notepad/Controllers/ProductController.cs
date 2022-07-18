using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notepad.Data.Interfaces;
using Notepad.ViewModels;

namespace Notepad.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProductsLists _allProducts;
        public ProductController(IAllProductsLists iAllProducts)
        {
            _allProducts = iAllProducts; 
        }
        public ViewResult ListProduct()
        {
            ViewBag.Title = "priduct page";
            ProductListViewModel objP = new ProductListViewModel();
            objP.allProduct = _allProducts.Products;
            return View(objP);
        }
    }
}
