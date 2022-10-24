using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Models;

namespace HighStreet.Web.Models
{
    public class SubscriptionFormViewModel
    {
        public SubscriptionFormViewModel()
        {

        }
        public string Title { get; set; }
        public string Description { get; set; }
        public SubscriptionFormModel Model { get; set; }

    }
}