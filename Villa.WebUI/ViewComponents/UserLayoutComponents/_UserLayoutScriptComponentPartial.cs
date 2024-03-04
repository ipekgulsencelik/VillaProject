using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UserLayoutComponents
{
    public class _UserLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}