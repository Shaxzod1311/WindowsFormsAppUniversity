using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
         

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string U_name = "admin1113";
            string Pass = "12345";

            

            

            if (U_name == username.Text && Pass == pass.Text)
            {
                AdminWindow adminWin = new AdminWindow();
                adminWin.Show();
            }

            else ShowMessageWindow.Message("Wrong Password , or Login!", "Error");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            List <Student> lst = Database.ReadStInfoFromDb();
            var finded = lst.FindAll(p => p.F_name == Search_F_name.Text || p.S_name == Search_S_name.Text);
            listView1.Items.Clear();
            foreach(var st in finded)
            {
                string[] info = st.ToString().Split('\t');
                ListViewItem item = new ListViewItem(info);
                listView1.Items.Add(item);
            }
        }

        public void All_Student_Info_btn_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            foreach (var info in Database.ReadStInfoFromDb())
            {
                string[] view_item = info.ToString().Split('\t');
                ListViewItem list_item = new ListViewItem(view_item);
                listView1.Items.Add(list_item);
            }


        }

        private void Search_Teacher_btn_Click(object sender, EventArgs e)
        {
            List<Teacher> teachs = Database.ReadTeachersFromDb();
            teachs = teachs.FindAll(p => p.F_name == TSerch_F_name.Text || p.S_name == TSearch_S_name.Text);
            listView2.Items.Clear();
            foreach(var teach in teachs)
            {
                string[] info = teach.ToString().Split('\t');
                ListViewItem item = new ListViewItem(info);
                listView2.Items.Add(item);
            }

            TSearch_S_name.Clear();
            TSerch_F_name.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void All_Teachers_Info_btn_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            foreach (var info in Database.ReadTeachersFromDb())
            {
                string[] view_item = info.ToString().Split('\t');
                ListViewItem list_item = new ListViewItem(view_item);
                listView2.Items.Add(list_item);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
