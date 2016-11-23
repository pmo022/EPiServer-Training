using AlloyTraining.Business;
using AlloyTraining.Models.Pages;
using EPiServer.Core;

namespace AlloyTraining.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = ContentExtensions.GetSection(currentPage.ContentLink);
        }
        public T CurrentPage { get; set; }
        public IContent Section { get; set; }

    }
}