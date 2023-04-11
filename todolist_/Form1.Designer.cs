
namespace todolist_
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHakkında = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbYapılacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.lblYapılacaklarListesi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpYeniGörev = new System.Windows.Forms.GroupBox();
            this.txtYeniGörev = new System.Windows.Forms.TextBox();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.lblTamamlananlarListesi = new System.Windows.Forms.Label();
            this.btnYeniGörev = new System.Windows.Forms.ToolStripButton();
            this.btnDüzelt = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapıştır = new System.Windows.Forms.ToolStripButton();
            this.btnYardım = new System.Windows.Forms.ToolStripButton();
            this.mnuÇıkış = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDüzelt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUglHakkında = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYardım = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cnmuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuDüzelt = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpYeniGörev.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniGörev,
            this.btnDüzelt,
            this.btnSil,
            this.toolStripSeparator2,
            this.btnKes,
            this.btnKopyala,
            this.btnYapıştır,
            this.toolStripSeparator1,
            this.btnYardım});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1125, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuTodo,
            this.mnuHakkında});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuÇıkış});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(64, 24);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuTodo
            // 
            this.mnuTodo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeni,
            this.mnuDüzelt,
            this.mnuSil});
            this.mnuTodo.Name = "mnuTodo";
            this.mnuTodo.Size = new System.Drawing.Size(57, 24);
            this.mnuTodo.Text = "Todo";
            // 
            // mnuHakkında
            // 
            this.mnuHakkında.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUglHakkında,
            this.mnuYardım});
            this.mnuHakkında.Name = "mnuHakkında";
            this.mnuHakkında.Size = new System.Drawing.Size(90, 24);
            this.mnuHakkında.Text = "Hakkımda";
            this.mnuHakkında.Click += new System.EventHandler(this.mnuHakkında_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbYapılacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblYapılacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grpYeniGörev);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTamamlananlarListesi);
            this.splitContainer1.Panel2.Controls.Add(this.lblTamamlananlarListesi);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainer1.Size = new System.Drawing.Size(1125, 338);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 2;
            // 
            // clbYapılacaklarListesi
            // 
            this.clbYapılacaklarListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.clbYapılacaklarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbYapılacaklarListesi.FormattingEnabled = true;
            this.clbYapılacaklarListesi.Location = new System.Drawing.Point(5, 160);
            this.clbYapılacaklarListesi.Name = "clbYapılacaklarListesi";
            this.clbYapılacaklarListesi.Size = new System.Drawing.Size(448, 172);
            this.clbYapılacaklarListesi.TabIndex = 3;
            this.clbYapılacaklarListesi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbYapılacaklarListesi_ItemCheck);
            this.clbYapılacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.clbYapılacaklarListesi_SelectedIndexChanged);
            this.clbYapılacaklarListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbYapılacaklarListesi_MouseUp);
            // 
            // lblYapılacaklarListesi
            // 
            this.lblYapılacaklarListesi.AutoSize = true;
            this.lblYapılacaklarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapılacaklarListesi.Location = new System.Drawing.Point(5, 130);
            this.lblYapılacaklarListesi.Name = "lblYapılacaklarListesi";
            this.lblYapılacaklarListesi.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblYapılacaklarListesi.Size = new System.Drawing.Size(136, 30);
            this.lblYapılacaklarListesi.TabIndex = 2;
            this.lblYapılacaklarListesi.Text = "Yapılacaklar Listesi";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 15);
            this.panel1.TabIndex = 1;
            // 
            // grpYeniGörev
            // 
            this.grpYeniGörev.Controls.Add(this.txtYeniGörev);
            this.grpYeniGörev.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYeniGörev.Location = new System.Drawing.Point(5, 6);
            this.grpYeniGörev.Name = "grpYeniGörev";
            this.grpYeniGörev.Padding = new System.Windows.Forms.Padding(12);
            this.grpYeniGörev.Size = new System.Drawing.Size(448, 109);
            this.grpYeniGörev.TabIndex = 0;
            this.grpYeniGörev.TabStop = false;
            this.grpYeniGörev.Text = "Yeni Görev";
            // 
            // txtYeniGörev
            // 
            this.txtYeniGörev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYeniGörev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniGörev.Location = new System.Drawing.Point(12, 31);
            this.txtYeniGörev.MaxLength = 120;
            this.txtYeniGörev.Multiline = true;
            this.txtYeniGörev.Name = "txtYeniGörev";
            this.txtYeniGörev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtYeniGörev.Size = new System.Drawing.Size(424, 66);
            this.txtYeniGörev.TabIndex = 0;
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.ItemHeight = 18;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(5, 36);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(653, 296);
            this.lstTamamlananlarListesi.TabIndex = 4;
            // 
            // lblTamamlananlarListesi
            // 
            this.lblTamamlananlarListesi.AutoSize = true;
            this.lblTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTamamlananlarListesi.Location = new System.Drawing.Point(5, 6);
            this.lblTamamlananlarListesi.Name = "lblTamamlananlarListesi";
            this.lblTamamlananlarListesi.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblTamamlananlarListesi.Size = new System.Drawing.Size(162, 30);
            this.lblTamamlananlarListesi.TabIndex = 3;
            this.lblTamamlananlarListesi.Text = "Tamamlananlar Listesi";
            // 
            // btnYeniGörev
            // 
            this.btnYeniGörev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeniGörev.Image = global::todolist_.Properties.Resources._5352774;
            this.btnYeniGörev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniGörev.Name = "btnYeniGörev";
            this.btnYeniGörev.Size = new System.Drawing.Size(29, 24);
            this.btnYeniGörev.Text = "Yeni Görev";
            this.btnYeniGörev.Click += new System.EventHandler(this.yeniToolStripButton_Click);
            // 
            // btnDüzelt
            // 
            this.btnDüzelt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDüzelt.Image = global::todolist_.Properties.Resources._4462747;
            this.btnDüzelt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDüzelt.Name = "btnDüzelt";
            this.btnDüzelt.Size = new System.Drawing.Size(29, 24);
            this.btnDüzelt.Text = "Düzelt";
            this.btnDüzelt.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = global::todolist_.Properties.Resources._1766898;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(29, 24);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(29, 24);
            this.btnKes.Text = "Kes";
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(29, 24);
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapıştır
            // 
            this.btnYapıştır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapıştır.Image = ((System.Drawing.Image)(resources.GetObject("btnYapıştır.Image")));
            this.btnYapıştır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapıştır.Name = "btnYapıştır";
            this.btnYapıştır.Size = new System.Drawing.Size(29, 24);
            this.btnYapıştır.Text = "Yapıştır";
            this.btnYapıştır.Click += new System.EventHandler(this.btnYapıştır_Click);
            // 
            // btnYardım
            // 
            this.btnYardım.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYardım.Image = ((System.Drawing.Image)(resources.GetObject("btnYardım.Image")));
            this.btnYardım.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYardım.Name = "btnYardım";
            this.btnYardım.Size = new System.Drawing.Size(29, 24);
            this.btnYardım.Text = "Yardım";
            // 
            // mnuÇıkış
            // 
            this.mnuÇıkış.Image = global::todolist_.Properties.Resources._1766898;
            this.mnuÇıkış.Name = "mnuÇıkış";
            this.mnuÇıkış.Size = new System.Drawing.Size(122, 26);
            this.mnuÇıkış.Text = "Çıkış";
            this.mnuÇıkış.Click += new System.EventHandler(this.mnuÇıkış_Click);
            // 
            // mnuYeni
            // 
            this.mnuYeni.Image = global::todolist_.Properties.Resources._5352774;
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.ShortcutKeyDisplayString = "";
            this.mnuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuYeni.Size = new System.Drawing.Size(185, 26);
            this.mnuYeni.Text = "Yeni ";
            this.mnuYeni.Click += new System.EventHandler(this.yeniToolStripButton_Click);
            // 
            // mnuDüzelt
            // 
            this.mnuDüzelt.Image = global::todolist_.Properties.Resources._4462747;
            this.mnuDüzelt.Name = "mnuDüzelt";
            this.mnuDüzelt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuDüzelt.Size = new System.Drawing.Size(185, 26);
            this.mnuDüzelt.Text = "Düzelt";
            this.mnuDüzelt.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // mnuSil
            // 
            this.mnuSil.Image = global::todolist_.Properties.Resources._1766898;
            this.mnuSil.Name = "mnuSil";
            this.mnuSil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSil.Size = new System.Drawing.Size(185, 26);
            this.mnuSil.Text = "Sil";
            this.mnuSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // mnuUglHakkında
            // 
            this.mnuUglHakkında.Image = global::todolist_.Properties.Resources._1037551;
            this.mnuUglHakkında.Name = "mnuUglHakkında";
            this.mnuUglHakkında.Size = new System.Drawing.Size(225, 26);
            this.mnuUglHakkında.Text = "Uygulama Hakkında";
            this.mnuUglHakkında.Click += new System.EventHandler(this.mnuUglHakkında_Click);
            // 
            // mnuYardım
            // 
            this.mnuYardım.Image = global::todolist_.Properties.Resources._4136079;
            this.mnuYardım.Name = "mnuYardım";
            this.mnuYardım.Size = new System.Drawing.Size(225, 26);
            this.mnuYardım.Text = "Yardım";
            this.mnuYardım.Click += new System.EventHandler(this.mnuYardım_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnmuYeni,
            this.cmnuDüzelt,
            this.cmnuSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 82);
            // 
            // cnmuYeni
            // 
            this.cnmuYeni.Image = global::todolist_.Properties.Resources._5352774;
            this.cnmuYeni.Name = "cnmuYeni";
            this.cnmuYeni.Size = new System.Drawing.Size(214, 26);
            this.cnmuYeni.Text = "Yeni";
            this.cnmuYeni.Click += new System.EventHandler(this.yeniToolStripButton_Click);
            // 
            // cmnuDüzelt
            // 
            this.cmnuDüzelt.Image = global::todolist_.Properties.Resources._4462747;
            this.cmnuDüzelt.Name = "cmnuDüzelt";
            this.cmnuDüzelt.Size = new System.Drawing.Size(214, 26);
            this.cmnuDüzelt.Text = "Düzelt";
            this.cmnuDüzelt.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // cmnuSil
            // 
            this.cmnuSil.Image = global::todolist_.Properties.Resources._1766898;
            this.cmnuSil.Name = "cmnuSil";
            this.cmnuSil.Size = new System.Drawing.Size(214, 26);
            this.cmnuSil.Text = "Sil";
            this.cmnuSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 393);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Todolist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpYeniGörev.ResumeLayout(false);
            this.grpYeniGörev.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeniGörev;
        private System.Windows.Forms.ToolStripButton btnDüzelt;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapıştır;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnYardım;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuÇıkış;
        private System.Windows.Forms.ToolStripMenuItem mnuTodo;
        private System.Windows.Forms.ToolStripMenuItem mnuYeni;
        private System.Windows.Forms.ToolStripMenuItem mnuDüzelt;
        private System.Windows.Forms.ToolStripMenuItem mnuSil;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkında;
        private System.Windows.Forms.ToolStripMenuItem mnuUglHakkında;
        private System.Windows.Forms.ToolStripMenuItem mnuYardım;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbYapılacaklarListesi;
        private System.Windows.Forms.Label lblYapılacaklarListesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpYeniGörev;
        private System.Windows.Forms.TextBox txtYeniGörev;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label lblTamamlananlarListesi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cnmuYeni;
        private System.Windows.Forms.ToolStripMenuItem cmnuDüzelt;
        private System.Windows.Forms.ToolStripMenuItem cmnuSil;
    }
}

