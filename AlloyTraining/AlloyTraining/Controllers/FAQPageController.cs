using System.Linq;
using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.XForms.WebControls;

namespace AlloyTraining.Controllers
{
    public class FAQPageController : PageControllerBase<FAQPage>
    {
        public ActionResult Index(FAQPage currentPage)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            currentPage.FaqItems = contentRepository.GetChildren<FAQItem>(currentPage.ContentLink).ToList();
            DefaultPageViewModel<FAQPage> model = new DefaultPageViewModel<FAQPage>(currentPage);

            return View(model);
        }

        public ViewResult Submit(FAQPage currentPage, string question)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            FAQItem fi = contentRepository.GetDefault<FAQItem>(currentPage.ContentLink);
            fi.Name = string.Format("Question: {0}", question);
            fi.Question = question;

            contentRepository.Save(fi, EPiServer.DataAccess.SaveAction.Save, EPiServer.Security.AccessLevel.Read);
            DefaultPageViewModel<FAQPage> model = new DefaultPageViewModel<FAQPage>(currentPage);
            return View("Index", model);
        }
    }
}