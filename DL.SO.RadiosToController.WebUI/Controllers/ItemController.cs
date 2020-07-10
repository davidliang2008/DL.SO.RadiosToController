using DL.SO.RadiosToController.WebUI.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DL.SO.RadiosToController.WebUI.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index()
        {
			// Retrieve data from persistence storage and save it to the view model.
			// But here I am just faking it.
			var vm = new ItemViewModel
			{
				ItemId = 123,
				ItemName = "Fake Item",
				Parts = new List<ItemPartViewModel>
				{
					new ItemPartViewModel
					{
						PartId = 1,
						PartName = "Part 1",
						SelectedActionType = PartActionType.Transfer
					},
					new ItemPartViewModel
					{
						PartId = 2,
						PartName = "Part 2",
						SelectedActionType = PartActionType.Transfer
					},
					new ItemPartViewModel
					{
						PartId = 3,
						PartName = "Part 3",
						SelectedActionType = PartActionType.Transfer
					},
					new ItemPartViewModel
					{
						PartId = 4,
						PartName = "Part 4",
						SelectedActionType = PartActionType.Transfer
					}
				},
                AvailableItemOptions = new List<ItemOptionViewModel>
                {
                    new ItemOptionViewModel
                    {
                        ItemInstanceId = 123,
                        ItemInstanceName = "Fake Item"
                    },
                    new ItemOptionViewModel
                    {
                        ItemInstanceId = 124,
                        ItemInstanceName = "Another Fake Item"
                    }
                }
			};

			return View(vm);
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(ItemViewModel model)
        {
            return View();
        }
    }
}