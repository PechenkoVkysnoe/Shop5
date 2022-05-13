using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
