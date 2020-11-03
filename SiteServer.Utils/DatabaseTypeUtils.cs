using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using Datory;

namespace SiteServer.Utils
{
    public class DatabaseTypeUtils
    {
        public static DatabaseType GetEnumType(string typeStr)
        {
            var retVal = DatabaseType.SqlServer;

            if (Equals(DatabaseType.MySql, typeStr))
            {
                retVal = DatabaseType.MySql;
            }
            else if (Equals(DatabaseType.SqlServer, typeStr))
            {
                retVal = DatabaseType.SqlServer;
            }
            else if (Equals(DatabaseType.PostgreSql, typeStr))
            {
                retVal = DatabaseType.PostgreSql;
            }
            else if (Equals(DatabaseType.Oracle, typeStr))
            {
                retVal = DatabaseType.Oracle;
            }

            return retVal;
        }

        public static bool Equals(DatabaseType type, string typeStr)
        {
            if (string.IsNullOrEmpty(typeStr)) return false;
            if (string.Equals(type.Value.ToLower(), typeStr.ToLower()))
            {
                return true;
            }
            return false;
        }

        public static bool Equals(string typeStr, DatabaseType type)
        {
            return Equals(type, typeStr);
        }

        public static ListItem GetListItem(DatabaseType type, bool selected)
        {
            var item = new ListItem(type.Value, type.Value);
            if (selected)
            {
                item.Selected = true;
            }
            return item;
        }

        public static void AddListItems(ListControl listControl)
        {
            if (listControl == null) return;
            listControl.Items.Add(GetListItem(DatabaseType.MySql, false));
            listControl.Items.Add(GetListItem(DatabaseType.SqlServer, false));
            listControl.Items.Add(GetListItem(DatabaseType.PostgreSql, false));
            listControl.Items.Add(GetListItem(DatabaseType.Oracle, false));
        }

        public static string DataToJson(DataSet metaData, string msg)
        {
            DataTable resultInfo = new DataTable("success");
            resultInfo.Columns.Add("RETURN_CODE", Type.GetType("System.String"));
            resultInfo.Columns.Add("ERROR_MSG", Type.GetType("System.String"));
            DataRow newRow = resultInfo.NewRow();
            if (metaData == null || metaData.Tables.Count <= 0 || metaData.Tables[0].Rows.Count <= 0)
            {
                newRow["RETURN_CODE"] = "-1";
                if (string.IsNullOrEmpty(msg))
                {
                    newRow["ERROR_MSG"] = "查询结果为空";
                }
                else
                {
                    newRow["ERROR_MSG"] = msg;
                }
                resultInfo.Rows.Add(newRow);
                metaData.Tables.Add(resultInfo);
            }
            else
            {
                newRow["RETURN_CODE"] = "0";
                newRow["ERROR_MSG"] = "";
                resultInfo.Rows.Add(newRow);
                metaData.Tables.Add(resultInfo);
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            foreach (DataTable dt in metaData.Tables)
            {
                sb.Append(string.Format("\"{0}\":", dt.TableName));
                ArrayList arrayList = new ArrayList();
                foreach (DataRow dataRow in dt.Rows)
                {
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (DataColumn dataColumn in dt.Columns)
                    {
                        dictionary.Add(dataColumn.ColumnName, dataRow[dataColumn.ColumnName]);
                    }
                    arrayList.Add(dictionary);
                }
                sb.Append(serializer.Serialize(arrayList));
                sb.Append(",");
            }
            return sb.Remove(sb.Length - 1, 1).Append("}").ToString();
        }
    }
}
