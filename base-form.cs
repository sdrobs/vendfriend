using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Reflection;
using System.Globalization;
using System.Windows.Automation;

namespace windowHandler
{
    public partial class GUI : Form
    {
        public System.Windows.Forms.Timer sW;
        public bool first = true;
        private string save6;
        private string save7;
        
        public GUI()
        {
            InitializeComponent();
            //
            sW = new System.Windows.Forms.Timer();
            sW.Interval = 750;
            sW.Tick += new EventHandler(timerTicked);
            //
            GUI.kR = new keyReceive();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            GUI.RT = new Retriever();
            Singleton.Instance = new init();
            urlHandler.MRE.Set();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                List<string> itemdataArr;
                int count = 0;
                itemdataArr = RT.getitemdataArray();

                foreach (string str in itemdataArr)
                {
                    if ((str.LastIndexOf(textBox3.Text + ",", StringComparison.OrdinalIgnoreCase) == 0))
                    {
                        itemdataArr[count] = textBox3.Text + "," + textBox4.Text;
                        label8.Text = textBox3.Text + " price changed to " + textBox4.Text;
                        RT.setitemdataArray(itemdataArr);
                        break;
                    }
                    count++;
                }

                if (count == itemdataArr.Count)
                {
                    itemdataArr.Add(textBox3.Text + "," + textBox4.Text);
                    label8.Text = textBox3.Text + "," + textBox4.Text + " added to data sheet!";
                    RT.setitemdataArray(itemdataArr);
                }
            }
            else { MessageBox.Show("You must load a datasheet first!"); }
        }

