namespace XOX_Oyunu
{
    partial class Player1
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel6 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel12 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel13 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel14 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel15 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel16 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel17 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel18 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel19 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel20 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel21 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new DevExpress.XtraEditors.TrackBarControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A1.Location = new System.Drawing.Point(39, 36);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A2.Location = new System.Drawing.Point(120, 36);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A3.Location = new System.Drawing.Point(201, 36);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B1.Location = new System.Drawing.Point(39, 117);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B2.Location = new System.Drawing.Point(120, 117);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B3.Location = new System.Drawing.Point(201, 117);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C1.Location = new System.Drawing.Point(39, 198);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C2.Location = new System.Drawing.Point(120, 198);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C3.Location = new System.Drawing.Point(201, 198);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.EditValue = 10;
            this.time.Enabled = false;
            this.time.Location = new System.Drawing.Point(47, 279);
            this.time.Name = "time";
            this.time.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.time.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "0";
            trackBarLabel2.Label = "1";
            trackBarLabel2.Value = 1;
            trackBarLabel3.Label = "2";
            trackBarLabel3.Value = 2;
            trackBarLabel4.Label = "3";
            trackBarLabel4.Value = 3;
            trackBarLabel5.Label = "4";
            trackBarLabel5.Value = 4;
            trackBarLabel6.Label = "5";
            trackBarLabel6.Value = 5;
            trackBarLabel7.Label = "6";
            trackBarLabel7.Value = 6;
            trackBarLabel8.Label = "7";
            trackBarLabel8.Value = 7;
            trackBarLabel9.Label = "8";
            trackBarLabel9.Value = 8;
            trackBarLabel10.Label = "9";
            trackBarLabel10.Value = 9;
            trackBarLabel11.Label = "10";
            trackBarLabel11.Value = 10;
            trackBarLabel12.Label = "9";
            trackBarLabel12.Value = 11;
            trackBarLabel13.Label = "8";
            trackBarLabel13.Value = 12;
            trackBarLabel14.Label = "7";
            trackBarLabel14.Value = 13;
            trackBarLabel15.Label = "6";
            trackBarLabel15.Value = 14;
            trackBarLabel16.Label = "5";
            trackBarLabel16.Value = 15;
            trackBarLabel17.Label = "4";
            trackBarLabel17.Value = 16;
            trackBarLabel18.Label = "3";
            trackBarLabel18.Value = 17;
            trackBarLabel19.Label = "2";
            trackBarLabel19.Value = 18;
            trackBarLabel20.Label = "1";
            trackBarLabel20.Value = 19;
            trackBarLabel21.Label = "0";
            trackBarLabel21.Value = 20;
            this.time.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5,
            trackBarLabel6,
            trackBarLabel7,
            trackBarLabel8,
            trackBarLabel9,
            trackBarLabel10,
            trackBarLabel11,
            trackBarLabel12,
            trackBarLabel13,
            trackBarLabel14,
            trackBarLabel15,
            trackBarLabel16,
            trackBarLabel17,
            trackBarLabel18,
            trackBarLabel19,
            trackBarLabel20,
            trackBarLabel21});
            this.time.Properties.Maximum = 20;
            this.time.Properties.ShowLabels = true;
            this.time.Size = new System.Drawing.Size(225, 72);
            this.time.TabIndex = 10;
            this.time.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(288, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "O";
            // 
            // Player1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Player1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.TrackBarControl time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

