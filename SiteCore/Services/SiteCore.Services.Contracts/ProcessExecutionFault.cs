using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Services.Contracts
{
    [DataContract]
    public class ProcessExecutionFault
    {
        private string _message = string.Empty;

        [DataMember]
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public ProcessExecutionFault()
        {
            this._message = "Error executing Business Process on back-end.";
        }

        public ProcessExecutionFault(string message)
        {
            this._message = message;
        }

    }
}
