using System;
using System.Windows.Forms;
using CookieClicker.Properties;

namespace CookieClicker{
    public partial class Shop : Form{
        public Shop(){
            InitializeComponent();
        }

        private void Multiplerbutton_Click(object sender, EventArgs e){
            switch (Settings.Default.Multipler){
                case 1:
                    this.buy(1000, "multipler");
                    break;
                case 2:
                    this.buy(2000, "multipler");
                    break;
                case 3:
                    this.buy(3000, "multipler");
                    break;
                case 4:
                    this.buy(4000, "multipler");
                    break;
                case 5:
                    this.buy(5000, "multipler");
                    break;
                case 6:
                    this.buy(6000, "multipler");
                    break;
                case 7:
                    this.buy(7000, "multipler");
                    break;
                case 8:
                    this.buy(8000, "multipler");
                    break;
                case 9:
                    this.buy(9000, "multipler");
                    break;
                default:
                    MessageBox.Show("You reached max Lvl.");
                    break;
            }
        }

        private void buy(int coins, string what){
            if (Settings.Default.Cookies >= coins){
                switch (what){
                    case "multipler":
                        Settings.Default.Multipler++;
                        break;
                    case "bot":
                        Settings.Default.Bots++;
                        break;
                    case "botmultipler":
                        Settings.Default.BotMultipler++;
                        break;
                }
                Settings.Default.Cookies -= coins;
            }else{
                int more = coins -= Settings.Default.Cookies;
                MessageBox.Show("You don't have enough cookies D:" + "\n" + "You need " + more + " Cookies more...", "Not enough Cookies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updatelvltimer_Tick(object sender, EventArgs e){
            this.updateshoplvl();
        }

        private void updateshoplvl(){
            this.Multiplerbutton.Text = "Multipler Lvl.: " + Settings.Default.Multipler;
            this.Botsbutton.Text = "Bots Lvl.: " + Settings.Default.Bots;
            this.BotMultiplerbutton.Text = "Bot Multipler Lvl.: " + Settings.Default.BotMultipler;
        }

        private void Botsbutton_Click(object sender, EventArgs e){
            switch (Settings.Default.Bots){
                case 0:
                    this.buy(1000, "bot");
                    break;
                case 1:
                    this.buy(2000, "bot");
                    break;
                case 2:
                    this.buy(3000, "bot");
                    break;
                case 3:
                    this.buy(4000, "bot");
                    break;
                case 4:
                    this.buy(5000, "bot");
                    break;
                case 5:
                    this.buy(6000, "bot");
                    break;
                case 6:
                    this.buy(7000, "bot");
                    break;
                case 7:
                    this.buy(8000, "bot");
                    break;
                case 8:
                    this.buy(9000, "bot");
                    break;
                case 9:
                    this.buy(10000, "bot");
                    break;
                default:
                    MessageBox.Show("You reached max Lvl.");
                    break;
            }
        }

        private void BotMultiplerbutton_Click(object sender, EventArgs e){
            switch (Settings.Default.BotMultipler){
                case 1:
                    this.buy(2000, "botmultipler");
                    break;
                case 2:
                    this.buy(3000, "botmultipler");
                    break;
                case 3:
                    this.buy(4000, "botmultipler");
                    break;
                case 4:
                    this.buy(5000, "botmultipler");
                    break;
                case 5:
                    this.buy(6000, "botmultipler");
                    break;
                case 6:
                    this.buy(7000, "botmultipler");
                    break;
                case 7:
                    this.buy(8000, "botmultipler");
                    break;
                case 8:
                    this.buy(9000, "botmultipler");
                    break;
                case 9:
                    this.buy(10000, "botmultipler");
                    break;
                default:
                    MessageBox.Show("You reached max Lvl.");
                    break;
            }
        }

        private void leaveshopbutton_Click(object sender, EventArgs e){
            this.Close();
        }

        private void Shop_Load(object sender, EventArgs e){
            this.updateshoplvl();
        }
    }
}
