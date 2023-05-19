namespace WindowsFormsApp1
{
    partial class frmQLBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBH));
            this.dgvQLBH = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tenbaihat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tencasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._luocNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._yeuthich = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._loibaihat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.txt_input_tenCaSi = new System.Windows.Forms.TextBox();
            this.txt_input_tenBaiHat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_input_loiBaiHat = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDangPhat_QLBH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLBH
            // 
            this.dgvQLBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._TT,
            this._tenbaihat,
            this._tencasi,
            this._path,
            this._luocNghe,
            this._yeuthich,
            this._loibaihat});
            this.dgvQLBH.Location = new System.Drawing.Point(4, 3);
            this.dgvQLBH.Name = "dgvQLBH";
            this.dgvQLBH.RowHeadersWidth = 51;
            this.dgvQLBH.RowTemplate.Height = 24;
            this.dgvQLBH.Size = new System.Drawing.Size(1164, 294);
            this.dgvQLBH.TabIndex = 0;
            this.dgvQLBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLBH_CellClick);
            this.dgvQLBH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLBH_CellDoubleClick);
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
            // _TT
            // 
            this._TT.DataPropertyName = "TT";
            this._TT.HeaderText = "TT";
            this._TT.MinimumWidth = 6;
            this._TT.Name = "_TT";
            this._TT.Width = 50;
            // 
            // _tenbaihat
            // 
            this._tenbaihat.DataPropertyName = "tenbaihat";
            this._tenbaihat.HeaderText = "Tên bài hát";
            this._tenbaihat.MinimumWidth = 6;
            this._tenbaihat.Name = "_tenbaihat";
            this._tenbaihat.Width = 150;
            // 
            // _tencasi
            // 
            this._tencasi.DataPropertyName = "tencasi";
            this._tencasi.HeaderText = "Tên ca sĩ";
            this._tencasi.MinimumWidth = 6;
            this._tencasi.Name = "_tencasi";
            this._tencasi.Width = 125;
            // 
            // _path
            // 
            this._path.DataPropertyName = "path";
            this._path.HeaderText = "Đường dẫn";
            this._path.MinimumWidth = 6;
            this._path.Name = "_path";
            this._path.Width = 250;
            // 
            // _luocNghe
            // 
            this._luocNghe.DataPropertyName = "luotnghe";
            this._luocNghe.HeaderText = "Lượt nghe";
            this._luocNghe.MinimumWidth = 6;
            this._luocNghe.Name = "_luocNghe";
            this._luocNghe.Width = 125;
            // 
            // _yeuthich
            // 
            this._yeuthich.DataPropertyName = "yeuthich";
            this._yeuthich.HeaderText = "Yêu thích";
            this._yeuthich.MinimumWidth = 6;
            this._yeuthich.Name = "_yeuthich";
            this._yeuthich.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._yeuthich.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._yeuthich.Width = 122;
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
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(24, 619);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 48);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(145, 619);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 48);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(266, 619);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 48);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(387, 619);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 48);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Thoát";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_path);
            this.panel1.Controls.Add(this.txt_input_tenCaSi);
            this.panel1.Controls.Add(this.txt_input_tenBaiHat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 236);
            this.panel1.TabIndex = 5;
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path.Location = new System.Drawing.Point(185, 104);
            this.txt_path.Multiline = true;
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(311, 59);
            this.txt_path.TabIndex = 5;
            // 
            // txt_input_tenCaSi
            // 
            this.txt_input_tenCaSi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_tenCaSi.Location = new System.Drawing.Point(185, 56);
            this.txt_input_tenCaSi.Name = "txt_input_tenCaSi";
            this.txt_input_tenCaSi.Size = new System.Drawing.Size(311, 27);
            this.txt_input_tenCaSi.TabIndex = 4;
            this.txt_input_tenCaSi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_input_tenBaiHat
            // 
            this.txt_input_tenBaiHat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_tenBaiHat.Location = new System.Drawing.Point(185, 12);
            this.txt_input_tenBaiHat.Name = "txt_input_tenBaiHat";
            this.txt_input_tenBaiHat.Size = new System.Drawing.Size(311, 27);
            this.txt_input_tenBaiHat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đường dẫn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên ca sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bài hát";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lời bài hát";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_input_loiBaiHat
            // 
            this.txt_input_loiBaiHat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_loiBaiHat.Location = new System.Drawing.Point(12, 43);
            this.txt_input_loiBaiHat.Multiline = true;
            this.txt_input_loiBaiHat.Name = "txt_input_loiBaiHat";
            this.txt_input_loiBaiHat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_input_loiBaiHat.Size = new System.Drawing.Size(625, 368);
            this.txt_input_loiBaiHat.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_input_loiBaiHat);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(528, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 417);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDangPhat_QLBH);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel3.Location = new System.Drawing.Point(1174, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 712);
            this.panel3.TabIndex = 8;
            // 
            // txtDangPhat_QLBH
            // 
            this.txtDangPhat_QLBH.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangPhat_QLBH.Location = new System.Drawing.Point(214, 666);
            this.txtDangPhat_QLBH.Name = "txtDangPhat_QLBH";
            this.txtDangPhat_QLBH.Size = new System.Drawing.Size(442, 27);
            this.txtDangPhat_QLBH.TabIndex = 11;
            this.txtDangPhat_QLBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 672);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đang phát";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 58);
            this.label5.TabIndex = 9;
            this.label5.Text = "My Music";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(54, 100);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(635, 415);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // frmQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgvQLBH);
            this.Name = "frmQLBH";
            this.Text = "Quản lý bài hát";
            this.Activated += new System.EventHandler(this.frmQLBH_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLBH;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input_tenCaSi;
        private System.Windows.Forms.TextBox txt_input_tenBaiHat;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tenbaihat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tencasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn _path;
        private System.Windows.Forms.DataGridViewTextBoxColumn _luocNghe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _yeuthich;
        private System.Windows.Forms.DataGridViewTextBoxColumn _loibaihat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_input_loiBaiHat;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDangPhat_QLBH;
        private System.Windows.Forms.Label label6;
    }
}