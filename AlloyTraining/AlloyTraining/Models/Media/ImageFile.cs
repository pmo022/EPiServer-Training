using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Image File", GUID = "1508a3e1-64aa-4af4-bafa-da225cbc45a0", Description = "")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class ImageFile : ImageData
    {
        
            [CultureSpecific]
            [Editable(true)]
            [Display(
                Name = "Description",
                Description = "Describe time Image",
                GroupName = SystemTabNames.Content,
                Order = 1)]
            public virtual string Description { get; set; }
        
    }
}