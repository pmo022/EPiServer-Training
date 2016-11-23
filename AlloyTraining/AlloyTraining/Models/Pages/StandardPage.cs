using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard Page", GUID = "edaa004e-799e-4d81-b4d7-1523ba2e73f4", Description = "Alloy Standard Page")]
    [ImageUrl("~/Static/gfx/page-type-thumbnail-standard.png")]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        public virtual TeaserBlock Teaser { get; set; }
    }
}