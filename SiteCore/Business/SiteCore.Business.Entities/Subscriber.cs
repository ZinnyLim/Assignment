using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Business.Entities
{
    [DataContract]
    [Serializable]
    public partial class Subscriber
    {
        [DataMember]
        public int SubID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime SubscribeDate { get; set; }

        [DataMember]
        public DateTime TerminateDate { get; set; }

        [DataMember]
        public Boolean Status { get; set; } 

    }
}
