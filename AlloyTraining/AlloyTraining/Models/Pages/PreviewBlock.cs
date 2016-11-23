using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace AlloyTraining.Models.Pages
{
    public class PreviewBlock : PageData
    {
        public IContent PreviewContent { get; set; }
        public ContentArea ContentArea { get; set; }

        public PreviewBlock(PageData currentPage, IContent previewContent) : base(currentPage)
        {
            PreviewContent = previewContent;
            ContentArea = new ContentArea();
            ContentArea.Items.Add(new ContentAreaItem
            {
                ContentLink = PreviewContent.ContentLink
            });
        }
    }
}