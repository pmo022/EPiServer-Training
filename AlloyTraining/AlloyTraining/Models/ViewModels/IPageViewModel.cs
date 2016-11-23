using AlloyTraining.Models.Pages;

namespace AlloyTraining.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
    }
}
