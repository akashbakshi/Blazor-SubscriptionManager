using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SubscriptionManagerBlazor.Shared
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter A Subscription Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter A Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Enter The Monthly Price")]
        public double Price { get; set; }

        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Enter The Renewal Day")]
        public int RenewalDay { get; set; }
    }
}
