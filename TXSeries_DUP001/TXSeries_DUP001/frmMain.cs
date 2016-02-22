using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TXSeries_DUP001
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdProcess_Click(object sender, EventArgs e)
        {
            //Student s = StudentDB.Inquire("999999995");

            this.textBox1.Text = StudentDB.Inquire("999999995").ToString();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            s.STUD_ID = txtSTUD_ID.Text;
            s.STUD_FIRST_NM = txtSTUD_FIRST_NM.Text;
            s.STUD_LAST_NM = txtSTUD_LAST_NM.Text;
            s.STUD_GPA = txtGPA.Text;
            s.STUD_MAJOR_CD = txtMAJOR_CD.Text;
            s.STUD_DOB = txtDOB.Text;

            StudentDB.Update(s);
        }

        private void cmdInquire_Click(object sender, EventArgs e)
        {
            Student s = StudentDB.Inquire(txtSTUD_ID.Text);

            txtSTUD_ID.Text = s.STUD_ID.TrimEnd();
            txtSTUD_FIRST_NM.Text = s.STUD_FIRST_NM.TrimEnd();
            txtSTUD_LAST_NM.Text = s.STUD_LAST_NM.TrimEnd();
            txtGPA.Text = s.STUD_GPA.TrimEnd();
            txtMAJOR_CD.Text = s.STUD_MAJOR_CD.TrimEnd();
            txtDOB.Text = s.STUD_DOB.TrimEnd();
            txtUSER_ADD_ID.Text = s.STUD_ADD_USER_ID.TrimEnd();
            txtSTUD_ADD_DT.Text = s.STUD_ADD_DT.TrimEnd();
            txtSTUD_ADD_TM.Text = s.STUD_ADD_TM.TrimEnd();
            txtUSER_CHNG_ID.Text = s.STUD_CHNG_USER_ID.TrimEnd();
            txtSTUD_CHNG_DT.Text = s.STUD_CHNG_DT.TrimEnd();
            txtSTUD_CHNG_TM.Text = s.STUD_CHNG_TM.TrimEnd();
            txtSTUD_DEL_FLG.Text = s.STUD_DEL_FLG.TrimEnd();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {

            Student s = new Student();

            s.STUD_ID = txtSTUD_ID.Text;
            s.STUD_FIRST_NM = txtSTUD_FIRST_NM.Text;
            s.STUD_LAST_NM = txtSTUD_LAST_NM.Text;
            s.STUD_GPA = txtGPA.Text; 
            s.STUD_MAJOR_CD = txtMAJOR_CD.Text;
            s.STUD_DOB = txtDOB.Text;

            StudentDB.Add(s); 

        }

        private void cmdList_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            s.STUD_LAST_NM = txtSTUD_LAST_NM.Text; 

            Student[] students = StudentDB.List(s);

            textBox1.Text = String.Empty;
            if( students != null )
                foreach (Student st in students)
                    textBox1.Text += st.ToString() + "\r\n";
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.STUD_ID = txtSTUD_ID.Text;
            StudentDB.Delete(s); 
        }

        private void cmdUndelete_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.STUD_ID = txtSTUD_ID.Text;
            StudentDB.UnDelete(s); 
        }

        private void cmdPurge_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.STUD_ID = txtSTUD_ID.Text;
            StudentDB.Purge(s); 
        }

        private void integrateBtn_Click(object sender, EventArgs e)
        {
            string email = txtSTUD_FIRST_NM.ToString();
            string email2 = txtSTUD_LAST_NM.ToString();

            email = email.Remove(0, 35);
            email = email.Substring(0, 2);
            email2 = email2.Remove(0, 35);
            email += email2;
            email += "@email.davenport.edu";

            emailTxt.Text = email;


            localhost.BBStudentData s = new localhost.BBStudentData();

            s.setStudentID(txtSTUD_ID.Text);
            s.setFirstName(txtSTUD_FIRST_NM.Text);
            s.setLastName(txtSTUD_LAST_NM.Text);
            s.setDOB(txtDOB.Text);
            s.setGPA(txtGPA.Text);
            s.setMajorCode(txtMAJOR_CD.Text);
            s.setAddDate(txtSTUD_ADD_DT.Text);
            s.setChangeDate(txtSTUD_CHNG_DT.Text);
            s.setChangeTime(txtSTUD_CHNG_TM.Text);
            s.setEmail(emailTxt.Text);

            //localhost.BBStudentData b = new localhost.BBStudentData();

            //MessageBox.Show(" Data:\n" + b.getStudentID() + "\n" + b.getFirstName() + "\n" + b.getLastName() + "\n" + b.getDOB() + "\n" + b.getGPA() + "\n" + b.getMajorCode() + "\n" + b.getAddDate() + "\n" + b.getChangeDate() + "\n" + b.getChangeTime());
            //MessageBox.Show(b.getFirstName());
            //MessageBox.Show(b.getLastName());
            //MessageBox.Show(b.getDOB());
            //MessageBox.Show(b.getGPA());
            //MessageBox.Show(b.getMajorCode());
            //MessageBox.Show(b.getAddDate());
            //MessageBox.Show(b.getChangeDate());
            //MessageBox.Show(b.getChangeTime());
        }
    }
}
