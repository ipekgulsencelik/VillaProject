using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UserLayoutComponents
{
    public class _UserLayoutSubHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}