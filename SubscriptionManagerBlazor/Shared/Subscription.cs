using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace SubscriptionManagerBlazor.Shared
{
    public class Subscription
    {

        public int Id { get; set; }
        public int Name { get; set; }
        public int Company { get; set; }
        public double Price { get; set; }

        public DateTime DateCreated { get; set; }

        public int RenewalDay { get; set; }
    }
}
