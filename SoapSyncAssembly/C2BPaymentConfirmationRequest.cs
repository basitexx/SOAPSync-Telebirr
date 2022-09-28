using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    public partial class C2BPaymentConfirmationRequest
    {
        private string TransTypeField;

        private string TransIDField;

        private string TransTimeField;

        private string TransAmountField;

        private string BusinessShortCodeField;

        private string BillRefNumberField;

        private string InvoiceNumberField;

        private string OrgAccountBalanceField;

        private string ThirdPartyTransIDField;

        private string MSISDNField;

        private KYCInfo KYCInfoField;

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

        /// <remarks>
        public string TransAmount
        {
            get
            {
                return this.TransAmountField;
            }
            set
            {
                this.TransAmountField = value;
            }
        }

        /// <remarks>
        public string InvoiceNumber
        {
            get
            {
                return this.InvoiceNumberField;
            }
            set
            {
                this.InvoiceNumberField = value;
            }
        }

        /// <remarks>
        public string OrgAccountBalance
        {
            get
            {
                return this.OrgAccountBalanceField;
            }
            set
            {
                this.OrgAccountBalanceField = value;
            }
        }

        /// <remarks>
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

        /// <remarks>
        public KYCInfo KYCInfo
        {
            get
            {
                return this.KYCInfoField;
            }
            set
            {
                this.KYCInfoField = value;
            }
        }
    }
}
