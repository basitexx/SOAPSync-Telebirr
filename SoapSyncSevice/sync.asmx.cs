using SoapSyncAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Reflection;
using System.Xml.Serialization;
using System.Net.NetworkInformation;
using System.Net;

namespace SoapSyncSevice
{
    /// <summary>
    /// Summary description for DataSync
    /// </summary>

    [WebService(Namespace = "http://cps.huawei.com/cpsinterface/c2bpayment")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    [SoapDocumentService(RoutingStyle = SoapServiceRoutingStyle.RequestElement)]
    public class soap : System.Web.Services.WebService
    {
        public string GetMACAddress()
        {
            int i = 0;
            try
            {
            start:
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.
                IPAddress ipAddress = ipHostInfo.AddressList[i];

                if (ipAddress.ToString().Contains("74.2"))
                    return ipAddress.ToString();
                else
                {
                    i++;
                    goto start;
                    /*ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.
                    ipAddress = ipHostInfo.AddressList[1];
                    return ipAddress.ToString();*/
                }
            }
            catch (Exception ex)
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.
                IPAddress ipAddress = ipHostInfo.AddressList[i - 1];
                return ipAddress.ToString();
            }
        }

        

        /// 
        /// </summary>
        /// <param name="C2BPaymentQueryRequest"></param>
        /// <returns>C2BPaymentQueryResult </returns>
        /// 
        [SoapDocumentMethodAttribute("", RequestElementName = "C2BPaymentQueryRequest", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
        [WebMethod]
        [return: XmlElement("C2BPaymentQueryResult")]
        public C2BPaymentQueryResult C2BPaymentQueryRequest(C2BPaymentQueryRequest C2BPaymentQueryRequest)
        {
            C2BPaymentQueryResult a = new C2BPaymentQueryResult();

            try
            {
                // Do your thing here

                a.ResultCode = "0";
                a.ResultDesc = "Success";
                a.TransID = "10001"; // retrive fromn the recieved request
                a.BillRefNumber = "TX10001"; //reference for the bill
                a.UtilityName = "KORA TRIP";
                a.CustomerName = "Driver Name"; // Get the driver name From DB.
                a.Amount = "300";

                return a;
            }
            catch (Exception ex)
            {
                //var context = new SubscriptionEntities();
                string Errmsg = "";
                if (ex.InnerException != null)
                    if (ex.InnerException.InnerException != null)
                    {
                        Errmsg = ex.InnerException.InnerException.Message;
                    }
                    else
                    {
                        Errmsg = ex.InnerException.Message;
                    }
                else
                    Errmsg = ex.Message;

                /*SS_Tbl_Error err = new SS_Tbl_Error();
                err.Error = Errmsg;
                err.Source = ex.Source;
                err.Trace = ex.StackTrace;
                err.Time = DateTime.Now.ToShortDateString();
                context.SS_Tbl_Error.Add(err);
                context.SaveChanges();*/

                a.ResultCode = "2";
                a.ResultDesc = Errmsg;

                return a;
            }
        }

        /// 
        /// </summary>
        /// <param name="C2BPaymentValidationRequest"></param>
        /// <returns>C2BPaymentValidationResult </returns>
        /// 
        [SoapDocumentMethodAttribute("", RequestElementName = "C2BPaymentValidationRequest ", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
        [WebMethod]
        [return: XmlElement("C2BPaymentValidationResult")]
        public C2BPaymentValidationResult C2BPaymentValidationRequest(C2BPaymentValidationRequest C2BPaymentValidationRequest)
        {
            C2BPaymentValidationResult rv = new C2BPaymentValidationResult();

            try
            {
                // Do your thing here

                rv.ResultCode = "0";
                rv.ResultDesc = "Success";
                rv.ThirdPartyTransID = "10"; // retrive fromn the recieved request
              
                return rv;
            }
            catch (Exception ex)
            {
                //var context = new SubscriptionEntities();
                string Errmsg = "";
                if (ex.InnerException != null)
                    if (ex.InnerException.InnerException != null)
                    {
                        Errmsg = ex.InnerException.InnerException.Message;
                    }
                    else
                    {
                        Errmsg = ex.InnerException.Message;
                    }
                else
                    Errmsg = ex.Message;

                /*SS_Tbl_Error err = new SS_Tbl_Error();
                err.Error = Errmsg;
                err.Source = ex.Source;
                err.Trace = ex.StackTrace;
                err.Time = DateTime.Now.ToShortDateString();
                context.SS_Tbl_Error.Add(err);
                context.SaveChanges();*/

                rv.ResultCode = "2";
                rv.ResultDesc = Errmsg;

                return rv;
            }

        }

        /// 
        /// </summary>
        /// <param name="C2BPaymentConfirmationRequest "></param>
        /// <returns>C2BPaymentValidationResult </returns>
        /// 
        [SoapDocumentMethodAttribute("", RequestElementName = "C2BPaymentConfirmationRequest  ", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
        [WebMethod]
        [return: XmlElement("C2BPaymentConfirmationResult")]
        public string C2BPaymentConfirmationRequest(C2BPaymentConfirmationRequest C2BPaymentConfirmationRequest)
        {            
            try
            {
                // Do your thing here               
                return "0";
            }
            catch (Exception ex)
            {
                //var context = new SubscriptionEntities();
                string Errmsg = "";
                if (ex.InnerException != null)
                    if (ex.InnerException.InnerException != null)
                    {
                        Errmsg = ex.InnerException.InnerException.Message;
                    }
                    else
                    {
                        Errmsg = ex.InnerException.Message;
                    }
                else
                    Errmsg = ex.Message;

                /*SS_Tbl_Error err = new SS_Tbl_Error();
                err.Error = Errmsg;
                err.Source = ex.Source;
                err.Trace = ex.StackTrace;
                err.Time = DateTime.Now.ToShortDateString();
                context.SS_Tbl_Error.Add(err);
                context.SaveChanges();*/
                               
                return "1"; //Error
            }
        }
    }
}
