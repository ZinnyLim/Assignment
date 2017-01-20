using SiteCore.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Services.Contracts
{
    [ServiceContract]
    public interface ISubscriberService
    {
        [OperationContract]
        [FaultContract(typeof(ProcessExecutionFault))]
        bool AddSubscriber(Subscriber subscriber);

        [OperationContract]
        [FaultContract(typeof(ProcessExecutionFault))]
        List<Subscriber> ListSubscriber();
    }
}
