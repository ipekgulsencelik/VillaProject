using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UserLayoutComponents
{
    public class _UserLayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}