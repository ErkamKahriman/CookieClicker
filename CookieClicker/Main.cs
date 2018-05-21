using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CookieClicker.Properties;

namespace CookieClicker{
    public partial class CookierClickerMain : Form{
        public CookierClickerMain(){
            InitializeComponent();
        }

        private void cookiebutton_Click(object sender, EventArgs e){
            Settings.Default.Cookies += Settings.Default.Multipler;
            this.blockenterbutton.Focus();
        }

        public void UpdateCookies(){
            cookiecount.Text = @"Cookies: " + Settings.Default.Cookies;
            cpslabel.Text = "CPS: " + Settings.Default.Bots * Settings.Default.BotMultipler;
            Settings.Default.Save();
        }

        private void Shopbutton_Click(object sender, EventArgs e){
            Shop shop = new Shop();
            shop.ShowDialog();
            this.blockenterbutton.Focus();
        }

        private void CookierClickerMain_Load(object sender, EventArgs e){
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Length > 1) {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void updatecoinstimer_Tick(object sender, EventArgs e){
            this.UpdateCookies();
        }

        private void botclicktask_Tick(object sender, EventArgs e){
            Settings.Default.Cookies += Settings.Default.Bots * Settings.Default.BotMultipler;
        }

        private void authorlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Process.Start("https://github.com/ErkamKahriman");
        }
    }
}