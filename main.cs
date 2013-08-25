using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.Windows.Automation;
using System.Reflection;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;




/*Future tasks:
-Fix label boxes to accomodate long item names
-finish the hotkey logic to save itemdetail page to database.
-Add tooltips to confusing controls
-VERYVERYVERYEND: keygen/obfuscator
 * 
 * 
 * 
Glitches/ errors to catch:
 * mousebox should always be on top, and not minimize with main form
 * try/catch the initial webresponse for the just added page
 * try/catch the label updating code
 * try/catch the tektek data generator in case link changes or user has no internet
*/
namespace windowHandler
{

    public class Singleton
    {
        private Singleton() { }

        public static init Instance{get;set;}
    }

    public class init
    {
        public IntPtr handle { get; set; }
        public string handlePlatform { get; set; }

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        //

        public init()
        {
            uint temp;
            handle = GetForegroundWindow();
            uint temp2 = GetWindowThreadProcessId(handle,out temp);
            handlePlatform = Process.GetProcessById(Convert.ToInt32(temp)).ProcessName;

            Program.GUIref.Invoke((MethodInvoker)delegate
                    {
                        Program.GUIref.textBox1.Text = handlePlatform;
                    });
        }
    }

    public class urlHandler
    {
        public static ManualResetEvent MRE {get; set;}
        public static bool handleChange = false;
        string urlGen;
        MethodInfo mi;

        public void platformSorter()
        {
            MRE = new ManualResetEvent(false);
            MRE.WaitOne();

            try
            {

                    string method = "Get" + Singleton.Instance.handlePlatform + "Url";
                    mi = this.GetType().GetMethod(method);

            }

            catch
            {
            }

            this.parseLoop();
        }

        public void parseLoop()
        {
           // string urlParse;
            string compareUrl = "";

            while (true)
            {
                if (handleChange)
                {
                    Singleton.Instance.handle = init.GetForegroundWindow();
                    uint temp;
                    uint temp2 = init.GetWindowThreadProcessId(Singleton.Instance.handle, out temp);

                    Singleton.Instance.handlePlatform = Process.GetProcessById(Convert.ToInt32(temp)).ProcessName;
                    try
                    {
                        Program.GUIref.Invoke((MethodInvoker)delegate
                        {
                            Program.GUIref.textBox1.Text = Singleton.Instance.handlePlatform;
                        });
                    }
                    catch { }
                }
                string method = "Get" + Singleton.Instance.handlePlatform + "Url";
                mi = this.GetType().GetMethod(method);
                try { urlGen = (string)mi.Invoke(this, null); }
                catch
                {
                    try
                    {
                        Program.GUIref.Invoke((MethodInvoker)delegate
                        {
                            Program.GUIref.textBox2.Text = "";
                        });
                    }
                    catch { }
                }

               // urlParse = urlGen.Substring(urlGen.IndexOf("?id=") + 4);

                if (compareUrl != urlGen)
                {
                    Program.GUIref.Invoke((MethodInvoker)delegate
                    {
                        Program.GUIref.textBox2.Text = urlGen;
                    });

                }
                compareUrl = urlGen; 
                Thread.Sleep(200);
            }
        }

        public string GetoperaUrl()
        {
            AutomationElement element;
            try
            {
                element = AutomationElement.FromHandle(Singleton.Instance.handle);
            }
            catch { return " "; }
            if (element == null)
                return " ";

            AutomationElement edit = element.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));
            try { return ((ValuePattern)edit.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string; }
            catch { return ""; }
        }

        public string GetchromeUrl()
        {
            AutomationElement element = null;
            try { element = AutomationElement.FromHandle(Singleton.Instance.handle); }
            catch { }
            if (element == null)
                return " ";

            AutomationElement edit = element.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));
            try { return ((ValuePattern)edit.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string; }
            catch { return ""; }
        }

        public string GetiexploreUrl()
        {

            AutomationElement element = AutomationElement.FromHandle(Singleton.Instance.handle);
            if (element == null)
                return " ";

            AutomationElement rebar = element.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.ClassNameProperty, "ReBarWindow32"));
            if (rebar == null)
                return " ";
            
            AutomationElement edit = rebar.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

            return ((ValuePattern)edit.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
        }

        public string GetfirefoxUrl()
        {
            AutomationElement element = AutomationElement.FromHandle(Singleton.Instance.handle);
            if (element == null)
                return " ";

            AutomationElement doc = element.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Document));
            if (doc == null)
                return " ";
            
            return ((ValuePattern)doc.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
        }
    }



    public static class Program
    {
        public static GUI GUIref;
        public static Form4 GUIref4;
        public static Form2 Formref;
        public static Form3 Formrefer;

        [STAThread]
        static void Main()
        {
            urlHandler urlh = new urlHandler();
            Thread url = new Thread(urlh.platformSorter);
            url.IsBackground = true;
            url.Start();
            InterceptMouse.entry();
        }
    }
}
