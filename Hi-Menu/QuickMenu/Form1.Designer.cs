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

namespace QuickMenu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button5 = new System.Windows.Forms.Button();
            this.Selectables = new System.Windows.Forms.ComboBox();
            this.button18 = new System.Windows.Forms.Button();
            this.Secim = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.butonlarınYerleriniDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butonlarıKilitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLocationDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.deleyt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date = new System.Windows.Forms.Label();
            this.btnLang = new System.Windows.Forms.Button();
            this.btnLang2 = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.cmd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(321, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Masaüstünü Kapat / Aç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Explorer);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(321, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Klasör Aç";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Klasor);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(12, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "İşlemi Sonlandır";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Selectables
            // 
            this.Selectables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Selectables.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Selectables.FormattingEnabled = true;
            this.Selectables.Location = new System.Drawing.Point(654, 8);
            this.Selectables.Name = "Selectables";
            this.Selectables.Size = new System.Drawing.Size(167, 21);
            this.Selectables.TabIndex = 18;
            this.Selectables.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Selectables.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Selectables_KeyDown);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.button18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.Location = new System.Drawing.Point(654, 35);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 19;
            this.button18.Text = "Çalıştır";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // Secim
            // 
            this.Secim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Secim.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Secim.FormattingEnabled = true;
            this.Secim.Items.AddRange(new object[] {
            "Oyunlar",
            "Programlar",
            "Siteler"});
            this.Secim.Location = new System.Drawing.Point(562, 8);
            this.Secim.Name = "Secim";
            this.Secim.Size = new System.Drawing.Size(86, 21);
            this.Secim.TabIndex = 21;
            this.Secim.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.Secim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Secim_KeyDown);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(230, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Çalıştır";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 11);
            this.comboBox1.MaxLength = 48;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(126, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Yenile";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butonlarınYerleriniDeğiştirToolStripMenuItem,
            this.butonlarıKilitleToolStripMenuItem,
            this.btnLocationDefault,
            this.ekleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 92);
            // 
            // butonlarınYerleriniDeğiştirToolStripMenuItem
            // 
            this.butonlarınYerleriniDeğiştirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.butonlarınYerleriniDeğiştirToolStripMenuItem.Name = "butonlarınYerleriniDeğiştirToolStripMenuItem";
            this.butonlarınYerleriniDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.butonlarınYerleriniDeğiştirToolStripMenuItem.Text = "Butonların Yerlerini Değiştir";
            this.butonlarınYerleriniDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.butonlarınYerleriniDeğiştirToolStripMenuItem_Click_1);
            // 
            // butonlarıKilitleToolStripMenuItem
            // 
            this.butonlarıKilitleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.butonlarıKilitleToolStripMenuItem.Name = "butonlarıKilitleToolStripMenuItem";
            this.butonlarıKilitleToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.butonlarıKilitleToolStripMenuItem.Text = "Butonları Kilitle";
            this.butonlarıKilitleToolStripMenuItem.Click += new System.EventHandler(this.butonlarıKilitleToolStripMenuItem_Click);
            // 
            // btnLocationDefault
            // 
            this.btnLocationDefault.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLocationDefault.Name = "btnLocationDefault";
            this.btnLocationDefault.Size = new System.Drawing.Size(227, 22);
            this.btnLocationDefault.Text = "Butonları İlk Konumuna Getir";
            this.btnLocationDefault.Click += new System.EventHandler(this.btnLocationDefault_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunEkleToolStripMenuItem,
            this.programEkleToolStripMenuItem,
            this.siteEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // oyunEkleToolStripMenuItem
            // 
            this.oyunEkleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.oyunEkleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.oyunEkleToolStripMenuItem.Name = "oyunEkleToolStripMenuItem";
            this.oyunEkleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.oyunEkleToolStripMenuItem.Text = "Oyun Ekle";
            this.oyunEkleToolStripMenuItem.Click += new System.EventHandler(this.oyunEkleToolStripMenuItem_Click);
            // 
            // programEkleToolStripMenuItem
            // 
            this.programEkleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.programEkleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.programEkleToolStripMenuItem.Name = "programEkleToolStripMenuItem";
            this.programEkleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.programEkleToolStripMenuItem.Text = "Program Ekle";
            this.programEkleToolStripMenuItem.Click += new System.EventHandler(this.programEkleToolStripMenuItem_Click);
            // 
            // siteEkleToolStripMenuItem
            // 
            this.siteEkleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.siteEkleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.siteEkleToolStripMenuItem.Name = "siteEkleToolStripMenuItem";
            this.siteEkleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.siteEkleToolStripMenuItem.Text = "Site Ekle";
            this.siteEkleToolStripMenuItem.Click += new System.EventHandler(this.siteEkleToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(835, 2);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "↻";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Kapat);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // deleyt
            // 
            this.deleyt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleyt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.deleyt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleyt.Location = new System.Drawing.Point(746, 35);
            this.deleyt.Name = "deleyt";
            this.deleyt.Size = new System.Drawing.Size(75, 23);
            this.deleyt.TabIndex = 27;
            this.deleyt.Text = "Sil";
            this.deleyt.UseVisualStyleBackColor = false;
            this.deleyt.Click += new System.EventHandler(this.deleyt_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.ForeColor = System.Drawing.Color.Coral;
            this.date.Location = new System.Drawing.Point(9, 73);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 34;
            this.date.Text = "Date";
            // 
            // btnLang
            // 
            this.btnLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnLang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.btnLang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLang.Location = new System.Drawing.Point(746, 62);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(75, 23);
            this.btnLang.TabIndex = 35;
            this.btnLang.Text = "English";
            this.btnLang.UseVisualStyleBackColor = false;
            this.btnLang.Visible = false;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnLang2
            // 
            this.btnLang2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLang2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.btnLang2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLang2.Location = new System.Drawing.Point(746, 62);
            this.btnLang2.Name = "btnLang2";
            this.btnLang2.Size = new System.Drawing.Size(75, 23);
            this.btnLang2.TabIndex = 36;
            this.btnLang2.Text = "Türkçe";
            this.btnLang2.UseVisualStyleBackColor = false;
            this.btnLang2.Click += new System.EventHandler(this.btnLang2_Click);
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.calc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calc.Location = new System.Drawing.Point(462, 9);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(94, 23);
            this.calc.TabIndex = 37;
            this.calc.Text = "Hesap Makinesi";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // button17
            // 
            this.button17.BackgroundImage = global::Himanu.Properties.Resources.qm;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(835, 35);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 43);
            this.button17.TabIndex = 17;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // cmd
            // 
            this.cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(68)))), ((int)(((byte)(106)))));
            this.cmd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmd.Location = new System.Drawing.Point(462, 37);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(94, 38);
            this.cmd.TabIndex = 38;
            this.cmd.Text = "Command Prompt (CMD)";
            this.cmd.UseVisualStyleBackColor = false;
            this.cmd.Click += new System.EventHandler(this.cmd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(913, 87);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.cmd);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.btnLang2);
            this.Controls.Add(this.btnLang);
            this.Controls.Add(this.date);
            this.Controls.Add(this.deleyt);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Secim);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Selectables);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quick Menu";
            this.Load += new System.EventHandler(this.form1_load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox Selectables;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ComboBox Secim;
        private System.Windows.Forms.Button button6;
        private ComboBox comboBox1;
        private Button button4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem butonlarınYerleriniDeğiştirToolStripMenuItem;
        private ToolStripMenuItem butonlarıKilitleToolStripMenuItem;
        private Button button7;
        private ToolStripMenuItem btnLocationDefault;
        private Button button2;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem oyunEkleToolStripMenuItem;
        private ToolStripMenuItem programEkleToolStripMenuItem;
        private ToolStripMenuItem siteEkleToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Button deleyt;
        private Timer timer1;
        private Label date;
        private Button btnLang;
        private Button btnLang2;
        private Button calc;
        private Button cmd;
    }
}

