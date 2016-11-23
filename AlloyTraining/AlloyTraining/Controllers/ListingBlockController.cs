using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.Blocks;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        public override ActionResult Index(ListingBlock currentBlock)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            var model = new ListingBlockModel {Heading = currentBlock.Heading};
            if (currentBlock.RootPage != null)
            {
                model.Items =
                    EPiServer.Filters.FilterForVisitor.Filter(
                        contentRepository.GetChildren<PageData>(currentBlock.RootPage)
                        ).Cast<PageData>();
            }

            return PartialView(model);
        }
    }
}
