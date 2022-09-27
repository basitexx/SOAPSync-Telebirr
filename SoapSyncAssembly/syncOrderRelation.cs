using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.csapi.org/schema/parlayx/data/sync/v1_0/local")]
    public partial class syncOrderRelation
    {

        private UserID userIDField;

        private string spIDField;

        private string productIDField;

        private string serviceIDField;

        private string serviceListField;

        private int updateTypeField;

        private string updateTimeField;

        private string updateDescField;

        private string effectiveTimeField;

        private string expiryTimeField;

        private NamedParameter[] extensionInfoField;

        /// <remarks/>
        public UserID userID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }

        /// <remarks/>
        public string spID
        {
            get
            {
                return this.spIDField;
            }
            set
            {
                this.spIDField = value;
            }
        }

        /// <remarks/>
        public string productID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        public string serviceID
        {
            get
            {
                return this.serviceIDField;
            }
            set
            {
                this.serviceIDField = value;
            }
        }

        /// <remarks/>
        public string serviceList
        {
            get
            {
                return this.serviceListField;
            }
            set
            {
                this.serviceListField = value;
            }
        }

        /// <remarks/>
        public int updateType
        {
            get
            {
                return this.updateTypeField;
            }
            set
            {
                this.updateTypeField = value;
            }
        }

        /// <remarks/>
        public string updateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }

        /// <remarks/>
        public string updateDesc
        {
            get
            {
                return this.updateDescField;
            }
            set
            {
                this.updateDescField = value;
            }
        }

        /// <remarks/>
        public string effectiveTime
        {
            get
            {
                return this.effectiveTimeField;
            }
            set
            {
                this.effectiveTimeField = value;
            }
        }

        /// <remarks/>
        public string expiryTime
        {
            get
            {
                return this.expiryTimeField;
            }
            set
            {
                this.expiryTimeField = value;
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
