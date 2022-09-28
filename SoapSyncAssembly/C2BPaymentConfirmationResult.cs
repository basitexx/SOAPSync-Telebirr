using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]

    public partial class C2BPaymentConfirmationResult
    {
        private string ResultCodeField;

        /// <remarks/>
        //[System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, AttributeName =" ", )]
        [XmlElement(IsNullable =true)]
        public string ResultCode
        {
            get
            {
                return this.ResultCodeField;
            }
            set
            {
                this.ResultCodeField = value;
            }
        }
        
    }
}
