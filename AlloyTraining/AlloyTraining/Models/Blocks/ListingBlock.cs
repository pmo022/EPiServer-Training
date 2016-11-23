using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "ced3a879-f04b-48ff-a890-00b354aad721", Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 100)]
        public virtual string Heading { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 200)]
        public virtual PageReference RootPage { get; set; }

        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}