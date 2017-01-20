using SiteCore.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Data
{
    public interface ISubscriberDAC
    {
        bool Create(Subscriber subscriber);

        List<Subscriber> List(); 
    }
}
