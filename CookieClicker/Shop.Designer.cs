namespace CookieClicker
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.Multiplerbutton = new System.Windows.Forms.Button();
            this.updatelvltimer = new System.Windows.Forms.Timer(this.components);
            this.Botsbutton = new System.Windows.Forms.Button();
            this.BotMultiplerbutton = new System.Windows.Forms.Button();
            this.leaveshopbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Multiplerbutton
            // 
            this.Multiplerbutton.Location = new System.Drawing.Point(13, 13);
            this.Multiplerbutton.Name = "Multiplerbutton";
            this.Multiplerbutton.Size = new System.Drawing.Size(141, 41);
            this.Multiplerbutton.TabIndex = 0;
            this.Multiplerbutton.TabStop = false;
            this.Multiplerbutton.Text = "Multipler Lvl.: 1";
            this.Multiplerbutton.UseVisualStyleBackColor = true;
            this.Multiplerbutton.Click += new System.EventHandler(this.Multiplerbutton_Click);
            // 
            // updatelvltimer
            // 
            this.updatelvltimer.Enabled = true;
            this.updatelvltimer.Interval = 200;
            this.updatelvltimer.Tick += new System.EventHandler(this.updatelvltimer_Tick);
            // 
            // Botsbutton
            // 
            this.Botsbutton.Location = new System.Drawing.Point(12, 60);
            this.Botsbutton.Name = "Botsbutton";
            this.Botsbutton.Size = new System.Drawing.Size(141, 40);
            this.Botsbutton.TabIndex = 1;
            this.Botsbutton.TabStop = false;
            this.Botsbutton.Text = "Bots Lvl.: 1";
            this.Botsbutton.UseVisualStyleBackColor = true;
            this.Botsbutton.Click += new System.EventHandler(this.Botsbutton_Click);
            // 
            // BotMultiplerbutton
            // 
            this.BotMultiplerbutton.Location = new System.Drawing.Point(12, 106);
            this.BotMultiplerbutton.Name = "BotMultiplerbutton";
            this.BotMultiplerbutton.Size = new System.Drawing.Size(141, 40);
            this.BotMultiplerbutton.TabIndex = 2;
            this.BotMultiplerbutton.TabStop = false;
            this.BotMultiplerbutton.Text = "Bot Multipler Lvl.: 1";
            this.BotMultiplerbutton.UseVisualStyleBackColor = true;
            this.BotMultiplerbutton.Click += new System.EventHandler(this.BotMultiplerbutton_Click);
            // 
            // leaveshopbutton
            // 
            this.leaveshopbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leaveshopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveshopbutton.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveshopbutton.ForeColor = System.Drawing.Color.White;
            this.leaveshopbutton.Location = new System.Drawing.Point(664, 12);
            this.leaveshopbutton.Name = "leaveshopbutton";
            this.leaveshopbutton.Size = new System.Drawing.Size(124, 57);
            this.leaveshopbutton.TabIndex = 3;
            this.leaveshopbutton.TabStop = false;
            this.leaveshopbutton.Text = "Leave Shop";
            this.leaveshopbutton.UseVisualStyleBackColor = false;
            this.leaveshopbutton.Click += new System.EventHandler(this.leaveshopbutton_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaveshopbutton);
            this.Controls.Add(this.BotMultiplerbutton);
            this.Controls.Add(this.Botsbutton);
            this.Controls.Add(this.Multiplerbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shop";
            this.Text = "CookieClicker - Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Multiplerbutton;
        private System.Windows.Forms.Timer updatelvltimer;
        private System.Windows.Forms.Button Botsbutton;
        private System.Windows.Forms.Button BotMultiplerbutton;
        private System.Windows.Forms.Button leaveshopbutton;
    }
}