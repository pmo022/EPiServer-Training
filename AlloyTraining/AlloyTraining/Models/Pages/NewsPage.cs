using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "9422637c-2e00-4def-adf7-77c6ed28f1ed", Description = "")]
    public class NewsPage : StandardPage
    {
        [Display(Order = 315, Name = "Main Listing")]
        public virtual ListingBlock MainListing { get; set; }

        
    }
}