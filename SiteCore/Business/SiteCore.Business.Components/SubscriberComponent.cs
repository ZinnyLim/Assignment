using SiteCore.Business.Entities;
using SiteCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Business.Components
{
    public class SubscriberComponent
    {
        private ISubscriberDAC subscriberDAC;
        //public SubscriberComponent(ISubscriberDAC subscriberIn) 
        //{
        //    subscriberDAC = subscriberIn; 
        //}

        public SubscriberComponent()
        {
           
        }


        public bool AddSubscriber(Subscriber subscriber)
        {
            subscriberDAC = new SubscriberDAC();
            return subscriberDAC.Create(subscriber); 
        }

        public List<Subscriber> ListSubscribers()
        {
            subscriberDAC = new SubscriberDAC();
            return subscriberDAC.List(); 

        }

    }
}