        private void ItemData_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            //
            OFD.InitialDirectory = Application.StartupPath;
            OFD.RestoreDirectory = true;
            OFD.Multiselect = false;
            OFD.Filter = "(*.txt)|*.txt" ;
            OFD.ShowHelp = true;
            DialogResult result = OFD.ShowDialog();
            if (result == DialogResult.OK) 
            {
                this.textBox9.Text = OFD.FileName;
                RT.getDataStrings();
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("This could take up to 5 minutes. Are you sure you want to generate a new TekTek price sheet?", "Confirm Data Generation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               this.TopMost = false;
               Program.Formref = new Form2();
               Program.Formref.ShowDialog(this);
               this.TopMost = true;
               if (RT.complete)
               {
                   MessageBox.Show("Data sheet successfully created!");
                   RT.complete = false;
               }
               else
               {
                   if (File.Exists(Environment.CurrentDirectory + "//" + @"Gdata_Tek.txt"))
                   {
                       try
                       {
                           File.Delete(Environment.CurrentDirectory + "//" + @"Gdata_Tek.txt"); //not working at the moment
                       }
                       catch { }
                   }
                   MessageBox.Show("Failed to Create Tektek datasheet");
               }
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (Program.GUIref4 != null)
            {
                Program.GUIref4.Owner = null;
            }

            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            Program.Formrefer = new Form3();
            Program.Formrefer.Show(this);
            //showdialog disables the parent form as long as the child form is open
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.textBox5.Text = trackBar1.Value.ToString() + "%"; //need to connect to green criteria
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox5.Text.IndexOf("%") > -1)
                    this.trackBar1.Value = Convert.ToInt32(this.textBox5.Text.Remove(this.textBox5.Text.Length-1, 1));
                else
                {
                    this.trackBar1.Value = Convert.ToInt32(this.textBox5.Text);
                }
            }
            catch { textBox5.Text = trackBar1.Value.ToString() + "%"; }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox9.Text != "")
            {
                if (this.button7.Text == "Select Region")
                {
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    InterceptMouse.active = true;
                    Program.GUIref4 = new Form4();
                    Program.GUIref4.Show();
                    this.button7.Text = "Deselect";
                }
                else
                {
                    this.button7.Text = "Select Region";
                    Program.GUIref4.Hide();
                }
            }
            else
                MessageBox.Show("You must load a datasheet first!");
        }

        public void timerTicked(object obg, EventArgs e)
        {
            List<string> itemdataArr;
            itemdataArr = RT.getitemdataArray();
            int price = 0;
            foreach (string str in itemdataArr)
            {
                if ((str.LastIndexOf(textBox3.Text + ",", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    price = Convert.ToInt32(str.Split(',')[1]);
                    break;
                }
            }
            textBox4.Text = price.ToString();
            if (textBox3.Text == "")
                textBox4.ReadOnly = true;
            else
                textBox4.ReadOnly = false;
            //check array for item
            //if not found: Item not found
            //if found: display data and make price box non readonly

            sW.Stop();
            sW.Tick -= new EventHandler(timerTicked);
            first = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                if (textBox3.Text.IndexOf(";") >-1)
                {
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.IndexOf(";"),1);
                }

                if(textBox3.Text.IndexOf(",") > -1)
                {
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.IndexOf(","),1);
                }

                if (textBox3.Text.IndexOf("'") > -1)
                {
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.IndexOf("'"), 1);
                }

                if (this.textBox9.Text != "")
                {
                    if (first)
                    {
                        first = false;
                        sW.Tick += new EventHandler(timerTicked);
                        sW.Start();
                    }
                    else
                    {
                        sW.Stop();
                        sW.Start();
                    }
                }

                else
                {
                    MessageBox.Show("You must load a datasheet first!");
                    textBox3.Text = "";
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
               RT.min = Convert.ToInt32(textBox6.Text);
               save6 = textBox6.Text;
            }
            catch
            {
                if (textBox6.Text == "")
                {
                    textBox6.Text = "0";
                    save6 = "0";
                    RT.min = 0;
                }
                else
                    textBox6.Text = save6;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
               RT.max = Convert.ToInt32(textBox7.Text);
               save7 = textBox7.Text;
            }
            catch
            {
                    if (textBox7.Text == "")
                    {
                        textBox7.Text = "0";
                        save7 = "0";
                        RT.max = 0;
                    }
                    else
                        textBox7.Text = save7;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox7.ReadOnly == false)
            {
                textBox7.ReadOnly = true;
                textBox7.Text = "0";
                RT.max = -1;
            }
            else
            {
                textBox7.ReadOnly = false;
                RT.max = 0;
            }
        }

        protected override void WndProc(ref Message m)
        {
            // Trap the minimize and restore commands
            if (m.Msg == 0x0112)
            {
                if (Program.GUIref4 != null)
                {
                    if (m.WParam.ToInt32() == 0xf020) Program.GUIref4.Owner = null;
                    if (m.WParam.ToInt32() == 0xf120)
                    {
                        Program.GUIref4.Owner = this;
                        Program.GUIref4.WindowState = FormWindowState.Normal;
                    }
                }

                if (Program.Formrefer != null)
                {
                    if (m.WParam.ToInt32() == 0xf020) Program.Formrefer.Owner = null;
                    if (m.WParam.ToInt32() == 0xf120)
                    {
                        Program.Formrefer.Owner = this;
                        Program.Formrefer.WindowState = FormWindowState.Normal;
                    }
                }
            }
            base.WndProc(ref m);
        }

    }



    public class Retriever
    {
        public bool complete = false;
        public int max = -1;
        public int min = 0;
        private List<string> itemDataarr { get; set; }

        public string[] cleanNames(string[] names)
        {
            int counter = 0;

            foreach (string name in names)
            {
                int temp = name.IndexOf("'");
                if (temp > -1)
                    names[counter] = name.Remove(temp, 1);
                counter++;
            }

            return names;
        }

        public void setitemdataArray(List<string> itemdataArr)
        {
            itemDataarr = itemdataArr;
            File.Delete(Program.GUIref.textBox9.Text);
            using (StreamWriter sW = new StreamWriter(Program.GUIref.textBox9.Text))
            {
                foreach (string str in itemDataarr)
                {
                    if(str != "")
                    sW.Write(str+";");
                }
            }
            
        }

        public List<string> getitemdataArray()
        {
            return itemDataarr;
        }

        public void retrievePrices()
        {
            //
            string[] itemName = new string[6];
            int[] itemPrice = new int[6];
            string title = "";
            //

            HttpWebRequest request = (HttpWebRequest.Create(@"http://www.gaiaonline.com/marketplace/vendsearch/?sortBy=91") as HttpWebRequest);
            HttpWebResponse response = (request.GetResponse() as HttpWebResponse);

            using (Stream stream = response.GetResponseStream())
            {
                Regex titleCheck = new Regex(@"<abbr rel=", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                int bytesToRead = 8092;
                byte[] buffer = new byte[bytesToRead];
                string contents = "";
                int length = 0;
                int contentc = 0;
                MatchCollection m;

                while ((length = stream.Read(buffer, 0, bytesToRead)) > 0)
                {
                    // convert the byte-array to a string and add it to the rest of the
                    // contents that have been downloaded so far
                    contentc += length;
                    if (contentc > 14700)
                    {
                        contents += Encoding.UTF8.GetString(buffer, 0, length);
                        m = titleCheck.Matches(contents);
                        if (m.Count >= 6)
                        {

                            title = contents.Substring((m[0].Index - 1000), (m[5].Index - (m[0].Index - 1000)));
                            for (int i = 0; i < 6; i++)
                            {
                                title = title.Substring(title.IndexOf(@"<span>") + 6, (title.Length - (title.IndexOf(@"<span>") + 6)));
                                itemName[i] = title.Substring(0, title.IndexOf(@"<span>"));
                                title = title.Substring(title.IndexOf(@"<strong>") + 8, (title.Length - (title.IndexOf(@"<strong>") + 8)));
                                itemPrice[i] = int.Parse(title.Substring(0, title.IndexOf(@"</strong>")), NumberStyles.AllowThousands);
                            }
                            break;
                        }
                    }
                }
            }

            itemName = this.cleanNames(itemName);
            //itemname itemprice

            int count = 0;
            foreach (string str in itemName)
            {
                int price = 0;
                price = this.getPrice(str);
                this.comparePrice(str, price, itemPrice[count], count);
                count++;
            }

            itemName = null;
            itemPrice = null;
        }

        public void comparePrice(string IName, int price, int actPrice, int count)
        {
            Label ulabel = null;

            if (Program.Formrefer != null)
            {
                if (Program.Formrefer.Visible)
                {
                    FieldInfo pfi;

                    pfi = Program.Formrefer.GetType().GetField("ulabel" + count); //Gets the label 

                    ulabel = pfi.GetValue(Program.Formrefer) as Label;

                    ulabel.Text = IName + ":  " + price;
                }
            }

            FieldInfo fi;

            fi = Program.GUIref.GetType().GetField("plabel" + count); //Gets the label 

            Label label = fi.GetValue(Program.GUIref) as Label;

            if(IName.Length > 16)
            label.Text = IName.Substring(0,16) + "...:   " + price;
            else
            label.Text = IName + ":   " + price;


            if (price == 0)
            {
                label.BackColor = Color.Gray;
                    if (ulabel != null)
                        ulabel.BackColor = Color.Gray;
                //  picbox -> grey
            }



            else if ((actPrice > min) && ((actPrice < max) || max == -1) && (actPrice < (Program.GUIref.trackBar1.Value * .01 * price)))
            {//plabel+"
                label.BackColor = Color.LimeGreen;
                if (ulabel != null)
                    ulabel.BackColor = Color.LimeGreen;
            }

            else
            {
                label.BackColor = Color.Red;
                if (ulabel != null)
                    ulabel.BackColor = Color.Red;
            }

        }

        public void getDataStrings()
        {
            string itemData = string.Empty;
            try
            {
                using (StreamReader sR = new StreamReader(Program.GUIref.textBox9.Text))
                {
                    itemData = sR.ReadToEnd();
                }
            }
            catch { MessageBox.Show("Error: File was unable to be read."); Program.GUIref.textBox9.Text = ""; }

            itemDataarr = itemData.Split(';').ToList<string>();
            itemData = null;
        }

        public int getPrice (string searchTerm)
        {
            int price = 0;
            foreach (string str in itemDataarr)
            {
                if ((str.IndexOf(searchTerm + ",") == 0))
                {
                    price = Convert.ToInt32(str.Split(',')[1]);
                    break;
                }
            }
            return price;
        }

        public void tekDownloader()
        {
            if(File.Exists(Environment.CurrentDirectory + "//" + "Gdata_Tek.txt"))
                File.Delete(Environment.CurrentDirectory + "//" + "Gdata_Tek.txt");
            List<string> itemNamesarr = new List<string>();
            List<string> itemPricesarr = new List<string>();
            HttpWebRequest itemdataReq = (HttpWebRequest)HttpWebRequest.Create(@"http://www.tektek.org/dream/gdc/itemprices.js");
            itemdataReq.ContentType = "application/js; charset=utf-8";
            HttpWebResponse itemdataRes =
            (HttpWebResponse)itemdataReq.GetResponse();
            StreamReader myWebSource = new StreamReader(itemdataRes.GetResponseStream());
            string itemData = string.Empty;
            itemData = myWebSource.ReadToEnd();
            itemdataRes.Close();
            //
            HttpWebRequest itemnamesReq = (HttpWebRequest)HttpWebRequest.Create(@"http://www.tektek.org/dream/gdc/itemnames.js");
            itemnamesReq.ContentType = "application/js; charset=utf-8";
            HttpWebResponse itemnamesRes =
            (HttpWebResponse)itemnamesReq.GetResponse();
            StreamReader namesWebSource = new StreamReader(itemnamesRes.GetResponseStream());
            string itemNames = string.Empty;
            itemNames = namesWebSource.ReadToEnd();
            itemnamesRes.Close();
            //

            //in future, should put a 1 line regex, removing all instances of ; that aren't preceded by a '
            // Regex rgx = new Regex(".;");
            itemNames = itemNames.Replace("&#039;", "");
            itemNames = itemNames.Replace("&gt;", "");
            itemNames = itemNames.Replace("&lt;", "");
            itemNames = itemNames.Replace(";;OAO;;", "");
            itemNames = itemNames.Replace(";__;", "");
            itemNames = itemNames.Replace("&amp;", "");
            itemNames = itemNames.Replace("lt;", "");

            itemNamesarr = itemNames.Split(';').ToList<string>();
            itemPricesarr = itemData.Split(';').ToList<string>();
            itemData = null;
            itemNames = null;
            //
            int itemId = 0;
            int price = 0;
            int count = 0;
            try
            {
                Program.Formref.Invoke((MethodInvoker)delegate
                {
                    Program.Formref.progressBar1.Maximum = itemNamesarr.Count;
                });
            }
            catch { }
            //
            //
            int priceCount;
            using (StreamWriter sW = new StreamWriter(Environment.CurrentDirectory + "//" + @"Gdata_Tek.txt"))
            {
                foreach (string str in itemNamesarr)
                {
                    try
                    {
                        itemId = Convert.ToInt32(str.Substring(2, str.IndexOf(@"]") - 2));
                    }
                    catch { Console.WriteLine(str); }

                    priceCount = -1;
                    foreach (string stri in itemPricesarr)
                    {
                        if (stri.IndexOf(@"p[" + itemId + @"]") > -1)
                        {
                            price = Convert.ToInt32(stri.Substring(stri.IndexOf("=") + 1, stri.Length - (stri.IndexOf("=") + 1)));
                            break;
                        }
                        priceCount++;
                    }

                    try
                    {
                        if ((str.Substring(str.IndexOf("='") + 2, (str.Length - (str.IndexOf("='") + 2) - 1)) + ",") != "" && ((str.Substring(str.IndexOf("='") + 2, (str.Length - (str.IndexOf("='") + 2) - 1)) + ",")) != "ar n = [,")
                        {
                            sW.Write(str.Substring(str.IndexOf("='") + 2, (str.Length - (str.IndexOf("='") + 2) - 1)) + ",");
                            sW.Write(price + ";");
                        }
                    }
                    catch {}
                    count++;
                    try
                    {
                        if (Program.Formref.progressBar1.Maximum == count)
                        {
                            complete = true;
                            break;
                        }
                    }
                    catch { break; }

                    if (count % 200 == 0)
                    {
                        try
                        {
                            Program.Formref.Invoke((MethodInvoker)delegate
                            {
                                Program.Formref.progressBar1.Value = count;
                            });
                        }
                        catch { break; }
                    }
                    itemPricesarr.RemoveAt(priceCount);
                }
            }
            itemPricesarr = null;
            itemNamesarr = null;
            
            try
            {
                Program.Formref.Invoke((MethodInvoker)delegate
                {
                    Program.Formref.Dispose();
                });
            }
            catch { }
        }
    }

    public class keyReceive : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd,
            int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public keyReceive()
        {
            //UnregisterHotKey(Program.rstHandle, 2); -just documentation for unregistering in case needed later
            RegisterHotKey(this.Handle, 1, 1, (int)'Z');
            RegisterHotKey(this.Handle, 2, 2, (int)'R');
            RegisterHotKey(this.Handle, 3, 1, (int)'X');
        }

        protected override void WndProc(ref Message m)
        {
                if (m.Msg == 0x0312)
                {
                    int id = m.WParam.ToInt32();

                    if (id == 1)
                    {
                        Thread trd = new Thread(timeOutThread.doMethodKey);
                        trd.IsBackground = true;
                        trd.Start();
                    }

                    if (id == 2)
                    {
                        GUI.RT.retrievePrices();
                    }

                    if (id == 3)
                    {
                        //save itemdetails (input)
                        string title = "";

                        AutomationElement element = null;
                        try
                        {
                            element = AutomationElement.FromHandle(Singleton.Instance.handle);
                            title = element.Current.Name;
                            title = title.Split('|')[0];
                            title = title.Remove(title.Length - 1, 1);
                        }
                        catch { title = ""; }
                    }

                }

            base.WndProc(ref m);
        }

    }

    static class InterceptMouse
    {
        public static LowLevelMouseProc _proc = HookCallback;
        public static IntPtr _hookID = IntPtr.Zero;
        public static bool stopped = false;
        public static bool active = false;

        public static void entry()
        {
            _hookID = SetHook(_proc);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Program.GUIref = new GUI());
           UnhookWindowsHookEx(_hookID);
        }

        public static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        public delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            bool click = true;

            if (nCode >= 0 &&
                MouseMessages.WM_MOUSELEFT == (MouseMessages)wParam)
            {
                    urlHandler.handleChange = true;
                    if (active && !stopped)
                        click = false;
                    else
                        click = true;

                if (Program.GUIref4 != null)
                {
                    if (Program.GUIref4.Visible)
                    {
                        InterceptMouse.stopped = true;

                        if ((Cursor.Position.X < (Program.GUIref4.Location.X + Program.GUIref4.Width-3)) && (Cursor.Position.X > (Program.GUIref4.Location.X+3) && (Cursor.Position.Y < (Program.GUIref4.Location.Y + Program.GUIref4.Height-3) && (Cursor.Position.Y > (Program.GUIref4.Location.Y+3)))))
                        {
                            if (!InterceptMouse.active)
                            {
                                Thread trd = new Thread(timeOutThread.doMethod);
                                trd.IsBackground = true;
                                trd.Start();
                                //GUI.RT.retrievePrices();
                            }
                            else
                            {
                                InterceptMouse.active = false;
                                if (Program.GUIref4.first)
                                Program.GUIref.WindowState = System.Windows.Forms.FormWindowState.Normal;
                            }
                        }
                    }
                }
            }

            if (Program.GUIref4 != null)
            {
                if (Program.GUIref4.Visible)
                {
                    if (nCode >= 0 &&
                        MouseMessages.WM_MOUSEMOVE == (MouseMessages)wParam && !InterceptMouse.stopped)
                    {
                        int x = (Cursor.Position.X - Program.GUIref4.Width / 2);
                        int y = (Cursor.Position.Y - Program.GUIref4.Height / 2);
                        Program.GUIref4.Location = new Point(x, y);
                    }
                }
            }

            if (click)
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            else
                return new IntPtr(1);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSELEFT = 0x0201,
            WM_MOUSERIGHT = 0x0204
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
    }

    public static class timeOutThread
    {
        public static void doMethod()
        {
            GUI.RT.retrievePrices();
        }

        public static void doMethodKey()
        {
            string urlgen = Program.GUIref.textBox2.Text;
            //
            if (Program.GUIref.textBox9.Text == "")
                return;
            if (urlgen.IndexOf(@"www.gaiaonline.com/marketplace/itemdetail/") > -1)
            {
                if (urlgen.IndexOf(@"http://") == 0)
                { }
                else
                    urlgen = "http://" + urlgen;
                string[] itemName = new string[6];
                int[] itemPrice = new int[6];
                //
                HttpWebRequest request = null;
                try
                {
                    request = (HttpWebRequest.Create(urlgen) as HttpWebRequest);
                }
                catch { return; }
                HttpWebResponse response = (request.GetResponse() as HttpWebResponse);

                using (Stream stream = response.GetResponseStream())
                {
                    Regex titleCheck = new Regex(@"<strong>Average Buy Price:</strong>", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    int bytesToRead = 8092;
                    byte[] buffer = new byte[bytesToRead];
                    string contents = "";
                    int length = 0;
                    int contentc = 0;

                    while ((length = stream.Read(buffer, 0, bytesToRead)) > 0)
                    {
                        contentc += length;
                        if (contentc > 17500)
                        {
                            contents += Encoding.UTF8.GetString(buffer, 0, length);
                            break;
                        }
                    }
                    contents = contents.Substring(contents.IndexOf(@"<strong>Average Buy Price:</strong>") + 35, (contents.Length - (contents.IndexOf(@"<strong>Average Buy Price:</strong>") + 35)));
                    contents = contents.Substring(0, contents.IndexOf(@"gold") - 1);
                    contents = contents.Trim();

                    try
                    {
                        int contentsi = int.Parse(contents, NumberStyles.AllowThousands);
                        contents = contentsi.ToString();
                    }
                    catch
                    {
                        Program.GUIref.Invoke((MethodInvoker)delegate
                        {
                            Program.GUIref.label8.Text = "Error adding item";
                        });
                    }

                    string title = "";

                    AutomationElement element = null;
                    try
                    {
                        element = AutomationElement.FromHandle(Singleton.Instance.handle);
                        title = element.Current.Name;
                        title = title.Split('|')[0];
                        title = title.Remove(title.Length - 1, 1);
                    }
                    catch { title = ""; return; }

                    string[] titlea = new string[1];
                    titlea[0] = title;
                    title = GUI.RT.cleanNames(titlea)[0];

                    List<string> temp = GUI.RT.getitemdataArray();

                    int count = 0;
                    foreach (string str in temp)
                    {
                        if ((str.LastIndexOf(title + ",", StringComparison.OrdinalIgnoreCase) == 0))
                        {
                            temp[count] = title + "," + contents;
                            GUI.RT.setitemdataArray(temp);
                            Program.GUIref.Invoke((MethodInvoker)delegate
                            {
                                Program.GUIref.label8.Text = title + "," + contents + " updated in data sheet!";
                            });
                            break;
                        }
                        count++;
                    }

                    if (count == temp.Count)
                    {
                        temp.Add(title + "," + contents);
                        GUI.RT.setitemdataArray(temp);
                        Program.GUIref.Invoke((MethodInvoker)delegate
                        {
                            Program.GUIref.label8.Text = title + "," + contents + " added to data sheet!";
                        });
                    }
                }
            }
            else { }
        }
    }
}
