namespace My_Music
{
    partial class frm_QLBH
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQLBH = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbaihat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luocnghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeuthich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loibaihat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themBaiHat = new System.Windows.Forms.Button();
            this.btnSuaBaiHat = new System.Windows.Forms.Button();
            this.btnXoaBaiHat = new System.Windows.Forms.Button();
            this.btnThoatQLBH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bài hát";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvQLBH
            // 
            this.dgvQLBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TT,
            this.tenbaihat,
            this.tencasi,
            this.path,
            this.luocnghe,
            this.yeuthich,
            this.loibaihat});
            this.dgvQLBH.Location = new System.Drawing.Point(31, 79);
            this.dgvQLBH.Name = "dgvQLBH";
            this.dgvQLBH.RowHeadersWidth = 51;
            this.dgvQLBH.RowTemplate.Height = 24;
            this.dgvQLBH.Size = new System.Drawing.Size(1199, 454);
            this.dgvQLBH.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // TT
            // 
            this.TT.DataPropertyName = "TT";
            this.TT.HeaderText = "TT";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.Width = 50;
            // 
            // tenbaihat
            // 
            this.tenbaihat.DataPropertyName = "tenbaihat";
            this.tenbaihat.HeaderText = "Tên bài hát";
            this.tenbaihat.MinimumWidth = 6;
            this.tenbaihat.Name = "tenbaihat";
            this.tenbaihat.Width = 200;
            // 
            // tencasi
            // 
            this.tencasi.DataPropertyName = "tencasi";
            this.tencasi.HeaderText = "Ca sĩ";
            this.tencasi.MinimumWidth = 6;
            this.tencasi.Name = "tencasi";
            this.tencasi.Width = 125;
            // 
            // path
            // 
            this.path.DataPropertyName = "path";
            this.path.HeaderText = "Đường dẫn";
            this.path.MinimumWidth = 6;
            this.path.Name = "path";
            this.path.Width = 125;
            // 
            // luocnghe
            // 
            this.luocnghe.DataPropertyName = "luotnghe";
            this.luocnghe.HeaderText = "Lượt nghe";
            this.luocnghe.MinimumWidth = 6;
            this.luocnghe.Name = "luocnghe";
            this.luocnghe.Width = 125;
            // 
            // yeuthich
            // 
            this.yeuthich.DataPropertyName = "yeuthich";
            this.yeuthich.HeaderText = "Yêu thích";
            this.yeuthich.MinimumWidth = 6;
            this.yeuthich.Name = "yeuthich";
            this.yeuthich.Width = 125;
            // 
            // loibaihat
            // 
            this.loibaihat.DataPropertyName = "loibaihat";
            this.loibaihat.HeaderText = "Lời bài hát";
            this.loibaihat.MinimumWidth = 6;
            this.loibaihat.Name = "loibaihat";
            this.loibaihat.Width = 125;
            // 
            // btn_themBaiHat
            // 
            this.btn_themBaiHat.Location = new System.Drawing.Point(282, 570);
            this.btn_themBaiHat.Name = "btn_themBaiHat";
            this.btn_themBaiHat.Size = new System.Drawing.Size(137, 42);
            this.btn_themBaiHat.TabIndex = 2;
            this.btn_themBaiHat.Text = "Thêm";
            this.btn_themBaiHat.UseVisualStyleBackColor = true;
            // 
            // btnSuaBaiHat
            // 
            this.btnSuaBaiHat.Location = new System.Drawing.Point(446, 570);
            this.btnSuaBaiHat.Name = "btnSuaBaiHat";
            this.btnSuaBaiHat.Size = new System.Drawing.Size(137, 42);
            this.btnSuaBaiHat.TabIndex = 3;
            this.btnSuaBaiHat.Text = "Sửa";
            this.btnSuaBaiHat.UseVisualStyleBackColor = true;
            // 
            // btnXoaBaiHat
            // 
            this.btnXoaBaiHat.Location = new System.Drawing.Point(613, 570);
            this.btnXoaBaiHat.Name = "btnXoaBaiHat";
            this.btnXoaBaiHat.Size = new System.Drawing.Size(137, 42);
            this.btnXoaBaiHat.TabIndex = 4;
            this.btnXoaBaiHat.Text = "Xóa";
            this.btnXoaBaiHat.UseVisualStyleBackColor = true;
            // 
            // btnThoatQLBH
            // 
            this.btnThoatQLBH.Location = new System.Drawing.Point(780, 570);
            this.btnThoatQLBH.Name = "btnThoatQLBH";
            this.btnThoatQLBH.Size = new System.Drawing.Size(137, 42);
            this.btnThoatQLBH.TabIndex = 5;
            this.btnThoatQLBH.Text = "Thoát";
            this.btnThoatQLBH.UseVisualStyleBackColor = true;
            // 
            // frm_QLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 662);
            this.Controls.Add(this.btnThoatQLBH);
            this.Controls.Add(this.btnXoaBaiHat);
            this.Controls.Add(this.btnSuaBaiHat);
            this.Controls.Add(this.btn_themBaiHat);
            this.Controls.Add(this.dgvQLBH);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLBH";
            this.Text = "frm_QLBH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQLBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbaihat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn luocnghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeuthich;
        private System.Windows.Forms.DataGridViewTextBoxColumn loibaihat;
        private System.Windows.Forms.Button btn_themBaiHat;
        private System.Windows.Forms.Button btnSuaBaiHat;
        private System.Windows.Forms.Button btnXoaBaiHat;
        private System.Windows.Forms.Button btnThoatQLBH;
    }
}