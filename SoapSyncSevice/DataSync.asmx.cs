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
    public class DataSync : System.Web.Services.WebService
    {
        [SoapDocumentMethodAttribute("", RequestElementName = "syncOrderRelation", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
        [WebMethod]
        public syncOrderRelationResponse syncOrderRelation(syncOrderRelation syncOrderRelation)
        {

            var context = new SoapSyncEntities();
            // Insert and get the SyncID
            // Create UserId for sync
            // Create Named parameter for sync

            ObjectParameter Output = new ObjectParameter("msg", typeof(Int32));
            context.Sync_SP_OrderCreate(syncOrderRelation.spID, syncOrderRelation.productID, syncOrderRelation.serviceID, syncOrderRelation.serviceList
                , syncOrderRelation.updateType, syncOrderRelation.updateTime, syncOrderRelation.updateDesc, syncOrderRelation.effectiveTime, syncOrderRelation.expiryTime
                , Output);

            context.SaveChanges();

            int OrderId = Convert.ToInt32(Output.Value);

            // Create UserId for sync
            Tbl_UserID uid = new Tbl_UserID();
            uid.ID = syncOrderRelation.userID.ID;
            uid.type = syncOrderRelation.userID.type;
            uid.SyncId = OrderId;
            context.Tbl_UserID.Add(uid);

            // Create Named parameter for sync
            // Convert to DataTable.
            DataTable table = ConvertListToDataTable(syncOrderRelation.extensionInfo);
            List<Tbl_extensionInfo> data = new List<Tbl_extensionInfo>();

            foreach (DataRow row in table.Rows)
            {
                Tbl_extensionInfo item = GetItem<Tbl_extensionInfo>(row);
                data.Add(item);
            }
            //Tbl_extensionInfo ext= (Tbl_extensionInfo)data;

            context.Tbl_extensionInfo.Add(data.First());
            
            //foreach (NamedParameter item in syncOrderRelation.extensionInfo)
            //{ 
            //    Tbl_NamedParameter ext = new Tbl_NamedParameter();
            //    ext.key = item.key;
            //    ext.value = item.value;
            //    ext.SyncId = OrderId;
            //    context.Tbl_NamedParameter.Add(ext);
            //}

            //Save changes
            context.SaveChanges();


            syncOrderRelationResponse a = new syncOrderRelationResponse();
            a.result = OrderId;
            a.resultDescription = "OK: " + syncOrderRelation.userID.ID;
            //foreach (NamedParameter i in syncOrderRelation.extensionInfo)
            //{
            //    NamedParameter input = new NamedParameter();
            //    input.key = i.key;
            //    input.value = i.value;
            //    //a.extensionInfo = new List<NamedParameter>();
            //    a.extensionInfo.ad(input);
            //}
            return a;
        }

        private static Tbl_extensionInfo GetItem<Tbl_extensionInfo>(DataRow dr)
        {
            Type temp = typeof(Tbl_extensionInfo);
            Tbl_extensionInfo obj = Activator.CreateInstance<Tbl_extensionInfo>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    object value = dr[column.ColumnName];
                    if (value == DBNull.Value) 
                        dr[column.ColumnName] = null;

                    else if(value == new SoapSyncAssembly.Tbl_syncOrderRelation())
                        dr[column.ColumnName] = null;
                    //else
                    //if(pro.Name == column.ColumnName)

                    try {
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    }
                    catch(Exception ex)
                    {
                        if (ex.Message.Contains("Object of type 'System.String'"))
                            pro.SetValue(obj, Convert.ToInt32(dr[column.ColumnName]), null);

                        if (ex.Message.Contains("Object of type 'System.Int32'"))
                            pro.SetValue(obj, Convert.ToBoolean(dr[column.ColumnName]), null);
                        
                    }
                   // else
                        //continue;
                }
            }
            return obj;
        }

        private DataTable ConvertListToDataTable(NamedParameter[] extensionInfo)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            //int columns = 0;
            foreach (var i in extensionInfo)
            {
                //if (extensionInfo > columns)
                //{
                //++columns;// = array.Length;
                //}
                table.Columns.Add(i.key);
            }

            // Add columns.
            //for (int i = 0; i < columns; i++)
            //{
            //    table.Columns.Add();
            //}

            // Add rows.
            int c = 0;
            table.Rows.Add();
            foreach (var array in extensionInfo)
            {
                table.Rows[0][c] = array.value;
                ++c;                        
            }

            return table;
        }
    }


}
