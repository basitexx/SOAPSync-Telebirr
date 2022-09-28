using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
   
    public partial class C2BPaymentQueryResult
    {
        private string ResultCodeField;

        private string ResultDescField;

        private string TransIDField;

        private string BillRefNumberField;

        private string UtilityNameField;

        private string CustomerNameField;

        private string AmountField;

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

        /// <remarks/>
        public string UtilityName
        {
            get
            {
                return this.UtilityNameField;
            }
            set
            {
                this.UtilityNameField = value;
            }
        }

        /// <remarks/>
        public string CustomerName
        {
            get
            {
                return this.CustomerNameField;
            }
            set
            {
                this.CustomerNameField = value;
            }
        }

        /// <remarks/>
        public string Amount
        {
            get
            {
                return this.AmountField;
            }
            set
            {
                this.AmountField = value;
            }
        }

        
    }
}
