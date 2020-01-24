namespace KlinikApp
{
    partial class Main
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.araBtn = new System.Windows.Forms.Button();
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.dataDate = new System.Windows.Forms.DateTimePicker();
            this.dataCombo = new System.Windows.Forms.ComboBox();
            this.randevuData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.araTxt = new System.Windows.Forms.ComboBox();
            this.randevuEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.randevuEkleToolStripMenuItem1});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(800, 24);
            this.topMenu.TabIndex = 6;
            this.topMenu.Text = "menuStrip1";
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaDetayToolStripMenuItem,
            this.randevuDetayToolStripMenuItem});
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.detayToolStripMenuItem.Text = "Detay";
            // 
            // hastaDetayToolStripMenuItem
            // 
            this.hastaDetayToolStripMenuItem.Name = "hastaDetayToolStripMenuItem";
            this.hastaDetayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hastaDetayToolStripMenuItem.Text = "Hasta Detay";
            // 
            // randevuDetayToolStripMenuItem
            // 
            this.randevuDetayToolStripMenuItem.Name = "randevuDetayToolStripMenuItem";
            this.randevuDetayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevuDetayToolStripMenuItem.Text = "Randevu Detay";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.ekleToolStripMenuItem.Text = "Hasta Ekle";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.araTxt);
            this.tabPage1.Controls.Add(this.araBtn);
            this.tabPage1.Controls.Add(this.dataTxt);
            this.tabPage1.Controls.Add(this.dataDate);
            this.tabPage1.Controls.Add(this.dataCombo);
            this.tabPage1.Controls.Add(this.randevuData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Randevular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // araBtn
            // 
            this.araBtn.Location = new System.Drawing.Point(614, 9);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(170, 21);
            this.araBtn.TabIndex = 5;
            this.araBtn.Text = "Ara";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Visible = false;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(307, 8);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(170, 20);
            this.dataTxt.TabIndex = 4;
            this.dataTxt.Visible = false;
            // 
            // dataDate
            // 
            this.dataDate.Location = new System.Drawing.Point(307, 8);
            this.dataDate.Name = "dataDate";
            this.dataDate.Size = new System.Drawing.Size(170, 20);
            this.dataDate.TabIndex = 3;
            this.dataDate.Visible = false;
            // 
            // dataCombo
            // 
            this.dataCombo.FormattingEnabled = true;
            this.dataCombo.Location = new System.Drawing.Point(307, 8);
            this.dataCombo.Name = "dataCombo";
            this.dataCombo.Size = new System.Drawing.Size(170, 21);
            this.dataCombo.TabIndex = 2;
            this.dataCombo.Visible = false;
            // 
            // randevuData
            // 
            this.randevuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuData.Location = new System.Drawing.Point(6, 35);
            this.randevuData.Name = "randevuData";
            this.randevuData.Size = new System.Drawing.Size(778, 357);
            this.randevuData.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hastalar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // araTxt
            // 
            this.araTxt.FormattingEnabled = true;
            this.araTxt.Items.AddRange(new object[] {
            "Tümü",
            "Hastanın Adı",
            "Personel Adı",
            "Randevu Durumu",
            "Randevu Tarihi",
            "Randevu Hizmeti"});
            this.araTxt.Location = new System.Drawing.Point(8, 8);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(170, 21);
            this.araTxt.TabIndex = 6;
            this.araTxt.SelectedIndexChanged += new System.EventHandler(this.araTxt_SelectedIndexChanged);
            // 
            // randevuEkleToolStripMenuItem1
            // 
            this.randevuEkleToolStripMenuItem1.Name = "randevuEkleToolStripMenuItem1";
            this.randevuEkleToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.randevuEkleToolStripMenuItem1.Text = "Randevu Ekle";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü",
            "Hastanın Adı",
            "Personel Adı",
            "Randevu Durumu",
            "Randevu Tarihi",
            "Randevu Hizmeti"});
            this.comboBox1.Location = new System.Drawing.Point(3, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 357);
            this.dataGridView1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevuData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaDetayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuDetayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox dataTxt;
        private System.Windows.Forms.DateTimePicker dataDate;
        private System.Windows.Forms.ComboBox dataCombo;
        private System.Windows.Forms.DataGridView randevuData;
        private System.Windows.Forms.ComboBox araTxt;
        private System.Windows.Forms.ToolStripMenuItem randevuEkleToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}