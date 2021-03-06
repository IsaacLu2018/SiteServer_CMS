using System;
using System.Web.UI.WebControls;

namespace SiteServer.Utils.Enumerations
{
    public enum ESecurityType
    {
        Public,
        Friends,
        SelfOnly
    }

    public class ESecurityTypeUtils
    {
        public static string GetValue(ESecurityType type)
        {
            if (type == ESecurityType.Public)
            {
                return "Public";
            }
            if (type == ESecurityType.Friends)
            {
                return "Friends";
            }
            if (type == ESecurityType.SelfOnly)
            {
                return "SelfOnly";
            }
            throw new Exception();
        }

        public static string GetText(ESecurityType type)
        {
            if (type == ESecurityType.Public)
            {
                return "所有人";
            }
            if (type == ESecurityType.Friends)
            {
                return "我的好友";
            }
            if (type == ESecurityType.SelfOnly)
            {
                return "只有我自己";
            }
            throw new Exception();
        }

        public static ESecurityType GetEnumType(string typeStr)
        {
            var retVal = ESecurityType.SelfOnly;

            if (Equals(ESecurityType.Public, typeStr))
            {
                retVal = ESecurityType.Public;
            }
            else if (Equals(ESecurityType.Friends, typeStr))
            {
                retVal = ESecurityType.Friends;
            }
            else if (Equals(ESecurityType.SelfOnly, typeStr))
            {
                retVal = ESecurityType.SelfOnly;
            }

            return retVal;
        }

        public static bool Equals(ESecurityType type, string typeStr)
        {
            if (string.IsNullOrEmpty(typeStr)) return false;
            if (string.Equals(GetValue(type).ToLower(), typeStr.ToLower()))
            {
                return true;
            }
            return false;
        }

        public static bool Equals(string typeStr, ESecurityType type)
        {
            return Equals(type, typeStr);
        }

        public static ListItem GetListItem(ESecurityType type, bool selected)
        {
            var item = new ListItem(GetText(type), GetValue(type));
            if (selected)
            {
                item.Selected = true;
            }
            return item;
        }

        public static void AddListItems(ListControl listControl)
        {
            if (listControl != null)
            {
                listControl.Items.Add(GetListItem(ESecurityType.Public, false));
                listControl.Items.Add(GetListItem(ESecurityType.Friends, false));
                listControl.Items.Add(GetListItem(ESecurityType.SelfOnly, false));
            }
        }
    }
}
