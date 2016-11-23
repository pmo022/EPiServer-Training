using System.Collections.Generic;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQPage", GUID = "aa2a0706-892c-4933-a26f-087df0ce0be0", Description = "")]
    public class FAQPage : SitePageData
    {
        [Ignore]
        public IList<FAQItem> FaqItems { get; set; }

    }
}