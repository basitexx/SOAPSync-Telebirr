using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapSyncAssembly
{
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.csapi.org/schema/parlayx/data/v1_0")]
    class productDetail
    {
        /*
        <productDetail>
        <notifySPURL xmlns="">string</notifySPURL>
        <operationTime xmlns="">string</operationTime>
        <subscriptionValidTime xmlns="">string</subscriptionValidTime>
        <subscriptionAddtionalInfo xmlns="">string</subscriptionAddtionalInfo>
        </productDetail>
        */
        private string notifySPURLfield;
        private string operationTimefield;
        private string subscriptionValidTimefield;
        private string subscriptionAddtionalInfo;

        /// <remarks/>

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string notifySPURL
        {
            get
            {
                return this.notifySPURLfield;
            }
            set
            {
                this.notifySPURLfield = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string operationTime
        {
            get
            {
                return this.operationTimefield;
            }
            set
            {
                this.operationTimefield = value;
            }
        }
    }
}
