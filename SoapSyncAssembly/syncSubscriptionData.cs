namespace SoapSyncAssembly
{
    public partial class syncSubscriptionData
    {
        /*
            <MSISDN>string</MSISDN>
      <serviceId>string</serviceId>
      <productId>string</productId>
      <updateType>int</updateType>

      <productDetail>
        <notifySPURL xmlns="">string</notifySPURL>
        <operationTime xmlns="">string</operationTime>
        <subscriptionValidTime xmlns="">string</subscriptionValidTime>
        <subscriptionAddtionalInfo xmlns="">string</subscriptionAddtionalInfo>
      </productDetail>

        */

        private string MSISDNfield;
        private string serviceIdField;
        private string productIdField;
        private string updateTypeField;


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

        /// <remarks/>
        public string serviceId
        {
            get
            {
                return this.serviceIdField;
            }
            set
            {
                this.serviceIdField = value;
            }
        }
        public string productId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }

        public string updateType
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