using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HighStreet.Web.Models
{
    public class SubscriptionFormModel
    {
        [DataType(DataType.MultilineText)]
        [Display(Name = "QUESTION/COMMENT/SUGGESTION")]
        public string Questions { get; set; }
        
        [Display(Name = "FIRST NAME")]
        public string FirstName { get; set; }
        
        [Display(Name = "LAST NAME")]
        public string LastName { get; set; }
        
        [Display(Name = "EMAIL")] 
        [Required]
        public string EmailAddress { get; set; }

        [Display(Name = "Receive periodic news and updates")]
        public bool NewsAndUpdates { get; set; }

        public string Anchor { get; set; }
    }
}