using HighStreet.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HighStreet.Web.Controllers
{
    public class SubscriptionController : Umbraco.Web.Mvc.SurfaceController
    {

        [HttpPost]
        public ActionResult Subscribe(SubscriptionFormModel model)
        {
            TempData["Anchor"] = model.Anchor;
            if (!ModelState.IsValid)
            {
                
                return CurrentUmbracoPage();
            }

            TempData.Add("SubscribedSuccessfully", "Your Form was successfully submitted at " + DateTime.Now);

            return RedirectToCurrentUmbracoPage();
        }

    }
}