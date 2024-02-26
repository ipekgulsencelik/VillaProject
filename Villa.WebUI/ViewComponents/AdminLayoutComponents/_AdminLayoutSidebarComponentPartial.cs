using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}