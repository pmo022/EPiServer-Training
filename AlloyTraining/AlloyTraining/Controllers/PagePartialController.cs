
using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class PagePartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentContent)
        {
            return PartialView("~/Views/Shared/PagePartials/PagePartial.cshtml", currentContent);
        }
    }
}