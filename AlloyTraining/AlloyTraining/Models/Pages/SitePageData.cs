using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    public abstract class SitePageData : EPiServer.Core.PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Meta Title",
            Description = "Meta title of the page",
            GroupName = "SEO",
            Order = 100)]
        public virtual string MetaTitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Meta Keywords",
            Description = "Meta Keywords of the page",
            GroupName = "SEO",
            Order = 200)]
        public virtual string MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Meta Description",
            Description = "Meta description of the page",
            GroupName = "SEO",
            Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Page Image",
                    Description = "something something main image",
                    GroupName = SystemTabNames.Content,
                    Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual EPiServer.Core.ContentReference PageImage { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Teaser Text",
            GroupName = SystemTabNames.Content,
            Order = 200,
            Description = "The text to show when teasing this page from elsewhere on the site"
            )]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText { get; set; }

    }
}