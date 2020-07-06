using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DL.SO.RadiosToController.WebUI.Models.Item
{
    public class ItemPartViewModel
    {
        [Required]
        public int PartId { get; set; }
        public string MFGNumber { get; set; }
        public string PartName { get; set; }
        public PartActionType SelectedActionType { get; set; }
    }
}