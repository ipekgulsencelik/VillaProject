using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UserLayoutComponents
{
    public class _UserLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}