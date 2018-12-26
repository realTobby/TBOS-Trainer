namespace TBOS_Trainer
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_GodMode = new System.Windows.Forms.CheckBox();
            this.chb_energy = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_itemid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbx_maxEnergy = new System.Windows.Forms.TextBox();
            this.chb_coins = new System.Windows.Forms.CheckBox();
            this.chb_bombs = new System.Windows.Forms.CheckBox();
            this.chb_keys = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lbl_coord = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STATUS:";
            // 
            // chb_GodMode
            // 
            this.chb_GodMode.AutoSize = true;
            this.chb_GodMode.Enabled = false;
            this.chb_GodMode.Location = new System.Drawing.Point(12, 80);
            this.chb_GodMode.Name = "chb_GodMode";
            this.chb_GodMode.Size = new System.Drawing.Size(85, 17);
            this.chb_GodMode.TabIndex = 3;
            this.chb_GodMode.Text = "GOD MODE";
            this.chb_GodMode.UseVisualStyleBackColor = true;
            // 
            // chb_energy
            // 
            this.chb_energy.AutoSize = true;
            this.chb_energy.Enabled = false;
            this.chb_energy.Location = new System.Drawing.Point(12, 103);
            this.chb_energy.Name = "chb_energy";
            this.chb_energy.Size = new System.Drawing.Size(133, 17);
            this.chb_energy.TabIndex = 4;
            this.chb_energy.Text = "UNLIMITED ENERGY";
            this.chb_energy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ItemID";
            // 
            // tbx_itemid
            // 
            this.tbx_itemid.Location = new System.Drawing.Point(56, 130);
            this.tbx_itemid.Name = "tbx_itemid";
            this.tbx_itemid.Size = new System.Drawing.Size(89, 20);
            this.tbx_itemid.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbx_maxEnergy
            // 
            this.tbx_maxEnergy.Location = new System.Drawing.Point(152, 103);
            this.tbx_maxEnergy.Name = "tbx_maxEnergy";
            this.tbx_maxEnergy.Size = new System.Drawing.Size(100, 20);
            this.tbx_maxEnergy.TabIndex = 10;
            // 
            // chb_coins
            // 
            this.chb_coins.AutoSize = true;
            this.chb_coins.Location = new System.Drawing.Point(12, 156);
            this.chb_coins.Name = "chb_coins";
            this.chb_coins.Size = new System.Drawing.Size(94, 17);
            this.chb_coins.TabIndex = 11;
            this.chb_coins.Text = "Cap Coins x99";
            this.chb_coins.UseVisualStyleBackColor = true;
            // 
            // chb_bombs
            // 
            this.chb_bombs.AutoSize = true;
            this.chb_bombs.Location = new System.Drawing.Point(12, 179);
            this.chb_bombs.Name = "chb_bombs";
            this.chb_bombs.Size = new System.Drawing.Size(100, 17);
            this.chb_bombs.TabIndex = 12;
            this.chb_bombs.Text = "Cap Bombs x99";
            this.chb_bombs.UseVisualStyleBackColor = true;
            // 
            // chb_keys
            // 
            this.chb_keys.AutoSize = true;
            this.chb_keys.Location = new System.Drawing.Point(12, 202);
            this.chb_keys.Name = "chb_keys";
            this.chb_keys.Size = new System.Drawing.Size(91, 17);
            this.chb_keys.TabIndex = 13;
            this.chb_keys.Text = "Cap Keys x99";
            this.chb_keys.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // lbl_coord
            // 
            this.lbl_coord.AutoSize = true;
            this.lbl_coord.Location = new System.Drawing.Point(214, 239);
            this.lbl_coord.Name = "lbl_coord";
            this.lbl_coord.Size = new System.Drawing.Size(39, 13);
            this.lbl_coord.TabIndex = 14;
            this.lbl_coord.Text = "coords";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Toggle Teleport";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 290);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_coord);
            this.Controls.Add(this.chb_keys);
            this.Controls.Add(this.chb_bombs);
            this.Controls.Add(this.chb_coins);
            this.Controls.Add(this.tbx_maxEnergy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbx_itemid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb_energy);
            this.Controls.Add(this.chb_GodMode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_GodMode;
        private System.Windows.Forms.CheckBox chb_energy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_itemid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbx_maxEnergy;
        private System.Windows.Forms.CheckBox chb_coins;
        private System.Windows.Forms.CheckBox chb_bombs;
        private System.Windows.Forms.CheckBox chb_keys;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lbl_coord;
        private System.Windows.Forms.Button button3;
    }
}

