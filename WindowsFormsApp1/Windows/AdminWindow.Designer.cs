using System;

namespace WindowsFormsApp1
{
    partial class AdminWindow
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TeachPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchTeach_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddTeacher = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.TF_name = new System.Windows.Forms.TextBox();
            this.TDataOFBirth = new System.Windows.Forms.TextBox();
            this.TSalary = new System.Windows.Forms.TextBox();
            this.TSubject = new System.Windows.Forms.TextBox();
            this.TS_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RemStudent = new System.Windows.Forms.TabPage();
            this.SearchPhone_St = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.SearchSt_btn = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ispaid = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.F_name = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.TextBox();
            this.profession = new System.Windows.Forms.TextBox();
            this.S_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1.SuspendLayout();
            this.AddTeacher.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RemStudent.SuspendLayout();
            this.AddStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView2);
            this.tabPage1.Controls.Add(this.TeachPhone);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.SearchTeach_btn);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(616, 322);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Remove Teacher";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TeachPhone
            // 
            this.TeachPhone.Location = new System.Drawing.Point(61, 208);
            this.TeachPhone.Name = "TeachPhone";
            this.TeachPhone.Size = new System.Drawing.Size(157, 20);
            this.TeachPhone.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(68, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Enter Phone Number";
            // 
            // SearchTeach_btn
            // 
            this.SearchTeach_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTeach_btn.Location = new System.Drawing.Point(49, 258);
            this.SearchTeach_btn.Name = "SearchTeach_btn";
            this.SearchTeach_btn.Size = new System.Drawing.Size(181, 34);
            this.SearchTeach_btn.TabIndex = 27;
            this.SearchTeach_btn.Text = "Search";
            this.SearchTeach_btn.UseVisualStyleBackColor = true;
            this.SearchTeach_btn.Click += new System.EventHandler(this.SearchTeach_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(332, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 59);
            this.button2.TabIndex = 25;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddTeacher
            // 
            this.AddTeacher.Controls.Add(this.groupBox2);
            this.AddTeacher.Location = new System.Drawing.Point(4, 22);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Size = new System.Drawing.Size(616, 322);
            this.AddTeacher.TabIndex = 2;
            this.AddTeacher.Text = "Add Teacher";
            this.AddTeacher.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tPhone);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.TF_name);
            this.groupBox2.Controls.Add(this.TDataOFBirth);
            this.groupBox2.Controls.Add(this.TSalary);
            this.groupBox2.Controls.Add(this.TSubject);
            this.groupBox2.Controls.Add(this.TS_name);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tPhone
            // 
            this.tPhone.Location = new System.Drawing.Point(238, 161);
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(100, 20);
            this.tPhone.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(264, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 45);
            this.button6.TabIndex = 12;
            this.button6.Text = "Apply";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TF_name
            // 
            this.TF_name.Location = new System.Drawing.Point(35, 45);
            this.TF_name.Name = "TF_name";
            this.TF_name.Size = new System.Drawing.Size(100, 20);
            this.TF_name.TabIndex = 11;
            // 
            // TDataOFBirth
            // 
            this.TDataOFBirth.Location = new System.Drawing.Point(425, 45);
            this.TDataOFBirth.Name = "TDataOFBirth";
            this.TDataOFBirth.Size = new System.Drawing.Size(100, 20);
            this.TDataOFBirth.TabIndex = 10;
            // 
            // TSalary
            // 
            this.TSalary.Location = new System.Drawing.Point(425, 161);
            this.TSalary.Name = "TSalary";
            this.TSalary.Size = new System.Drawing.Size(100, 20);
            this.TSalary.TabIndex = 9;
            // 
            // TSubject
            // 
            this.TSubject.Location = new System.Drawing.Point(35, 161);
            this.TSubject.Name = "TSubject";
            this.TSubject.Size = new System.Drawing.Size(100, 20);
            this.TSubject.TabIndex = 7;
            // 
            // TS_name
            // 
            this.TS_name.Location = new System.Drawing.Point(238, 45);
            this.TS_name.Name = "TS_name";
            this.TS_name.Size = new System.Drawing.Size(100, 20);
            this.TS_name.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(54, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Subject";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(448, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Salary";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(437, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "DateOfBirth";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(253, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Lastname";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(54, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Firstname";
            // 
            // RemStudent
            // 
            this.RemStudent.Controls.Add(this.SearchPhone_St);
            this.RemStudent.Controls.Add(this.label8);
            this.RemStudent.Controls.Add(this.listView1);
            this.RemStudent.Controls.Add(this.button3);
            this.RemStudent.Controls.Add(this.SearchSt_btn);
            this.RemStudent.Location = new System.Drawing.Point(4, 22);
            this.RemStudent.Name = "RemStudent";
            this.RemStudent.Padding = new System.Windows.Forms.Padding(3);
            this.RemStudent.Size = new System.Drawing.Size(616, 322);
            this.RemStudent.TabIndex = 1;
            this.RemStudent.Text = "Remove Student";
            this.RemStudent.UseVisualStyleBackColor = true;
            // 
            // SearchPhone_St
            // 
            this.SearchPhone_St.Location = new System.Drawing.Point(71, 217);
            this.SearchPhone_St.Name = "SearchPhone_St";
            this.SearchPhone_St.Size = new System.Drawing.Size(157, 20);
            this.SearchPhone_St.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(78, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Enter Phone Number";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(617, 173);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "F_name";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "S_name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DateOfBirht";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Course";
            this.columnHeader4.Width = 57;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Profession";
            this.columnHeader5.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IsPaid";
            this.columnHeader6.Width = 61;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(356, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 70);
            this.button3.TabIndex = 18;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchSt_btn
            // 
            this.SearchSt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchSt_btn.Location = new System.Drawing.Point(59, 267);
            this.SearchSt_btn.Name = "SearchSt_btn";
            this.SearchSt_btn.Size = new System.Drawing.Size(181, 34);
            this.SearchSt_btn.TabIndex = 17;
            this.SearchSt_btn.Text = "Search";
            this.SearchSt_btn.UseVisualStyleBackColor = true;
            this.SearchSt_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Controls.Add(this.groupBox1);
            this.AddStudent.Location = new System.Drawing.Point(4, 22);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.AddStudent.Size = new System.Drawing.Size(616, 322);
            this.AddStudent.TabIndex = 0;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ispaid);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.F_name);
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Controls.Add(this.course);
            this.groupBox1.Controls.Add(this.profession);
            this.groupBox1.Controls.Add(this.S_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sPhone
            // 
            this.sPhone.Location = new System.Drawing.Point(405, 153);
            this.sPhone.Name = "sPhone";
            this.sPhone.Size = new System.Drawing.Size(100, 20);
            this.sPhone.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(430, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // ispaid
            // 
            this.ispaid.AutoSize = true;
            this.ispaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ispaid.Location = new System.Drawing.Point(530, 153);
            this.ispaid.Name = "ispaid";
            this.ispaid.Size = new System.Drawing.Size(64, 20);
            this.ispaid.TabIndex = 13;
            this.ispaid.Text = "IsPaid";
            this.ispaid.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_name
            // 
            this.F_name.Location = new System.Drawing.Point(25, 36);
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(100, 20);
            this.F_name.TabIndex = 11;
            this.F_name.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(418, 36);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirth.TabIndex = 10;
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(25, 149);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(100, 20);
            this.course.TabIndex = 9;
            // 
            // profession
            // 
            this.profession.Location = new System.Drawing.Point(212, 153);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(100, 20);
            this.profession.TabIndex = 7;
            // 
            // S_name
            // 
            this.S_name.Location = new System.Drawing.Point(225, 36);
            this.S_name.Name = "S_name";
            this.S_name.Size = new System.Drawing.Size(100, 20);
            this.S_name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(222, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Profession";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(430, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateOfBirth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(246, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firsname";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddStudent);
            this.tabControl1.Controls.Add(this.RemStudent);
            this.tabControl1.Controls.Add(this.AddTeacher);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.AllowColumnReorder = true;
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.Phone});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(616, 164);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "F_name";
            this.columnHeader7.Width = 108;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "S_name";
            this.columnHeader8.Width = 104;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "DateOfBirth";
            this.columnHeader9.Width = 82;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Subject";
            this.columnHeader10.Width = 81;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Salary";
            this.columnHeader11.Width = 111;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 125;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 349);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AddTeacher.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RemStudent.ResumeLayout(false);
            this.RemStudent.PerformLayout();
            this.AddStudent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TeachPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SearchTeach_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage AddTeacher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TF_name;
        private System.Windows.Forms.TextBox TDataOFBirth;
        private System.Windows.Forms.TextBox TSalary;
        private System.Windows.Forms.TextBox TSubject;
        private System.Windows.Forms.TextBox TS_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage RemStudent;
        private System.Windows.Forms.TextBox SearchPhone_St;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SearchSt_btn;
        private System.Windows.Forms.TabPage AddStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ispaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.TextBox DateOfBirth;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.TextBox profession;
        private System.Windows.Forms.TextBox S_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private EventHandler listView3_SelectedIndexChanged;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader Phone;
    }
}