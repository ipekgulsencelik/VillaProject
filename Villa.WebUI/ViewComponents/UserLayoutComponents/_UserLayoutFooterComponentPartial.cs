using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UserLayoutComponents
{
    public class _UserLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}