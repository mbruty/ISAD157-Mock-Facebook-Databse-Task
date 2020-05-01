using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookUI
{
    class Util
    {
        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
        //From https://stackoverflow.com/questions/661561/how-do-i-update-the-gui-from-another-thread
        //Needed to safely show the map pannel from a different thread
        //Map takes a while to load, so threadding is required to not lock GUI
        public static void SetControlPropertyThreadSafe(Control control, string name, object value)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, name, value });
            }
            else
            {
                control.GetType().InvokeMember(
                    name,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { value });
            }
        }

        public static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public static string EscapeSql(string text)
        {
            string result = "";
            foreach(char c in text)
            {
                if(c != '%' && c != '_' && c != '[' && c != ']' && c != '^' && c != '-' && c != ';')
                {
                    result += c;
                }
                else
                {
                    result += String.Format("\\{0}", c);
                }
            }
            return result;
        }
    }
}
