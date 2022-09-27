using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.csapi.org/schema/parlayx/data/sync/v1_0/local")]
    public partial class syncMSISDNChangeResponse
    {
        private int resultField;

        private string resultDescriptionField;

        private NamedParameter[] extensionInfoField;

        /// <remarks/>
        public int result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        /// <remarks/>
        public string resultDescription
        {
            get
            {
                return this.resultDescriptionField;
            }
            set
            {
                this.resultDescriptionField = value;
            }
        }
        /// <remarks/>
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

