using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.csapi.org/schema/parlayx/data/sync/v1_0/local")]
    public partial class changeMSISDN
    {
        
        private string MSISDNfield;

        private string newMSISDNfield;

        private string timeStampfield;

      
       
        /// <remarks/>
        public string MSISDN
        {
            get
            {
                return this.MSISDNfield;
            }
            set
            {
                this.MSISDNfield = value;
            }
        }

        /// <remarks/>
        public string newMSISDN
        {
            get
            {
                return this.newMSISDNfield;
            }
            set
            {
                this.newMSISDNfield = value;
            }
        }

        /// <remarks/>
        public string timeStamp
        {
            get
            {
                return this.timeStampfield;
            }
            set
            {
                this.timeStampfield = value;
            }
        }
    }

}
