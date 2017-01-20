using SiteCore.Business.Components;
using SiteCore.Business.Entities;
using SiteCore.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Services
{
    
    public class SubscriberService : ISubscriberService
    {

        public bool AddSubscriber(Subscriber subscriber)
        {
            SubscriberComponent subCompoenent = new SubscriberComponent();
            return subCompoenent.AddSubscriber(subscriber); 
        }

        public List<Subscriber> ListSubscriber()
        {
            SubscriberComponent subCompoenent = new SubscriberComponent();
            return subCompoenent.ListSubscribers();
        }
    }
}
