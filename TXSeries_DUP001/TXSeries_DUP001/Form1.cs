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
    public partial class Form1 : Form
    {
        public Form1()
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
            Student s = new Student(this.textBox1.Text);

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
    }
}
