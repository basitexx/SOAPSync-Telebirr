using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.csapi.org/schema/parlayx/data/sync/v1_0/local")]
    public partial class syncMSISDNChange
    {
        private string MSISDNfield;

        private string newMSISDNfield;
        
        private NamedParameter[] extensionInfoField;


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

        //extension
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public NamedParameter[] extensionInfo
        {
            get
            {
                return this.extensionInfoField;
            }
            set
            {
                this.extensionInfoField = value;
            }
        }

    }
}
