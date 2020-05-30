using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace SubscriptionManagerBlazor.Shared
{
    public class Subscription
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }

        public DateTime DateCreated { get; set; }

        public int RenewalDay { get; set; }
    }
}
