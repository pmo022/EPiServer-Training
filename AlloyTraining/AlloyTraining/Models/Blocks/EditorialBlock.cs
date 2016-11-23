using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "Editorial Block", GUID = "1fc4aef6-503e-4e1a-9208-070e7bd32a05")]
    public class EditorialBlock : BlockData
    {
        
        [Display(
            Name = "Main Body",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
         
    }
}