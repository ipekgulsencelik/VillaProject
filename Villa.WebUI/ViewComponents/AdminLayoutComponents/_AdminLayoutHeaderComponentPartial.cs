using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}