
using AlloyTraining.Models.Pages;
using EPiServer.Core;

namespace AlloyTraining.Models.ViewModels
{
    public class BlockEditPageViewModel : IPageViewModel<SitePageData>
    {
        public PreviewBlock PreviewBlock { get; set; }
        public SitePageData CurrentPage { get; set; }

        public BlockEditPageViewModel(PageData page, IContent content)
        {
            PreviewBlock = new PreviewBlock(page, content);
            CurrentPage = page as SitePageData;
        }
    }
}