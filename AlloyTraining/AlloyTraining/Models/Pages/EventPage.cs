using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "8c8c2c75-77dc-4545-af54-a11a4e446af4", Description = "")]
    public class EventPage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Header", Description = "Event Title / Headline", GroupName = SystemTabNames.Content)]
        public virtual string Header { get; set; }

        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        public virtual DateTime EventDate { get; set; }

        public virtual int Price { get; set; }

        [Display(Name = "Event Image", Description = "The Image for this event", GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

    }
}