using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]

    public partial class C2BPaymentValidationResult
    {
        private string ResultCodeField;

        private string ResultDescField;

        private string ThirdPartyTransIDField;

        /// <remarks/>
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

        /// <remarks/>
        public string ResultDesc
        {
            get
            {
                return this.ResultDescField;
            }
            set
            {
                this.ResultDescField = value;
            }
        }

        /// <remarks/>
        public string ThirdPartyTransID
        {
            get
            {
                return this.ThirdPartyTransIDField;
            }
            set
            {
                this.ThirdPartyTransIDField = value;
            }
        }
    }
}
