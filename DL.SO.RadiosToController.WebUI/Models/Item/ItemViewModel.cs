using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DL.SO.RadiosToController.WebUI.Models.Item
{
    public class ItemViewModel
    {
        [Required]
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string MFGNumber { get; set; }

        public IList<ItemPartViewModel> Parts { get; set; }

        public IEnumerable<ItemOptionViewModel> AvailableItemOptions { get; set; }
    }
}