
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQItem", GUID = "e5ef0b3c-bd98-4dae-8764-f304d3d1a4f4", Description = "", AvailableInEditMode = false)]
    public class FAQItem : SitePageData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Answer { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Question { get; set; }
    }
}