using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class AdminWindow : Form
    {
        
        
        public AdminWindow()
        {
            InitializeComponent();

            
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool cheak = false;
            List<Student> student = new List<Student>();

            if (F_name.Text != "" && S_name.Text != "" && DateOfBirth.Text != "" && course.Text != "" && profession.Text != "" && sPhone.Text != "")
            { 
                cheak = true;
                student.Add(new Student { F_name = F_name.Text, S_name = S_name.Text, DateOfBith = DateOfBirth.Text, Course = int.Parse(course.Text), Direction = profession.Text, Phone = sPhone.Text, IsPaidContract = ispaid.Checked });
            }

            else ShowMessageWindow.Message("You must fill each of line!", "Warning");

            var res = DialogResult;
            if (cheak) res = ShowMessageWindow.Message("Do you want to save this student?", "Attention");
           
            if (res == DialogResult.Yes) Database.WriteStDb(student);

            F_name.Clear();
            S_name.Clear();
            profession.Clear();
            course.Clear();
            DateOfBirth.Clear();
            sPhone.Clear();
        }

        private void RemTeacher_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var finded_st =  Database.SearchStudent(SearchPhone_St.Text);

            if (finded_st.Count > 0)
            {

                string[] info = finded_st[0].ToString().Split('\t');

                ListViewItem item = new ListViewItem(info);
                listView1.Items.Add(item);
            }
            else ShowMessageWindow.Message("Student not found!", "Warning");
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            List<Teacher> teachers = new List<Teacher>();
            bool cheak = false;
            if (TF_name.Text != "" && TS_name.Text != "" && TSalary.Text != "" && TSubject.Text != "" && TDataOFBirth.Text != "" && tPhone.Text != "")
            {
                cheak = true;
                teachers.Add(new Teacher{ F_name = TF_name.Text, S_name = TS_name.Text, DateOfBith = TDataOFBirth.Text, Phone = tPhone.Text, Salary = double.Parse(TSalary.Text), Subject = TSubject.Text });
                
            }
            else ShowMessageWindow.Message("You must fill each of line!", "Warning");

            var res = DialogResult;
            if (cheak) res = ShowMessageWindow.Message("Do you want to save this teacher?", "Attention");

            if (res == DialogResult.Yes) Database.WriteTeacherDb(teachers);
            

            TF_name.Clear();
            TS_name.Clear();
            TSalary.Clear();
            TSubject.Clear();
            TDataOFBirth.Clear();
            tPhone.Clear();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database.RemStFromDb(SearchPhone_St.Text);
            SearchPhone_St.Clear();
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTeach_btn_Click(object sender, EventArgs e)
        {
            var finded = Database.SearchTeacher(TeachPhone.Text);

            if (finded.Count > 0)
            {

                string[] info = finded[0].ToString().Split('\t');

                ListViewItem item = new ListViewItem(info);
                listView2.Items.Add(item);
            }
            else ShowMessageWindow.Message("Teacher not found!", "Warning");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Database.RemTeachFromDb(TeachPhone.Text);
            TeachPhone.Clear();
            listView2.Items.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
