using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Product Page", GUID = "cd80c5c8-76c2-4295-893b-37493aacd4e9", Description = "Alloy Product Page")]
    public class ProductPage : StandardPage
    {
        
        [Display(
            Name = "Unique Selling Points",
            Description = "What are this products selling points?",
            GroupName = SystemTabNames.Content,
            Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 330)]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}