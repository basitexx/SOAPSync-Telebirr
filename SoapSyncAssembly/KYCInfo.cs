using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public partial class KYCInfo
    {

        private string KYCNameField;

        private string KYCValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string KYCName
        {
            get
            {
                return this.KYCNameField;
            }
            set
            {
                this.KYCNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string KYCValue
        {
            get
            {
                return this.KYCValueField;
            }
            set
            {
                this.KYCValueField = value;
            }
        }
    }
}
