using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication6.Entities;

namespace WebApplication6.Controllers
{
    public class ProductController : Controller
    {
        List<Product> _products;
        List<ProductGroup> _productGroups;
        public ProductController()
        {
            SetupData();
        }
        public IActionResult Index()
        {
            return View(_products);
        }
        /// <summary>
        /// Инициализация списков
        /// </summary>
        private void SetupData()
        {
            _productGroups = new List<ProductGroup>
            {
                new ProductGroup {ProductGroupId=1, GroupName="Биты"},
                new ProductGroup {ProductGroupId=2, GroupName="Мячи"},
                new ProductGroup {ProductGroupId=3, GroupName="Чешки"},
                new ProductGroup {ProductGroupId=4, GroupName="Велосипеды"},
                };
            _products = new List<Product>
            {
                new Product {ProductId = 1, ProductName="Бита-ударник",
                Description="Ударяет больно", ProductGroupId=1, Image="1.png" },
                new Product {ProductId = 2, ProductName="Бита-приёмник",
                Description="Принимает хорошо", ProductGroupId=1, Image="2.jpg" },
                new Product {ProductId = 3, ProductName="Мяч-скакун",
                Description="Скачет", ProductGroupId=2, Image="3.jpg" },
                new Product {ProductId = 4, ProductName="Мяч-прыгун",
                Description="Прыгает", ProductGroupId=2, Image="4.jpg" },
                new Product {ProductId = 5, ProductName="Чешки из Чехии",
                Description="Само совершенство", ProductGroupId=3, Image="5.jpg" },
                new Product {ProductId = 6, ProductName="Чешки из Китая",
                Description="Хуже не придумаешь", ProductGroupId=3, Image="6.jpg" },
                new Product {ProductId = 7, ProductName="Велосипед-Аист",
                Description="Можно залететь", ProductGroupId=4, Image="7.jpg" },
                new Product {ProductId = 8, ProductName="Велосипед-горник",
                Description="Для медведей на велосипеде", ProductGroupId=4, Image="8.jpg" },
            };
        }
    }
}
