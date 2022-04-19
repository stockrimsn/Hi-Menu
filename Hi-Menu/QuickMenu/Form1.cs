using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace QuickMenu
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        public void DuvarKagidiAyarla(String yol)
        {
            SystemParametersInfo(0x14, 0, yol, 0x01 | 0x02);
        }
        string oyu, mon;
        bool var = false;
        bool var2 = false;
        bool Turkish = false;
        bool English = true;
        bool sonlandir = false;
        bool yenile = false;
        bool calistir = false;
        bool masaustu = false;
        bool klasor = false;
        bool arka = false;
        bool ozel = false;
        bool calis = false;
        bool btnclick = true;
        bool formTasi = false;
        bool butonTasi = false;
        string id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15, id16, id17, id18, id19, id20;
        private const bool V = true;
        int ts = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse);
        public Form1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 913, 87, 20, 20));
            InitializeComponent();
            #region ButonaEventEkleme
            //Tüm butonlara eventlarını dinamik olarak elkme
            foreach (var item in this.Controls)//Form a eklenen tüm controller
            {
                if (item is Button) // gelen kontrol buton ise
                {
                    var Btn = (Button)item;
                    Btn.MouseDown += Btn_MouseDown; //event ekle
                    Btn.MouseMove += Btn_MouseMove; //event ekle
                    Btn.MouseUp += Btn_MouseUp;//event ekle
                    buttonPoints.Add(Btn.Name, Btn.Location);//buton lokasyonunu ekle

                }
                ButtonIlkPoints = buttonPoints;//buton ilk lokasyonlarını sakla
            }
            #endregion

        }
        #region ButonSurukleBirakIcinEventlar

        Dictionary<string, Point> ButtonIlkPoints = new Dictionary<string, Point>();//buton ilk lokasyonlarını saklamak için
        Dictionary<string, Point> buttonPoints = new Dictionary<string, Point>();//buton anlık lokasyonlarını saklamak için
        string btnText = "";
        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (butonTasi)
            {
                var Btn = (Button)sender;
                Btn.Text = btnText;
                btnclick = true;
            }
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (butonTasi)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var Btn = (Button)sender;
                    Btn.Left += e.X - buttonPoints[Btn.Text].X;
                    Btn.Top += e.Y - buttonPoints[Btn.Text].Y;
                }
            }
        }
        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (butonTasi)
            {
                var Btn = (Button)sender;
                btnText = Btn.Text;
                Btn.Text = "Taşı";
                buttonPoints[Btn.Text] = e.Location;
                btnclick = false;
            }
        }
        #endregion

        private void form1_load(Object sender, EventArgs e)
        {
            Process AktifProgram = Process.GetCurrentProcess();
            /* Programımızın özelliklerini alabilmemiz için AktifProgram değişkenini tanımlıyoruz*/
            Process[] localByName = Process.GetProcessesByName("Hi-Menu");
            /* Çalışan Programlardan adı " Programim " olanların özellikleri localByName dizisine aktarılıyor.*/
            foreach (Process Prcs in localByName)
            {
                /* localByName dizisi içindeki değerler Prcs içine aktarılıyor.*/
                if (Prcs.Id.ToString() != AktifProgram.Id.ToString())
                {
                    Application.Exit();
                }
            }

                if (!Directory.Exists(@"C:\\Hi-Menu"))
                {
                    Directory.CreateDirectory(@"C:\\Hi-Menu");
                }
                if (Directory.Exists(@"C:\\Hi-Menu\\Data") && Directory.Exists(@"C:\\Hi-Menu\\Lang")) { }
                else if (!Directory.Exists(@"C:\\Hi-Menu\\Data") && Directory.Exists(@"C:\\Hi-Menu\\Lang"))
                {
                    Directory.CreateDirectory(@"C:\\Hi-Menu\\Data");
                }
                else if (!Directory.Exists(@"C:\\Lang") && Directory.Exists(@"C:\\Hi-Menu\\Data"))
                {
                    Directory.CreateDirectory(@"C:\\Hi-Menu\\Lang");
                }
                else if (!Directory.Exists(@"C:\\Data") && !Directory.Exists(@"C:\\Hi-Menu\\Lang"))
                {
                    Directory.CreateDirectory(@"C:\\Hi-Menu\\Data");
                    Directory.CreateDirectory(@"C:\\Hi-Menu\\Lang");
                }
                date.Text = DateTime.Now.ToString("HH:mm:ss      dd/MM/yyyy   MMMM   dddd");
                button4.PerformClick();
                xmlctrl();
                xmlctrl2();
                xmlctrl3();
                xmlctrl4();
                xmlctrl5();
                if (!var || !var2)
                {
                    XMLInsert1();
                    XMLInsert2();
                }
                langs();
                Secim.SelectedIndex = 0;
                timer1.Interval = 1000;
                timer1.Enabled = true;
            }

        private void comboBoxCTRL()
        {
            xmlctrl();
            xmlctrl2();
            xmlctrl3();
            xmlctrl4();
            xmlctrl5();
        }

        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        Point butonNoktasi = new Point(0, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString($"HH:mm:ss      dd/MM/yyyy   MMMM - dddd");
        }

        private void Form1_MouseDown(Object sender, MouseEventArgs e)
        {
            if (formTasi)
            {

            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    formTasiniyor = true;
                    baslangicNoktasi = new Point(e.X, e.Y);
                }
                if (e.Button == MouseButtons.Right)
                {
                }
                else
                {

                }
            }

        }
        private void langs()
        {
            if (Turkish)
            {
                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Lang\\Turkish.xml");
                XElement rootElement = xDoc.Root;
                int cint = Selectables.Items.Count;
                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    id1 = rehberimiz.Element("lang1").Value;
                    id2 = rehberimiz.Element("lang2").Value;
                    id3 = rehberimiz.Element("lang3").Value;
                    id4 = rehberimiz.Element("lang4").Value;
                    id5 = rehberimiz.Element("lang5").Value;
                    id6 = rehberimiz.Element("lang6").Value;
                    id7 = rehberimiz.Element("lang7").Value;
                    id8 = rehberimiz.Element("lang8").Value;
                    id9 = rehberimiz.Element("lang9").Value;
                    id10 = rehberimiz.Element("lang10").Value;
                    id11 = rehberimiz.Element("lang11").Value;
                    id12 = rehberimiz.Element("lang12").Value;
                    id13 = rehberimiz.Element("lang13").Value;
                    id14 = rehberimiz.Element("lang14").Value;
                    id15 = rehberimiz.Element("lang15").Value;
                    id16 = rehberimiz.Element("lang16").Value;
                    id17 = rehberimiz.Element("lang17").Value;
                    id18 = rehberimiz.Element("lang18").Value;
                    id19 = rehberimiz.Element("lang19").Value;
                }
            }
            else if (English)
            {
                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Lang\\English.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    id1 = rehberimiz.Element("lang1").Value;
                    id2 = rehberimiz.Element("lang2").Value;
                    id3 = rehberimiz.Element("lang3").Value;
                    id4 = rehberimiz.Element("lang4").Value;
                    id5 = rehberimiz.Element("lang5").Value;
                    id6 = rehberimiz.Element("lang6").Value;
                    id7 = rehberimiz.Element("lang7").Value;
                    id8 = rehberimiz.Element("lang8").Value;
                    id9 = rehberimiz.Element("lang9").Value;
                    id10 = rehberimiz.Element("lang10").Value;
                    id11 = rehberimiz.Element("lang11").Value;
                    id12 = rehberimiz.Element("lang12").Value;
                    id13 = rehberimiz.Element("lang13").Value;
                    id14 = rehberimiz.Element("lang14").Value;
                    id15 = rehberimiz.Element("lang15").Value;
                    id16 = rehberimiz.Element("lang16").Value;
                    id17 = rehberimiz.Element("lang17").Value;
                    id18 = rehberimiz.Element("lang18").Value;
                    id19 = rehberimiz.Element("lang19").Value;
                }
            }

            button5.Text = id1;
            button4.Text = id2;
            button6.Text = id3;
            button1.Text = id4;
            button3.Text = id5;
            calc.Text = id6;
            cmd.Text = id7;
            Secim.Items.Clear();
            Secim.Items.AddRange(new object[] {
            id8,
            id9,
            id10});
            Secim.SelectedIndex = 0;
            button18.Text = id11;
            deleyt.Text = id12;
            butonlarıKilitleToolStripMenuItem.Text = id14;
            butonlarınYerleriniDeğiştirToolStripMenuItem.Text = id13;
            btnLocationDefault.Text = id15;
            ekleToolStripMenuItem.Text = id16;
            oyunEkleToolStripMenuItem.Text = id17;
            programEkleToolStripMenuItem.Text = id18;
            siteEkleToolStripMenuItem.Text = id19;
        }
        private void Form1_MouseMove(Object sender, MouseEventArgs e)
        {

            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void Form1_MouseUp(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formTasiniyor = false;
            }
            if (e.Button == MouseButtons.Right)
            {

            }
            else
            {

            }
        }
        private void Explorer(object sender, EventArgs e)
        {
            if (btnclick)
            {
                ts++;

                if (ts % 2 == 0)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
                    stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    stratInfo.FileName = "cmd.exe";
                    stratInfo.Arguments = "/C taskkill /F /IM explorer.exe";
                    process.StartInfo = stratInfo;
                    process.Start();
                }
                else
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
                    stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    stratInfo.FileName = "cmd.exe";
                    stratInfo.Arguments = "/C C:/Windows/explorer.exe";
                    process.StartInfo = stratInfo;
                    process.Start();

                }
            }
            else
            {
                masaustu = true;
            }
        }

        private void Kapat(object sender, EventArgs e)
        {
            if (btnclick)
            {
                Application.Exit();
            }
        }

        private void Klasor(object sender, EventArgs e)
        {
            if (btnclick)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
                stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                stratInfo.FileName = "cmd.exe";
                stratInfo.Arguments = "/C explorer.exe";
                process.StartInfo = stratInfo;
                process.Start();
            }
            else
            {
                klasor = true;
            }
        }

        private void Gorev(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Taskmgr.exe");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                string[] s;
                s = comboBox1.Text.Split(' ');
                foreach (string kelime in s)
                {
                    try
                    {
                        string app = kelime;
                        foreach (var islem in Process.GetProcessesByName(app))
                        {
                            islem.Kill();
                            button4.PerformClick();
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                comboBox1.Text = "";
                button4.PerformClick();
            }
            else
            {
                sonlandir = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
                stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                stratInfo.FileName = "cmd.exe";
                stratInfo.Arguments = "/C notepad";
                process.StartInfo = stratInfo;
                process.Start();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"E:\HMakinesi.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
            stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            stratInfo.FileName = "cmd.exe";
            stratInfo.Arguments = "/C start E:/Oyunlar";
            process.StartInfo = stratInfo;
            process.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\domin\AppData\Local\Discord\app-1.0.9003\Discord.exe");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
                dosya.Title = "Qucik Menu";
                dosya.ShowDialog();
                string DosyaYolu = dosya.FileName;
                DuvarKagidiAyarla(DosyaYolu);
            }
            else
            {
                ozel = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                foreach (var process in Process.GetProcessesByName("wallpaper64"))
                {
                    process.Kill();
                }
            }
            else
            {
                arka = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
            stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            stratInfo.FileName = "cmd.exe";
            stratInfo.Arguments = "/C start www.twitch.tv";
            process.StartInfo = stratInfo;
            process.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
            stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            stratInfo.FileName = "cmd.exe";
            stratInfo.Arguments = "/C start www.youtube.com";
            process.StartInfo = stratInfo;
            process.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Steam\steam.exe");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\OBS Studio\OBS");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Program Files\Nox\bin\Nox.exe");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnclick)
            {
                if (Selectables.Text != "")
                {
                    button18.Visible = true;
                }
                else
                {
                    button18.Visible = false;
                }
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCTRL();

            if (btnclick)
            {
                if (Secim.Text == "")
                {
                    button18.Visible = true;
                    Selectables.Visible = true;
                }
                if (Secim.Text == id8)
                {
                    button18.Visible = true;
                    Selectables.Visible = true;
                    load();
                }
                if (Secim.Text == id9)
                {
                    button18.Visible = true;
                    Selectables.Visible = true;
                    load();
                }
                if (Secim.Text == id10)
                {
                    button18.Visible = true;
                    Selectables.Visible = true;
                    load();
                }
            }
        }
        private void xmlctrl()
        {
            string dosya_dizini = @"C:\Hi-Menu\Data\Games.xml";
            if (File.Exists(dosya_dizini) == true)
            {
            }
            else
            {

                FileStream fs = new FileStream(dosya_dizini, FileMode.OpenOrCreate);

                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<datas> "
                    + Environment.NewLine + "</datas>";
                fs.Flush();
                fs.Close();

                File.AppendAllText(dosya_dizini, YazilacakIcerik);
            }
        }
        private void xmlctrl2()
        {
            string dosya_dizini = @"C:\Hi-Menu\Data\Programs.xml";
            if (File.Exists(dosya_dizini) == true)
            {
            }
            else
            {

                FileStream fs = new FileStream(dosya_dizini, FileMode.OpenOrCreate);

                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<datas> "
                    + Environment.NewLine + "</datas>";
                fs.Flush();
                fs.Close();

                File.AppendAllText(dosya_dizini, YazilacakIcerik);
            }
        }
        private void xmlctrl3()
        {
            string dosya_dizini = @"C:\Hi-Menu\Data\Sites.xml";
            if (File.Exists(dosya_dizini) == true)
            {
            }
            else
            {

                FileStream fs = new FileStream(dosya_dizini, FileMode.OpenOrCreate);

                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<datas> "
                    + Environment.NewLine + "</datas>";
                fs.Flush();
                fs.Close();

                File.AppendAllText(dosya_dizini, YazilacakIcerik);
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                Form3 fr3 = new Form3();
                fr3.ShowDialog();
            }
        }

        private void cmd_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                Process.Start("cmd.exe");
            }
        }

        private void Secim_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Selectables_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void xmlctrl4()
        {
            string dosya_dizini = @"C:\\Hi-Menu\\Lang\\Turkish.xml";
            if (File.Exists(dosya_dizini) == true)
            {
                var = true;
            }
            else
            {

                FileStream fs = new FileStream(dosya_dizini, FileMode.OpenOrCreate);

                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<datas> "
                    + Environment.NewLine + "</datas>";
                fs.Flush();
                fs.Close();

                File.AppendAllText(dosya_dizini, YazilacakIcerik);
            }
        }
        private void xmlctrl5()
        {
            string dosya_dizini = @"C:\\Hi-Menu\\Lang\\English.xml";
            if (File.Exists(dosya_dizini) == true)
            {
                var2 = true;
            }
            else
            {

                FileStream fs = new FileStream(dosya_dizini, FileMode.OpenOrCreate);

                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<datas> "
                    + Environment.NewLine + "</datas>";
                fs.Flush();
                fs.Close();

                File.AppendAllText(dosya_dizini, YazilacakIcerik);
            }
        }
        private static void XMLInsert1()
        {
            XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Lang\\English.xml");
            XElement rootElement = xDoc.Root;
            XElement newElement = new XElement("langs");
            XElement nd1 = new XElement("lang1", "Kill Task");
            XElement nd2 = new XElement("lang2", "Refresh");
            XElement nd3 = new XElement("lang3", "Run");
            XElement nd4 = new XElement("lang4", "Close/Open Desktop");
            XElement nd5 = new XElement("lang5", "Open Folder");
            XElement nd6 = new XElement("lang6", "Calculator");
            XElement nd7 = new XElement("lang7", "Command Prompt (CMD)");
            XElement nd8 = new XElement("lang8", "Games");
            XElement nd9 = new XElement("lang9", "Programs");
            XElement nd10 = new XElement("lang10", "Sites");
            XElement nd11 = new XElement("lang11", "Run");
            XElement nd12 = new XElement("lang12", "Delete");
            XElement nd13 = new XElement("lang13", "Change Button Location");
            XElement nd14 = new XElement("lang14", "Lock Buttons");
            XElement nd15 = new XElement("lang15", "Reset Button Locations");
            XElement nd16 = new XElement("lang16", "Add");
            XElement nd17 = new XElement("lang17", "Add Game");
            XElement nd18 = new XElement("lang18", "Add Program");
            XElement nd19 = new XElement("lang19", "Add Site");

            newElement.Add(nd1, nd2, nd3, nd4, nd5, nd6, nd7, nd8, nd9, nd10, nd11, nd12, nd13, nd14, nd15, nd16, nd17, nd18, nd19);
            rootElement.Add(newElement);
            xDoc.Save(@"C:\\Hi-Menu\\Lang\\English.xml");
        }
        private static void XMLInsert2()
        {
            XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Lang\\Turkish.xml");
            XElement rootElement = xDoc.Root;
            XElement newElement = new XElement("langs");
            XElement nd1 = new XElement("lang1", "İşlemi Sonlandır");
            XElement nd2 = new XElement("lang2", "Yenile");
            XElement nd3 = new XElement("lang3", "Çalıştır");
            XElement nd4 = new XElement("lang4", "Masaüstünü Kapat / Aç");
            XElement nd5 = new XElement("lang5", "Klasör Aç");
            XElement nd6 = new XElement("lang6", "Hesap Makinesi");
            XElement nd7 = new XElement("lang7", "Komut İstemi (CMD)");
            XElement nd8 = new XElement("lang8", "Oyunlar");
            XElement nd9 = new XElement("lang9", "Programlar");
            XElement nd10 = new XElement("lang10", "Siteler");
            XElement nd11 = new XElement("lang11", "Çalıştır");
            XElement nd12 = new XElement("lang12", "Sil");
            XElement nd13 = new XElement("lang13", "Butonların Yerlerini Değiştir");
            XElement nd14 = new XElement("lang14", "Butonları Kilitle");
            XElement nd15 = new XElement("lang15", "Butonları İlk Konumlarına Getir");
            XElement nd16 = new XElement("lang16", "Ekle");
            XElement nd17 = new XElement("lang17", "Oyun Ekle");
            XElement nd18 = new XElement("lang18", "Program Ekle");
            XElement nd19 = new XElement("lang19", "Site Ekle");

            newElement.Add(nd1, nd2, nd3, nd4, nd5, nd6, nd7, nd8, nd9, nd10, nd11, nd12, nd13, nd14, nd15, nd16, nd17, nd18, nd19);
            rootElement.Add(newElement);
            xDoc.Save(@"C:\\Hi-Menu\\Lang\\Turkish.xml");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                if (Secim.Text == "Siteler")
                {
                    Form2 fr2 = new Form2();
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
                    stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    stratInfo.FileName = "cmd.exe";
                    string cmd = "/C start " + oyu;
                    stratInfo.Arguments = cmd;
                    process.StartInfo = stratInfo;
                    process.Start();
                    Secim.Text = "";
                    Selectables.Text = "";
                }
                else
                {
                    System.Diagnostics.Process.Start(@oyu);
                    Secim.Text = "";
                    Selectables.Text = "";
                }
            }
            else
            {
                calis = true;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (btnclick)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo stratInfo = new System.Diagnostics.ProcessStartInfo();
                stratInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                stratInfo.FileName = "cmd.exe";
                stratInfo.Arguments = "/C start " + comboBox1.Text;
                process.StartInfo = stratInfo;
                process.Start();
                Selectables.Text = "";
                Secim.Text = "";
                comboBox1.Text = "";
                button4.PerformClick();
            }
            else
            {
                calistir = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                comboBox1.Items.Clear();
                islem();
            }
            else
            {
                yenile = true;
            }
        }

        public void islem()
        {
            Process[] islem = Process.GetProcesses();
            foreach (Process prc in islem)
            {
                if (prc.MainWindowTitle == "")
                {

                }
                else
                {
                    comboBox1.Items.Add($"{prc.ProcessName} ---- {prc.MainWindowTitle} ---- {prc.Id}");
                    comboBox1.Text = "";
                }
            }
        }
        private void butonlarınYerleriniDeğiştirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formTasi = true;
            butonTasi = true;
            button18.Visible = true;
        }


        private void butonlarıKilitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTasi = false;
            butonTasi = false;
            btnclick = true;
            button18.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (btnclick)
            {
                if (Application.OpenForms[0] == this)
                {
                    Application.Restart();
                }
                else
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Close();
                }
            }
        }

        private void btnLocationDefault_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)//Form a eklenen tüm controller
            {
                if (item is Button) // gelen kontrol buton ise
                {
                    var Btn = (Button)item; //object gelen butonu buton tipine dönüştür
                    Btn.Location = ButtonIlkPoints[Btn.Name]; //İlk lokasyonunu setle  
                } 
            }
        }
        private void load()
        {
            if (Secim.Text == id8)
            {
                Selectables.Items.Clear();
                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Games.xml");
                XElement rootElement = xDoc.Root;
                int cint = Selectables.Items.Count;
                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    Selectables.Items.Add(rehberimiz.Element("DosyaAdi").Value);
                    oyu = rehberimiz.Element("DosyaYolu").Value;
                }
            }
            else if (Secim.Text == id9)
            {
                Selectables.Items.Clear();
                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Programs.xml");
                XElement rootElement = xDoc.Root;
                int cint = Selectables.Items.Count;
                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    Selectables.Items.Add(rehberimiz.Element("DosyaAdi").Value);
                    oyu = rehberimiz.Element("DosyaYolu").Value;
                }
            }
            else if (Secim.Text == id10)
            {
                Selectables.Items.Clear();
                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Sites.xml");
                XElement rootElement = xDoc.Root;
                int cint = Selectables.Items.Count;
                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    Selectables.Items.Add(rehberimiz.Element("DosyaAdi").Value);
                    oyu = rehberimiz.Element("DosyaYolu").Value;
                }
            }
        }
        private void oyunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Secim.SelectedIndex = 0;
                string secilendosyayolu;
                openFileDialog1.ShowDialog();
                secilendosyayolu = openFileDialog1.FileName;
                string dosyaAdi = openFileDialog1.SafeFileName;
                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Games.xml");
                XElement rootElement = xDoc.Root;
                XElement newElement = new XElement("Oyun");
                int cint = Selectables.Items.Count + 1;
                XAttribute xAttribute = new XAttribute("ID", cint);
                XElement katElement = new XElement("DosyaYolu", secilendosyayolu);
                XElement adiElement = new XElement("DosyaAdi", cint + "  " + dosyaAdi);
                newElement.Add(xAttribute, katElement, adiElement);
                rootElement.Add(newElement);
                xDoc.Save(@"C:\\Hi-Menu\\Data\Games.xml");
                load();
        }

        private void programEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secim.SelectedIndex = 1;
            string secilendosyayolu;
            openFileDialog1.ShowDialog();
            secilendosyayolu = openFileDialog1.FileName;
            string dosyaAdi = openFileDialog1.SafeFileName;
            string url = secilendosyayolu.Replace("URL=", "");
            url = url.Replace("\"", "");
            url = url.Replace("BASE", "");
            XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Programs.xml");
            XElement rootElement = xDoc.Root;
            XElement newElement = new XElement("Program");
            int cint = Selectables.Items.Count + 1;
            XAttribute xAttribute = new XAttribute("ID", cint);
            XElement katElement = new XElement("DosyaYolu", secilendosyayolu);
            XElement adiElement = new XElement("DosyaAdi", cint + "  " + dosyaAdi);
            newElement.Add(xAttribute, katElement, adiElement);
            rootElement.Add(newElement);
            xDoc.Save(@"C:\\Hi-Menu\\Data\Programs.xml");
            load();
        }



        private void siteEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secim.SelectedIndex = 2;
            string secilendosyayolu;
            Form2 fr2 = new Form2();
            fr2.ShowDialog();
            secilendosyayolu = fr2.kate;
            string dosyaAdi = fr2.kati;
            XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Sites.xml");
            XElement rootElement = xDoc.Root;
            XElement newElement = new XElement("Site");
            int cint = Selectables.Items.Count + 1;
            XAttribute xAttribute = new XAttribute("ID", cint);
            XElement katElement = new XElement("DosyaYolu", secilendosyayolu);
            XElement adiElement = new XElement("DosyaAdi", cint + "  " + dosyaAdi);
            newElement.Add(xAttribute, katElement, adiElement);
            rootElement.Add(newElement);
            xDoc.Save(@"C:\\Hi-Menu\\Data\Sites.xml");
            load();
        }

        private void deleyt_Click(object sender, EventArgs e)
        {
            if (Secim.Text == id8)
            {
                string cumle;
                string[] s;
                cumle = Selectables.Text;
                s = cumle.Split(' ', ',', '.', '-', '<', '>', ';');
                string fdelete = s[0];

                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Games.xml");
                XElement rootElement = xDoc.Root;

                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    if (rehberimiz.Attribute("ID").Value == fdelete)
                    {
                        rehberimiz.Remove();
                    }
                }
                xDoc.Save(@"C:\\Hi-Menu\\Data\\Games.xml");
                Selectables.Text = "";
                Selectables.Items.Clear();
                load();
            }
            else if (Secim.Text == id9)
            {
                string cumle;
                string[] s;
                cumle = Selectables.Text;
                s = cumle.Split(' ', ',', '.', '-', '<', '>', ';');
                string fdelete = s[0];

                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Programs.xml");
                XElement rootElement = xDoc.Root;

                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    if (rehberimiz.Attribute("ID").Value == fdelete)
                    {
                        rehberimiz.Remove();
                    }
                }
                xDoc.Save(@"C:\\Hi-Menu\\Data\\Programs.xml");
                Selectables.Text = "";
                Selectables.Items.Clear();
                load();
            }
            else if (Secim.Text == id10)
            {
                string cumle;
                string[] s;
                cumle = Selectables.Text;
                s = cumle.Split(' ', ',', '.', '-', '<', '>', ';');
                string fdelete = s[0];

                XDocument xDoc = XDocument.Load(@"C:\\Hi-Menu\\Data\\Sites.xml");
                XElement rootElement = xDoc.Root;

                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    if (rehberimiz.Attribute("ID").Value == fdelete)
                    {
                        rehberimiz.Remove();
                    }
                }
                xDoc.Save(@"C:\\Hi-Menu\\Data\\Sites.xml");
                Selectables.Text = "";
                Selectables.Items.Clear();
                load();
            }
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            if (btnclick) 
            {
                English = true;
                Turkish = false;
                btnLang.Visible = false;
                btnLang2.Visible = true;
                langs();
            }
        }

        private void btnLang2_Click(object sender, EventArgs e)
        {
            if (btnclick)
            {
                Turkish = true;
                English = false;
                btnLang.Visible = true;
                btnLang2.Visible = false;
                langs();
            }
        }
    }
}
