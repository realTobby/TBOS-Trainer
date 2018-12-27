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
            this.chb_randTele = new System.Windows.Forms.CheckBox();
            this.mainTrainer = new System.Windows.Forms.TabControl();
            this.tab_general = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_stats = new System.Windows.Forms.TabPage();
            this.nmb_firerate = new System.Windows.Forms.NumericUpDown();
            this.btn_writeStats = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_hacks = new System.Windows.Forms.TabPage();
            this.nmb_movementspeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmb_rangemultiplier = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmb_range = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmb_luck = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmb_damage = new System.Windows.Forms.NumericUpDown();
            this.tear_color_border = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tear_color = new System.Windows.Forms.ColorDialog();
            this.mainTrainer.SuspendLayout();
            this.tab_general.SuspendLayout();
            this.tab_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_firerate)).BeginInit();
            this.tab_hacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_movementspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_rangemultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_luck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_damage)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STATUS:";
            // 
            // chb_GodMode
            // 
            this.chb_GodMode.AutoSize = true;
            this.chb_GodMode.Location = new System.Drawing.Point(9, 15);
            this.chb_GodMode.Name = "chb_GodMode";
            this.chb_GodMode.Size = new System.Drawing.Size(85, 17);
            this.chb_GodMode.TabIndex = 3;
            this.chb_GodMode.Text = "GOD MODE";
            this.chb_GodMode.UseVisualStyleBackColor = true;
            // 
            // chb_energy
            // 
            this.chb_energy.AutoSize = true;
            this.chb_energy.Location = new System.Drawing.Point(9, 38);
            this.chb_energy.Name = "chb_energy";
            this.chb_energy.Size = new System.Drawing.Size(133, 17);
            this.chb_energy.TabIndex = 4;
            this.chb_energy.Text = "UNLIMITED ENERGY";
            this.chb_energy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ItemID";
            // 
            // tbx_itemid
            // 
            this.tbx_itemid.Location = new System.Drawing.Point(50, 59);
            this.tbx_itemid.Name = "tbx_itemid";
            this.tbx_itemid.Size = new System.Drawing.Size(89, 20);
            this.tbx_itemid.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbx_maxEnergy
            // 
            this.tbx_maxEnergy.Location = new System.Drawing.Point(148, 36);
            this.tbx_maxEnergy.Name = "tbx_maxEnergy";
            this.tbx_maxEnergy.Size = new System.Drawing.Size(84, 20);
            this.tbx_maxEnergy.TabIndex = 10;
            // 
            // chb_coins
            // 
            this.chb_coins.AutoSize = true;
            this.chb_coins.Location = new System.Drawing.Point(9, 85);
            this.chb_coins.Name = "chb_coins";
            this.chb_coins.Size = new System.Drawing.Size(94, 17);
            this.chb_coins.TabIndex = 11;
            this.chb_coins.Text = "Cap Coins x99";
            this.chb_coins.UseVisualStyleBackColor = true;
            // 
            // chb_bombs
            // 
            this.chb_bombs.AutoSize = true;
            this.chb_bombs.Location = new System.Drawing.Point(8, 108);
            this.chb_bombs.Name = "chb_bombs";
            this.chb_bombs.Size = new System.Drawing.Size(100, 17);
            this.chb_bombs.TabIndex = 12;
            this.chb_bombs.Text = "Cap Bombs x99";
            this.chb_bombs.UseVisualStyleBackColor = true;
            // 
            // chb_keys
            // 
            this.chb_keys.AutoSize = true;
            this.chb_keys.Location = new System.Drawing.Point(8, 131);
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
            this.lbl_coord.Location = new System.Drawing.Point(123, 155);
            this.lbl_coord.Name = "lbl_coord";
            this.lbl_coord.Size = new System.Drawing.Size(39, 13);
            this.lbl_coord.TabIndex = 14;
            this.lbl_coord.Text = "coords";
            // 
            // chb_randTele
            // 
            this.chb_randTele.AutoSize = true;
            this.chb_randTele.Location = new System.Drawing.Point(9, 154);
            this.chb_randTele.Name = "chb_randTele";
            this.chb_randTele.Size = new System.Drawing.Size(108, 17);
            this.chb_randTele.TabIndex = 16;
            this.chb_randTele.Text = "Random Teleport";
            this.chb_randTele.UseVisualStyleBackColor = true;
            // 
            // mainTrainer
            // 
            this.mainTrainer.Controls.Add(this.tab_general);
            this.mainTrainer.Controls.Add(this.tab_stats);
            this.mainTrainer.Controls.Add(this.tab_hacks);
            this.mainTrainer.Location = new System.Drawing.Point(12, 12);
            this.mainTrainer.Name = "mainTrainer";
            this.mainTrainer.SelectedIndex = 0;
            this.mainTrainer.Size = new System.Drawing.Size(406, 270);
            this.mainTrainer.TabIndex = 19;
            // 
            // tab_general
            // 
            this.tab_general.Controls.Add(this.button1);
            this.tab_general.Controls.Add(this.label1);
            this.tab_general.Controls.Add(this.label2);
            this.tab_general.Location = new System.Drawing.Point(4, 22);
            this.tab_general.Name = "tab_general";
            this.tab_general.Padding = new System.Windows.Forms.Padding(3);
            this.tab_general.Size = new System.Drawing.Size(398, 244);
            this.tab_general.TabIndex = 0;
            this.tab_general.Text = "GENERAL";
            this.tab_general.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab_stats
            // 
            this.tab_stats.Controls.Add(this.button4);
            this.tab_stats.Controls.Add(this.button3);
            this.tab_stats.Controls.Add(this.label9);
            this.tab_stats.Controls.Add(this.nmb_damage);
            this.tab_stats.Controls.Add(this.label8);
            this.tab_stats.Controls.Add(this.nmb_luck);
            this.tab_stats.Controls.Add(this.label7);
            this.tab_stats.Controls.Add(this.nmb_range);
            this.tab_stats.Controls.Add(this.label6);
            this.tab_stats.Controls.Add(this.nmb_rangemultiplier);
            this.tab_stats.Controls.Add(this.label5);
            this.tab_stats.Controls.Add(this.nmb_movementspeed);
            this.tab_stats.Controls.Add(this.nmb_firerate);
            this.tab_stats.Controls.Add(this.btn_writeStats);
            this.tab_stats.Controls.Add(this.btn_scan);
            this.tab_stats.Controls.Add(this.label4);
            this.tab_stats.Location = new System.Drawing.Point(4, 22);
            this.tab_stats.Name = "tab_stats";
            this.tab_stats.Padding = new System.Windows.Forms.Padding(3);
            this.tab_stats.Size = new System.Drawing.Size(398, 244);
            this.tab_stats.TabIndex = 1;
            this.tab_stats.Text = "STATS";
            this.tab_stats.UseVisualStyleBackColor = true;
            // 
            // nmb_firerate
            // 
            this.nmb_firerate.Location = new System.Drawing.Point(108, 35);
            this.nmb_firerate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmb_firerate.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nmb_firerate.Name = "nmb_firerate";
            this.nmb_firerate.Size = new System.Drawing.Size(120, 20);
            this.nmb_firerate.TabIndex = 22;
            // 
            // btn_writeStats
            // 
            this.btn_writeStats.Location = new System.Drawing.Point(156, 6);
            this.btn_writeStats.Name = "btn_writeStats";
            this.btn_writeStats.Size = new System.Drawing.Size(139, 23);
            this.btn_writeStats.TabIndex = 21;
            this.btn_writeStats.Text = "Write new Stats";
            this.btn_writeStats.UseVisualStyleBackColor = true;
            this.btn_writeStats.Click += new System.EventHandler(this.btn_writeStats_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(6, 6);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(144, 23);
            this.btn_scan.TabIndex = 20;
            this.btn_scan.Text = "Get current Player Stats";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fire Rate:";
            // 
            // tab_hacks
            // 
            this.tab_hacks.Controls.Add(this.chb_GodMode);
            this.tab_hacks.Controls.Add(this.lbl_coord);
            this.tab_hacks.Controls.Add(this.chb_randTele);
            this.tab_hacks.Controls.Add(this.chb_energy);
            this.tab_hacks.Controls.Add(this.tbx_maxEnergy);
            this.tab_hacks.Controls.Add(this.chb_keys);
            this.tab_hacks.Controls.Add(this.label3);
            this.tab_hacks.Controls.Add(this.chb_bombs);
            this.tab_hacks.Controls.Add(this.tbx_itemid);
            this.tab_hacks.Controls.Add(this.chb_coins);
            this.tab_hacks.Controls.Add(this.button2);
            this.tab_hacks.Location = new System.Drawing.Point(4, 22);
            this.tab_hacks.Name = "tab_hacks";
            this.tab_hacks.Size = new System.Drawing.Size(398, 244);
            this.tab_hacks.TabIndex = 2;
            this.tab_hacks.Text = "HACKS";
            this.tab_hacks.UseVisualStyleBackColor = true;
            // 
            // nmb_movementspeed
            // 
            this.nmb_movementspeed.DecimalPlaces = 2;
            this.nmb_movementspeed.Location = new System.Drawing.Point(108, 62);
            this.nmb_movementspeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmb_movementspeed.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nmb_movementspeed.Name = "nmb_movementspeed";
            this.nmb_movementspeed.Size = new System.Drawing.Size(120, 20);
            this.nmb_movementspeed.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Movement Speed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Range Multiplier:";
            // 
            // nmb_rangemultiplier
            // 
            this.nmb_rangemultiplier.DecimalPlaces = 2;
            this.nmb_rangemultiplier.Location = new System.Drawing.Point(108, 88);
            this.nmb_rangemultiplier.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmb_rangemultiplier.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nmb_rangemultiplier.Name = "nmb_rangemultiplier";
            this.nmb_rangemultiplier.Size = new System.Drawing.Size(120, 20);
            this.nmb_rangemultiplier.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Range:";
            // 
            // nmb_range
            // 
            this.nmb_range.DecimalPlaces = 2;
            this.nmb_range.Location = new System.Drawing.Point(108, 114);
            this.nmb_range.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmb_range.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nmb_range.Name = "nmb_range";
            this.nmb_range.Size = new System.Drawing.Size(120, 20);
            this.nmb_range.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Luck:";
            // 
            // nmb_luck
            // 
            this.nmb_luck.DecimalPlaces = 2;
            this.nmb_luck.Location = new System.Drawing.Point(108, 140);
            this.nmb_luck.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmb_luck.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nmb_luck.Name = "nmb_luck";
            this.nmb_luck.Size = new System.Drawing.Size(120, 20);
            this.nmb_luck.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Damage:";
            // 
            // nmb_damage
            // 
            this.nmb_damage.DecimalPlaces = 2;
            this.nmb_damage.Location = new System.Drawing.Point(108, 166);
            this.nmb_damage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmb_damage.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nmb_damage.Name = "nmb_damage";
            this.nmb_damage.Size = new System.Drawing.Size(120, 20);
            this.nmb_damage.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Choose Tear Border Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Choose Tear Color";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 291);
            this.Controls.Add(this.mainTrainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTrainer.ResumeLayout(false);
            this.tab_general.ResumeLayout(false);
            this.tab_general.PerformLayout();
            this.tab_stats.ResumeLayout(false);
            this.tab_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_firerate)).EndInit();
            this.tab_hacks.ResumeLayout(false);
            this.tab_hacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_movementspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_rangemultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_luck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb_damage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_GodMode;
        private System.Windows.Forms.CheckBox chb_energy;
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
        private System.Windows.Forms.CheckBox chb_randTele;
        private System.Windows.Forms.TabControl mainTrainer;
        private System.Windows.Forms.TabPage tab_general;
        private System.Windows.Forms.TabPage tab_stats;
        private System.Windows.Forms.TabPage tab_hacks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_writeStats;
        private System.Windows.Forms.NumericUpDown nmb_firerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmb_movementspeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmb_range;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmb_rangemultiplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmb_luck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmb_damage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog tear_color_border;
        private System.Windows.Forms.ColorDialog tear_color;
    }
}

