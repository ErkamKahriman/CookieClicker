namespace CookieClicker
{
    partial class CookierClickerMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookierClickerMain));
            this.cookiebutton = new System.Windows.Forms.Button();
            this.cookiecount = new System.Windows.Forms.Label();
            this.Shopbutton = new System.Windows.Forms.Button();
            this.updatecoinstimer = new System.Windows.Forms.Timer(this.components);
            this.botclicktask = new System.Windows.Forms.Timer(this.components);
            this.cpslabel = new System.Windows.Forms.Label();
            this.authorlabel = new System.Windows.Forms.LinkLabel();
            this.blockenterbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookiebutton
            // 
            this.cookiebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cookiebutton.BackgroundImage")));
            this.cookiebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cookiebutton.CausesValidation = false;
            this.cookiebutton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cookiebutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cookiebutton.FlatAppearance.BorderSize = 10;
            this.cookiebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cookiebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cookiebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cookiebutton.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cookiebutton.Location = new System.Drawing.Point(350, 150);
            this.cookiebutton.Name = "cookiebutton";
            this.cookiebutton.Size = new System.Drawing.Size(130, 130);
            this.cookiebutton.TabIndex = 0;
            this.cookiebutton.TabStop = false;
            this.cookiebutton.UseMnemonic = false;
            this.cookiebutton.UseVisualStyleBackColor = false;
            this.cookiebutton.Click += new System.EventHandler(this.cookiebutton_Click);
            // 
            // cookiecount
            // 
            this.cookiecount.AutoSize = true;
            this.cookiecount.Location = new System.Drawing.Point(665, 30);
            this.cookiecount.Name = "cookiecount";
            this.cookiecount.Size = new System.Drawing.Size(57, 13);
            this.cookiecount.TabIndex = 1;
            this.cookiecount.Text = "Cookies: 0";
            // 
            // Shopbutton
            // 
            this.Shopbutton.BackColor = System.Drawing.Color.Snow;
            this.Shopbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Shopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shopbutton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shopbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Shopbutton.Location = new System.Drawing.Point(13, 13);
            this.Shopbutton.Name = "Shopbutton";
            this.Shopbutton.Size = new System.Drawing.Size(80, 40);
            this.Shopbutton.TabIndex = 2;
            this.Shopbutton.TabStop = false;
            this.Shopbutton.Text = "Shop";
            this.Shopbutton.UseVisualStyleBackColor = false;
            this.Shopbutton.Click += new System.EventHandler(this.Shopbutton_Click);
            // 
            // updatecoinstimer
            // 
            this.updatecoinstimer.Enabled = true;
            this.updatecoinstimer.Tick += new System.EventHandler(this.updatecoinstimer_Tick);
            // 
            // botclicktask
            // 
            this.botclicktask.Enabled = true;
            this.botclicktask.Interval = 1000;
            this.botclicktask.Tick += new System.EventHandler(this.botclicktask_Tick);
            // 
            // cpslabel
            // 
            this.cpslabel.AutoSize = true;
            this.cpslabel.Location = new System.Drawing.Point(593, 30);
            this.cpslabel.Name = "cpslabel";
            this.cpslabel.Size = new System.Drawing.Size(40, 13);
            this.cpslabel.TabIndex = 3;
            this.cpslabel.Text = "CPS: 0";
            // 
            // authorlabel
            // 
            this.authorlabel.AutoSize = true;
            this.authorlabel.Location = new System.Drawing.Point(622, 439);
            this.authorlabel.Name = "authorlabel";
            this.authorlabel.Size = new System.Drawing.Size(150, 13);
            this.authorlabel.TabIndex = 4;
            this.authorlabel.TabStop = true;
            this.authorlabel.Text = "Developed by ErkamKahriman";
            this.authorlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorlabel_LinkClicked);
            // 
            // blockenterbutton
            // 
            this.blockenterbutton.Location = new System.Drawing.Point(405, 428);
            this.blockenterbutton.Name = "blockenterbutton";
            this.blockenterbutton.Size = new System.Drawing.Size(0, 0);
            this.blockenterbutton.TabIndex = 5;
            this.blockenterbutton.UseVisualStyleBackColor = true;
            // 
            // CookierClickerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.blockenterbutton);
            this.Controls.Add(this.authorlabel);
            this.Controls.Add(this.cpslabel);
            this.Controls.Add(this.Shopbutton);
            this.Controls.Add(this.cookiecount);
            this.Controls.Add(this.cookiebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CookierClickerMain";
            this.Text = "CookieClicker";
            this.Load += new System.EventHandler(this.CookierClickerMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cookiebutton;
        private System.Windows.Forms.Label cookiecount;
        private System.Windows.Forms.Button Shopbutton;
        private System.Windows.Forms.Timer updatecoinstimer;
        private System.Windows.Forms.Timer botclicktask;
        private System.Windows.Forms.Label cpslabel;
        private System.Windows.Forms.LinkLabel authorlabel;
        private System.Windows.Forms.Button blockenterbutton;
    }
}

