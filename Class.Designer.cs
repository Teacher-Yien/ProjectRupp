namespace Shcool_management
{
    partial class Class
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.DataGridView();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occuption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_up_Calss = new System.Windows.Forms.Button();
            this.btn_Add_new_Class = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(0, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 50);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "x";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(527, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "ថ្នាក់បង្រៀន";
            // 
            // tbClass
            // 
            this.tbClass.AllowUserToOrderColumns = true;
            this.tbClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbClass.ColumnHeadersHeight = 40;
            this.tbClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Session,
            this.fullName,
            this.StudentID,
            this.StudentName,
            this.gender,
            this.DOB,
            this.phone,
            this.occuption,
            this.classes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbClass.DefaultCellStyle = dataGridViewCellStyle1;
            this.tbClass.Location = new System.Drawing.Point(4, 214);
            this.tbClass.Name = "tbClass";
            this.tbClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer SN Kampot", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbClass.RowHeadersWidth = 51;
            this.tbClass.RowTemplate.Height = 24;
            this.tbClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbClass.Size = new System.Drawing.Size(1244, 398);
            this.tbClass.TabIndex = 5;
            // 
            // Session
            // 
            this.Session.FillWeight = 50F;
            this.Session.HeaderText = "ជំនាន់";
            this.Session.MinimumWidth = 6;
            this.Session.Name = "Session";
            // 
            // fullName
            // 
            this.fullName.HeaderText = "ឈ្មោះថ្នាក់";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "លេខសំគាល់និស្សិត";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "ឈ្មោះនិស្សិត";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            // 
            // gender
            // 
            this.gender.HeaderText = "ភេទ";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            // 
            // phone
            // 
            this.phone.HeaderText = "លេខទូស័ព្ទ";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // occuption
            // 
            this.occuption.HeaderText = "មុខងារ";
            this.occuption.MinimumWidth = 6;
            this.occuption.Name = "occuption";
            // 
            // classes
            // 
            this.classes.HeaderText = "ថ្នាក់រៀន";
            this.classes.MinimumWidth = 6;
            this.classes.Name = "classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "ស្វែងរកឈ្មោះថ្នាក់";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(972, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 47);
            this.textBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Khmer SN Kampot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Shcool_management.Properties.Resources.printer;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(584, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "    បោះពុម្ព";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Khmer SN Kampot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Shcool_management.Properties.Resources.delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(396, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "    លុបថ្នាក់";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_up_Calss
            // 
            this.btn_up_Calss.Font = new System.Drawing.Font("Khmer SN Kampot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up_Calss.Image = global::Shcool_management.Properties.Resources.system_update;
            this.btn_up_Calss.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_up_Calss.Location = new System.Drawing.Point(213, 130);
            this.btn_up_Calss.Name = "btn_up_Calss";
            this.btn_up_Calss.Size = new System.Drawing.Size(177, 52);
            this.btn_up_Calss.TabIndex = 2;
            this.btn_up_Calss.Text = "    កែប្រែថ្នាក់ថ្មី";
            this.btn_up_Calss.UseVisualStyleBackColor = true;
            this.btn_up_Calss.Click += new System.EventHandler(this.btn_up_Calss_Click);
            // 
            // btn_Add_new_Class
            // 
            this.btn_Add_new_Class.Font = new System.Drawing.Font("Khmer SN Kampot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_new_Class.Image = global::Shcool_management.Properties.Resources.training;
            this.btn_Add_new_Class.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Add_new_Class.Location = new System.Drawing.Point(12, 130);
            this.btn_Add_new_Class.Name = "btn_Add_new_Class";
            this.btn_Add_new_Class.Size = new System.Drawing.Size(176, 52);
            this.btn_Add_new_Class.TabIndex = 1;
            this.btn_Add_new_Class.Text = "    បន្តែមថ្នាក់ថ្មី";
            this.btn_Add_new_Class.UseVisualStyleBackColor = true;
            this.btn_Add_new_Class.Click += new System.EventHandler(this.btn_Add_new_Class_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 624);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_up_Calss);
            this.Controls.Add(this.btn_Add_new_Class);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Class";
            this.Text = "Class";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add_new_Class;
        private System.Windows.Forms.Button btn_up_Calss;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView tbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn occuption;
        private System.Windows.Forms.DataGridViewTextBoxColumn classes;
        private System.Windows.Forms.Button btn_exit;
    }
}