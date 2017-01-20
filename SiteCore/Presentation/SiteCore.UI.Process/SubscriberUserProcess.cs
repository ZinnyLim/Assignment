using SiteCore.Business.Entities;
using SiteCore.UI.Process.SubscriberService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.UI.Process
{
    public class SubscriberUserProcess
    {
        public SubscriberUserProcess() {}

        public List<Subscriber> GetSubscriber() 
        {
            SubscriberServiceClient client = new SubscriberServiceClient(); 

            return client.ListSubscriber(); 

        }
    }
}
