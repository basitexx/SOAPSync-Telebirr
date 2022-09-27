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

    [WebService(Namespace = "http://www.csapi.org/schema/parlayx/data/sync/v1_0/local")]
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
        /// //
        /// 
        /// </summary>
        /// <param name="syncOrderRelation"></param>
        /// <returns>syncOrderRelationResponse </returns>
        /// 
        [SoapDocumentMethodAttribute("", RequestElementName = "syncOrderRelation", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
        [WebMethod]
        [return: XmlElement("syncOrderRelationResponse")]
        public syncOrderRelationResponse syncOrderRelation(syncOrderRelation syncOrderRelation)
        {
            syncOrderRelationResponse a = new syncOrderRelationResponse();

          
            try
            {
                var context = new SubscriptionEntities();
                // Create UserId for sync
                if (syncOrderRelation.updateType == 1)
                {
                    SS_Tbl_SubCategory sub = new SS_Tbl_SubCategory();
                    sub = context.SS_Tbl_SubCategory.First();
                    if (sub != null)
                    {
                        SS_Tbl_Subscription sync = new SS_Tbl_Subscription();
                        sync.Mobile = syncOrderRelation.userID.ID;
                        sync.Product_Id = syncOrderRelation.productID;
                        sync.DateSubscription = DateTime.Now;
                        sync.SubCategoryId = sub.Id;
                        sync.Status = true;

                        context.SS_Tbl_Subscription.Add(sync);
                        context.SaveChanges();
                    }

                    a.result = "0";
                    a.resultDescription = "OK";

                    return a;
                }
                else
                {
                    /// update and terminate               
                    /* SS_Tbl_Subscription sync = new SS_Tbl_Subscription();
                     sync = context.SS_Tbl_Subscription.FirstOrDefault(p => p.Mobile == syncOrderRelation.userID.ID);
                     if (sync != null)
                     {
                         sync.DateTermination = DateTime.Now;
                         sync.Status = false;                        
                         context.SaveChanges();
                     }*/
                    SS_Tbl_SubCategory sub = new SS_Tbl_SubCategory();
                    sub = context.SS_Tbl_SubCategory.First();
                    if (sub != null)
                    {
                        SS_Tbl_Subscription sync = new SS_Tbl_Subscription();
                        sync.Mobile = syncOrderRelation.userID.ID;
                        sync.Product_Id = syncOrderRelation.productID;
                        sync.DateTermination = DateTime.Now;
                        sync.SubCategoryId = sub.Id;
                        sync.Status = false;

                        context.SS_Tbl_Subscription.Add(sync);
                        context.SaveChanges();
                    }

                    a.result = "0";
                    a.resultDescription = "OK";

                    return a;
                }
            }
            catch (Exception ex)
            {
                var context = new SubscriptionEntities();
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

                SS_Tbl_Error err = new SS_Tbl_Error();
                err.Error = Errmsg;
                err.Source = ex.Source;
                err.Trace = ex.StackTrace;
                err.Time = DateTime.Now.ToShortDateString();
                context.SS_Tbl_Error.Add(err);
                context.SaveChanges();

                a.result = "1";
                a.resultDescription = Errmsg;

                return a;
            }

        }
    }
}
