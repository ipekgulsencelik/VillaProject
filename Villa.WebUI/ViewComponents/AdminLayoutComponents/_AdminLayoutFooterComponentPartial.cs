using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}