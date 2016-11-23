using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Start Page", GUID = "8f137236-89ef-4544-9925-43afde620add", Description = "This is the start page of your site")]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading", 
            Description = "Page Heading", 
            Order = 10, 
            GroupName = SystemTabNames.Content)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Name = "Main Conent Area",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 300
            )]
        public virtual ContentArea MainContentArea { get; set; }

    }
}