namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHTDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHTDX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHT_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSBH = new System.Windows.Forms.DataGridView();
            this._tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tenbaihat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._yeuthich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._loibaihat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_yeuThich = new System.Windows.Forms.Button();
            this.btn_Phat = new System.Windows.Forms.Button();
            this.btn_bh_nn = new System.Windows.Forms.Button();
            this.btn_bh_yt = new System.Windows.Forms.Button();
            this.btn_tcbh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDangPhat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLoiBaiHat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mnuQLBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTV = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBH)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuQLBH});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHTDN,
            this.mnuHTDX,
            this.mnuHT_exit});
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(129, 36);
            this.mnuHT.Text = "Hệ thống";
            // 
            // mnuHTDN
            // 
            this.mnuHTDN.Name = "mnuHTDN";
            this.mnuHTDN.Size = new System.Drawing.Size(220, 36);
            this.mnuHTDN.Text = "Đăng nhập";
            this.mnuHTDN.Click += new System.EventHandler(this.mnuHTDN_Click);
            // 
            // mnuHTDX
            // 
            this.mnuHTDX.Name = "mnuHTDX";
            this.mnuHTDX.Size = new System.Drawing.Size(220, 36);
            this.mnuHTDX.Text = "Đăng xuất";
            this.mnuHTDX.Click += new System.EventHandler(this.mnuHTDX_Click);
            // 
            // mnuHT_exit
            // 
            this.mnuHT_exit.Name = "mnuHT_exit";
            this.mnuHT_exit.Size = new System.Drawing.Size(220, 36);
            this.mnuHT_exit.Text = "Thoát";
            this.mnuHT_exit.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDSBH);
            this.panel1.Controls.Add(this.btn_yeuThich);
            this.panel1.Controls.Add(this.btn_Phat);
            this.panel1.Controls.Add(this.btn_bh_nn);
            this.panel1.Controls.Add(this.btn_bh_yt);
            this.panel1.Controls.Add(this.btn_tcbh);
            this.panel1.Location = new System.Drawing.Point(20, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 620);
            this.panel1.TabIndex = 1;
            // 
            // dgvDSBH
            // 
            this.dgvDSBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._tt,
            this._id,
            this._tenbaihat,
            this._path,
            this._yeuthich,
            this._loibaihat});
            this.dgvDSBH.Location = new System.Drawing.Point(23, 87);
            this.dgvDSBH.Name = "dgvDSBH";
            this.dgvDSBH.RowHeadersWidth = 51;
            this.dgvDSBH.RowTemplate.Height = 24;
            this.dgvDSBH.Size = new System.Drawing.Size(349, 471);
            this.dgvDSBH.TabIndex = 6;
            this.dgvDSBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBH_CellClick);
            this.dgvDSBH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBH_CellDoubleClick);
            // 
            // _tt
            // 
            this._tt.DataPropertyName = "TT";
            this._tt.HeaderText = "TT";
            this._tt.MinimumWidth = 6;
            this._tt.Name = "_tt";
            this._tt.Width = 40;
            // 
            // _id
            // 
            this._id.DataPropertyName = "id";
            this._id.HeaderText = "id";
            this._id.MinimumWidth = 6;
            this._id.Name = "_id";
            this._id.Visible = false;
            this._id.Width = 125;
            // 
            // _tenbaihat
            // 
            this._tenbaihat.DataPropertyName = "tenbaihat";
            this._tenbaihat.HeaderText = "Tên Bài Hát";
            this._tenbaihat.MinimumWidth = 6;
            this._tenbaihat.Name = "_tenbaihat";
            this._tenbaihat.Width = 167;
            // 
            // _path
            // 
            this._path.DataPropertyName = "path";
            this._path.HeaderText = "Path";
            this._path.MinimumWidth = 6;
            this._path.Name = "_path";
            this._path.Visible = false;
            this._path.Width = 125;
            // 
            // _yeuthich
            // 
            this._yeuthich.DataPropertyName = "yeuthich";
            this._yeuthich.HeaderText = "yeuthich";
            this._yeuthich.MinimumWidth = 6;
            this._yeuthich.Name = "_yeuthich";
            this._yeuthich.Visible = false;
            this._yeuthich.Width = 125;
            // 
            // _loibaihat
            // 
            this._loibaihat.DataPropertyName = "loibaihat";
            this._loibaihat.HeaderText = "Lời bài hát";
            this._loibaihat.MinimumWidth = 6;
            this._loibaihat.Name = "_loibaihat";
            this._loibaihat.Visible = false;
            this._loibaihat.Width = 125;
            // 
            // btn_yeuThich
            // 
            this.btn_yeuThich.Location = new System.Drawing.Point(210, 572);
            this.btn_yeuThich.Name = "btn_yeuThich";
            this.btn_yeuThich.Size = new System.Drawing.Size(162, 31);
            this.btn_yeuThich.TabIndex = 5;
            this.btn_yeuThich.Text = "Yêu thích";
            this.btn_yeuThich.UseVisualStyleBackColor = true;
            this.btn_yeuThich.Click += new System.EventHandler(this.btn_yeuThich_Click);
            // 
            // btn_Phat
            // 
            this.btn_Phat.Location = new System.Drawing.Point(23, 572);
            this.btn_Phat.Name = "btn_Phat";
            this.btn_Phat.Size = new System.Drawing.Size(160, 31);
            this.btn_Phat.TabIndex = 4;
            this.btn_Phat.Text = "Phát";
            this.btn_Phat.UseVisualStyleBackColor = true;
            this.btn_Phat.Click += new System.EventHandler(this.btn_Phat_Click);
            // 
            // btn_bh_nn
            // 
            this.btn_bh_nn.Location = new System.Drawing.Point(210, 40);
            this.btn_bh_nn.Name = "btn_bh_nn";
            this.btn_bh_nn.Size = new System.Drawing.Size(162, 31);
            this.btn_bh_nn.TabIndex = 2;
            this.btn_bh_nn.Text = "bài hát nghe nhiều";
            this.btn_bh_nn.UseVisualStyleBackColor = true;
            this.btn_bh_nn.Click += new System.EventHandler(this.btn_bh_nn_Click);
            // 
            // btn_bh_yt
            // 
            this.btn_bh_yt.Location = new System.Drawing.Point(23, 40);
            this.btn_bh_yt.Name = "btn_bh_yt";
            this.btn_bh_yt.Size = new System.Drawing.Size(160, 31);
            this.btn_bh_yt.TabIndex = 1;
            this.btn_bh_yt.Text = "bài hát yêu thích";
            this.btn_bh_yt.UseVisualStyleBackColor = true;
            this.btn_bh_yt.Click += new System.EventHandler(this.btn_bh_yt_Click);
            // 
            // btn_tcbh
            // 
            this.btn_tcbh.Location = new System.Drawing.Point(23, 3);
            this.btn_tcbh.Name = "btn_tcbh";
            this.btn_tcbh.Size = new System.Drawing.Size(349, 31);
            this.btn_tcbh.TabIndex = 0;
            this.btn_tcbh.Text = "Tất cả bài hát";
            this.btn_tcbh.UseVisualStyleBackColor = true;
            this.btn_tcbh.Click += new System.EventHandler(this.btn_tcbh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDangPhat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Location = new System.Drawing.Point(413, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 619);
            this.panel2.TabIndex = 2;
            // 
            // txtDangPhat
            // 
            this.txtDangPhat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangPhat.Location = new System.Drawing.Point(129, 571);
            this.txtDangPhat.Name = "txtDangPhat";
            this.txtDangPhat.Size = new System.Drawing.Size(442, 27);
            this.txtDangPhat.TabIndex = 3;
            this.txtDangPhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đang phát";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Music";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtLoiBaiHat);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1006, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 620);
            this.panel3.TabIndex = 3;
            // 
            // txtLoiBaiHat
            // 
            this.txtLoiBaiHat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiBaiHat.Location = new System.Drawing.Point(15, 87);
            this.txtLoiBaiHat.Multiline = true;
            this.txtLoiBaiHat.Name = "txtLoiBaiHat";
            this.txtLoiBaiHat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoiBaiHat.Size = new System.Drawing.Size(375, 510);
            this.txtLoiBaiHat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lời bài hát";
            // 
            // mnuQLBH
            // 
            this.mnuQLBH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTCBH,
            this.mnuTV});
            this.mnuQLBH.Name = "mnuQLBH";
            this.mnuQLBH.Size = new System.Drawing.Size(191, 36);
            this.mnuQLBH.Text = "Quản lý bài hát";
            // 
            // mnuTCBH
            // 
            this.mnuTCBH.Name = "mnuTCBH";
            this.mnuTCBH.Size = new System.Drawing.Size(245, 36);
            this.mnuTCBH.Text = "Tất cả bài hát";
            this.mnuTCBH.Click += new System.EventHandler(this.mnuTCBH_Click);
            // 
            // mnuTV
            // 
            this.mnuTV.Name = "mnuTV";
            this.mnuTV.Size = new System.Drawing.Size(245, 36);
            this.mnuTV.Text = "Thư viện";
            this.mnuTV.Click += new System.EventHandler(this.mnuTV_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(8, 87);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(565, 366);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "My Music";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHT;
        private System.Windows.Forms.ToolStripMenuItem mnuHTDN;
        private System.Windows.Forms.ToolStripMenuItem mnuHTDX;
        private System.Windows.Forms.ToolStripMenuItem mnuHT_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDSBH;
        private System.Windows.Forms.Button btn_yeuThich;
        private System.Windows.Forms.Button btn_Phat;
        private System.Windows.Forms.Button btn_bh_nn;
        private System.Windows.Forms.Button btn_bh_yt;
        private System.Windows.Forms.Button btn_tcbh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox txtDangPhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoiBaiHat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tenbaihat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _path;
        private System.Windows.Forms.DataGridViewTextBoxColumn _yeuthich;
        private System.Windows.Forms.DataGridViewTextBoxColumn _loibaihat;
        private System.Windows.Forms.ToolStripMenuItem mnuQLBH;
        private System.Windows.Forms.ToolStripMenuItem mnuTCBH;
        private System.Windows.Forms.ToolStripMenuItem mnuTV;
    }
}

