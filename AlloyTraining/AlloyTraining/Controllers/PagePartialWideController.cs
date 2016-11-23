using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true, Tags = new string[]{"span8"}, AvailableWithoutTag = false)]
    public class PagePartialWideController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentContent)
        {
            return PartialView("/Views/Shared/PagePartials/PagePartialWide.cshtml", currentContent);
        }
    }
}