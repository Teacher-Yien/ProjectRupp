namespace WindowsFormsApp1
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtPaidID = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtMajorID = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffPosition = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.dtpPayment = new System.Windows.Forms.DateTimePicker();
            this.checkPaid = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboPaidMethod = new System.Windows.Forms.ComboBox();
            this.cboPaidType = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "លេខកូដចំណាយ៖";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "កាលបរិច្ឋេទការចំណាយ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ចំនួនទឹកប្រាក់ត្រូវចំណាយ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "លេខកូដជំនាញ៖";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "លេខកូដនិស្សិត៖";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "លេខកូដបុគ្គលិក៖";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "តួនាទីបុគ្គលិក:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(445, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 37);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "ស្វែងរក";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "ចំណាយរួចរាល់:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "ប្រភេទនៃការចំណាយ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "ចំណាយសម្រាប់ឆមាសទី៖";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 29);
            this.label11.TabIndex = 11;
            this.label11.Text = "ឈ្មោះបុគ្គលិក:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(17, 512);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(172, 37);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "បន្ថែមថ្មី(កំណត់ទីតាំង)";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(249, 512);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 37);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "កែប្រែព័ត៌មាន";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(464, 512);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 37);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "បន្ថែមថ្មី";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(655, 512);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(114, 37);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "ចាកចេញ";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // txtPaidID
            // 
            this.txtPaidID.Location = new System.Drawing.Point(201, 34);
            this.txtPaidID.Name = "txtPaidID";
            this.txtPaidID.Size = new System.Drawing.Size(226, 37);
            this.txtPaidID.TabIndex = 16;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(201, 159);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(226, 37);
            this.txtPaidAmount.TabIndex = 18;
            // 
            // txtMajorID
            // 
            this.txtMajorID.Location = new System.Drawing.Point(201, 226);
            this.txtMajorID.Name = "txtMajorID";
            this.txtMajorID.Size = new System.Drawing.Size(226, 37);
            this.txtMajorID.TabIndex = 19;
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(201, 293);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(226, 37);
            this.txtStuID.TabIndex = 20;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(201, 357);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(226, 37);
            this.txtStaffID.TabIndex = 21;
            // 
            // txtStaffPosition
            // 
            this.txtStaffPosition.Location = new System.Drawing.Point(201, 431);
            this.txtStaffPosition.Name = "txtStaffPosition";
            this.txtStaffPosition.Size = new System.Drawing.Size(568, 37);
            this.txtStaffPosition.TabIndex = 22;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(543, 357);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(226, 37);
            this.txtStaffName.TabIndex = 23;
            // 
            // dtpPayment
            // 
            this.dtpPayment.Location = new System.Drawing.Point(201, 98);
            this.dtpPayment.Name = "dtpPayment";
            this.dtpPayment.Size = new System.Drawing.Size(226, 37);
            this.dtpPayment.TabIndex = 24;
            // 
            // checkPaid
            // 
            this.checkPaid.AutoSize = true;
            this.checkPaid.Location = new System.Drawing.Point(580, 114);
            this.checkPaid.Name = "checkPaid";
            this.checkPaid.Size = new System.Drawing.Size(15, 14);
            this.checkPaid.TabIndex = 25;
            this.checkPaid.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "ចំណាយតាមរយ:";
            // 
            // cboPaidMethod
            // 
            this.cboPaidMethod.FormattingEnabled = true;
            this.cboPaidMethod.Location = new System.Drawing.Point(592, 158);
            this.cboPaidMethod.Name = "cboPaidMethod";
            this.cboPaidMethod.Size = new System.Drawing.Size(177, 37);
            this.cboPaidMethod.TabIndex = 27;
            // 
            // cboPaidType
            // 
            this.cboPaidType.FormattingEnabled = true;
            this.cboPaidType.Location = new System.Drawing.Point(592, 226);
            this.cboPaidType.Name = "cboPaidType";
            this.cboPaidType.Size = new System.Drawing.Size(177, 37);
            this.cboPaidType.TabIndex = 28;
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Location = new System.Drawing.Point(624, 293);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(145, 37);
            this.cboSemester.TabIndex = 29;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 601);
            this.Controls.Add(this.cboSemester);
            this.Controls.Add(this.cboPaidType);
            this.Controls.Add(this.cboPaidMethod);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkPaid);
            this.Controls.Add(this.dtpPayment);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffPosition);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.txtMajorID);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.txtPaidID);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("!Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Payment";
            this.Text = "ព័ត៌មានការចំណាយ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtPaidID;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtMajorID;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffPosition;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.DateTimePicker dtpPayment;
        private System.Windows.Forms.CheckBox checkPaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboPaidMethod;
        private System.Windows.Forms.ComboBox cboPaidType;
        private System.Windows.Forms.ComboBox cboSemester;
    }
}