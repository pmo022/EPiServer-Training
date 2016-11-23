using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;

namespace AlloyTraining.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            DefaultPageViewModel<StartPage> model = new DefaultPageViewModel<StartPage>(currentPage);
            return View(model);
        }
    }
}