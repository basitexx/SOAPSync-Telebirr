using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public partial class C2BPaymentQueryRequest
    {
        private string TransTypeField;

        private string TransIDField;

        private string TransTimeField;

        private string BusinessShortCodeField;

        private string MSISDNField;

        private string BillRefNumberField;

        /// <remarks/>
        public string TransType
        {
            get
            {
                return this.TransTypeField;
            }
            set
            {
                this.TransTypeField = value;
            }
        }

        /// <remarks/>
        public string TransID
        {
            get
            {
                return this.TransIDField;
            }
            set
            {
                this.TransIDField = value;
            }
        }

        /// <remarks/>
        public string TransTime
        {
            get
            {
                return this.TransTimeField;
            }
            set
            {
                this.TransTimeField = value;
            }
        }

        /// <remarks>
        public string BusinessShortCode
        {
            get
            {
                return this.BusinessShortCodeField;
            }
            set
            {
                this.BusinessShortCodeField = value;
            }
        }

        /// <remarks>
        public string MSISDN    
        {
            get
            {
                return this.MSISDNField;
            }
            set
            {
                this.MSISDNField = value;
            }
        }

        /// <remarks>
        public string BillRefNumber
        {
            get
            {
                return this.BillRefNumberField;
            }
            set
            {
                this.BillRefNumberField = value;
            }
        }
    }
}
