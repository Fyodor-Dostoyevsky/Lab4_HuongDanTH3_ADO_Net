namespace Lab4_HuongDanTH3_ADO_Net
{
    partial class UpdateTrungthongtin
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
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.dtpNgaysinhU = new System.Windows.Forms.DateTimePicker();
            this.cmbLopU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiemTBU = new System.Windows.Forms.TextBox();
            this.txtDiaChiU = new System.Windows.Forms.TextBox();
            this.txtTenhsU = new System.Windows.Forms.TextBox();
            this.txtMahsU = new System.Windows.Forms.TextBox();
            this.grbThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongtin
            // 
            this.grbThongtin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbThongtin.Controls.Add(this.dtpNgaysinhU);
            this.grbThongtin.Controls.Add(this.cmbLopU);
            this.grbThongtin.Controls.Add(this.label7);
            this.grbThongtin.Controls.Add(this.label6);
            this.grbThongtin.Controls.Add(this.label5);
            this.grbThongtin.Controls.Add(this.label4);
            this.grbThongtin.Controls.Add(this.label3);
            this.grbThongtin.Controls.Add(this.label2);
            this.grbThongtin.Controls.Add(this.txtDiemTBU);
            this.grbThongtin.Controls.Add(this.txtDiaChiU);
            this.grbThongtin.Controls.Add(this.txtTenhsU);
            this.grbThongtin.Controls.Add(this.txtMahsU);
            this.grbThongtin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongtin.Location = new System.Drawing.Point(29, 45);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Size = new System.Drawing.Size(1062, 227);
            this.grbThongtin.TabIndex = 2;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin học sinh";
            // 
            // dtpNgaysinhU
            // 
            this.dtpNgaysinhU.CustomFormat = "yyyy/MM/dd";
            this.dtpNgaysinhU.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinhU.Location = new System.Drawing.Point(162, 83);
            this.dtpNgaysinhU.Name = "dtpNgaysinhU";
            this.dtpNgaysinhU.Size = new System.Drawing.Size(361, 30);
            this.dtpNgaysinhU.TabIndex = 12;
            this.dtpNgaysinhU.ValueChanged += new System.EventHandler(this.dtpNgaysinhU_ValueChanged);
            // 
            // cmbLopU
            // 
            this.cmbLopU.FormattingEnabled = true;
            this.cmbLopU.Location = new System.Drawing.Point(162, 141);
            this.cmbLopU.Name = "cmbLopU";
            this.cmbLopU.Size = new System.Drawing.Size(361, 31);
            this.cmbLopU.TabIndex = 11;
            this.cmbLopU.SelectedIndexChanged += new System.EventHandler(this.cmbLopU_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Điểm TB";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên học sinh";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã học sinh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDiemTBU
            // 
            this.txtDiemTBU.Location = new System.Drawing.Point(687, 144);
            this.txtDiemTBU.Name = "txtDiemTBU";
            this.txtDiemTBU.Size = new System.Drawing.Size(318, 30);
            this.txtDiemTBU.TabIndex = 3;
            this.txtDiemTBU.TextChanged += new System.EventHandler(this.txtDiemTBU_TextChanged);
            // 
            // txtDiaChiU
            // 
            this.txtDiaChiU.Location = new System.Drawing.Point(687, 89);
            this.txtDiaChiU.Name = "txtDiaChiU";
            this.txtDiaChiU.Size = new System.Drawing.Size(320, 30);
            this.txtDiaChiU.TabIndex = 2;
            this.txtDiaChiU.TextChanged += new System.EventHandler(this.txtDiaChiU_TextChanged);
            // 
            // txtTenhsU
            // 
            this.txtTenhsU.Location = new System.Drawing.Point(687, 23);
            this.txtTenhsU.Name = "txtTenhsU";
            this.txtTenhsU.Size = new System.Drawing.Size(318, 30);
            this.txtTenhsU.TabIndex = 1;
            this.txtTenhsU.TextChanged += new System.EventHandler(this.txtTenhsU_TextChanged);
            // 
            // txtMahsU
            // 
            this.txtMahsU.Location = new System.Drawing.Point(162, 25);
            this.txtMahsU.Name = "txtMahsU";
            this.txtMahsU.Size = new System.Drawing.Size(361, 30);
            this.txtMahsU.TabIndex = 0;
            this.txtMahsU.TextChanged += new System.EventHandler(this.txtMahs_TextChanged);
            // 
            // UpdateTrungthongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 337);
            this.Controls.Add(this.grbThongtin);
            this.Name = "UpdateTrungthongtin";
            this.Text = "UpdateTrungthongtin";
            this.Load += new System.EventHandler(this.UpdateTrungthongtin_Load);
            this.grbThongtin.ResumeLayout(false);
            this.grbThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhU;
        private System.Windows.Forms.ComboBox cmbLopU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemTBU;
        private System.Windows.Forms.TextBox txtDiaChiU;
        private System.Windows.Forms.TextBox txtTenhsU;
        private System.Windows.Forms.TextBox txtMahsU;
    }
}