using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        public ActionResult Index(SearchPage currentPage, string q)
        {
            var model = new SearchPageViewModel(currentPage);
            if (q != null)
            {
                model.SearchText = q;
                model.Search(q);
            }
            return View(model);
        }
    }
}