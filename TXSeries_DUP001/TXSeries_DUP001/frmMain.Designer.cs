namespace TXSeries_DUP001
{
    partial class frmMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdProcess = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTUD_ID = new System.Windows.Forms.TextBox();
            this.cmdInquire = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTUD_FIRST_NM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSTUD_LAST_NM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.MaskedTextBox();
            this.txtMAJOR_CD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUSER_ADD_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSTUD_ADD_DT = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSTUD_ADD_TM = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSTUD_CHNG_TM = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSTUD_CHNG_DT = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSTUD_DEL_FLG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUSER_CHNG_ID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdList = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUndelete = new System.Windows.Forms.Button();
            this.cmdPurge = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.integrateBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(236, 53);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            // 
            // cmdProcess
            // 
            this.cmdProcess.Location = new System.Drawing.Point(151, 237);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(75, 23);
            this.cmdProcess.TabIndex = 1;
            this.cmdProcess.Text = "Process";
            this.cmdProcess.UseVisualStyleBackColor = true;
            this.cmdProcess.Visible = false;
            this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(235, 230);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 2;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raw Data (commarea):";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // txtSTUD_ID
            // 
            this.txtSTUD_ID.Location = new System.Drawing.Point(111, 25);
            this.txtSTUD_ID.MaxLength = 9;
            this.txtSTUD_ID.Name = "txtSTUD_ID";
            this.txtSTUD_ID.Size = new System.Drawing.Size(99, 20);
            this.txtSTUD_ID.TabIndex = 5;
            // 
            // cmdInquire
            // 
            this.cmdInquire.Location = new System.Drawing.Point(235, 204);
            this.cmdInquire.Name = "cmdInquire";
            this.cmdInquire.Size = new System.Drawing.Size(75, 23);
            this.cmdInquire.TabIndex = 6;
            this.cmdInquire.Text = "Inquire";
            this.cmdInquire.UseVisualStyleBackColor = true;
            this.cmdInquire.Click += new System.EventHandler(this.cmdInquire_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name:";
            // 
            // txtSTUD_FIRST_NM
            // 
            this.txtSTUD_FIRST_NM.Location = new System.Drawing.Point(111, 51);
            this.txtSTUD_FIRST_NM.MaxLength = 20;
            this.txtSTUD_FIRST_NM.Name = "txtSTUD_FIRST_NM";
            this.txtSTUD_FIRST_NM.Size = new System.Drawing.Size(155, 20);
            this.txtSTUD_FIRST_NM.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name:";
            // 
            // txtSTUD_LAST_NM
            // 
            this.txtSTUD_LAST_NM.Location = new System.Drawing.Point(111, 77);
            this.txtSTUD_LAST_NM.MaxLength = 25;
            this.txtSTUD_LAST_NM.Name = "txtSTUD_LAST_NM";
            this.txtSTUD_LAST_NM.Size = new System.Drawing.Size(199, 20);
            this.txtSTUD_LAST_NM.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "GPA:";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(111, 129);
            this.txtGPA.Mask = "0.00";
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(40, 20);
            this.txtGPA.TabIndex = 12;
            // 
            // txtMAJOR_CD
            // 
            this.txtMAJOR_CD.Location = new System.Drawing.Point(111, 155);
            this.txtMAJOR_CD.MaxLength = 5;
            this.txtMAJOR_CD.Name = "txtMAJOR_CD";
            this.txtMAJOR_CD.Size = new System.Drawing.Size(57, 20);
            this.txtMAJOR_CD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Major:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(111, 103);
            this.txtDOB.Mask = "0#/0#/####";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(155, 20);
            this.txtDOB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "DOB:";
            // 
            // txtUSER_ADD_ID
            // 
            this.txtUSER_ADD_ID.Location = new System.Drawing.Point(145, 231);
            this.txtUSER_ADD_ID.MaxLength = 8;
            this.txtUSER_ADD_ID.Name = "txtUSER_ADD_ID";
            this.txtUSER_ADD_ID.Size = new System.Drawing.Size(99, 20);
            this.txtUSER_ADD_ID.TabIndex = 18;
            this.txtUSER_ADD_ID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "User Add ID:";
            this.label8.Visible = false;
            // 
            // txtSTUD_ADD_DT
            // 
            this.txtSTUD_ADD_DT.Location = new System.Drawing.Point(111, 181);
            this.txtSTUD_ADD_DT.Mask = "0#/0#/####";
            this.txtSTUD_ADD_DT.Name = "txtSTUD_ADD_DT";
            this.txtSTUD_ADD_DT.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_ADD_DT.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Add Date:";
            // 
            // txtSTUD_ADD_TM
            // 
            this.txtSTUD_ADD_TM.Location = new System.Drawing.Point(168, 228);
            this.txtSTUD_ADD_TM.Mask = "##:##:##";
            this.txtSTUD_ADD_TM.Name = "txtSTUD_ADD_TM";
            this.txtSTUD_ADD_TM.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_ADD_TM.TabIndex = 24;
            this.txtSTUD_ADD_TM.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Add Time:";
            this.label11.Visible = false;
            // 
            // txtSTUD_CHNG_TM
            // 
            this.txtSTUD_CHNG_TM.Location = new System.Drawing.Point(111, 233);
            this.txtSTUD_CHNG_TM.Mask = "##:##:##";
            this.txtSTUD_CHNG_TM.Name = "txtSTUD_CHNG_TM";
            this.txtSTUD_CHNG_TM.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_CHNG_TM.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Change Time:";
            // 
            // txtSTUD_CHNG_DT
            // 
            this.txtSTUD_CHNG_DT.Location = new System.Drawing.Point(111, 207);
            this.txtSTUD_CHNG_DT.Mask = "0#/0#/####";
            this.txtSTUD_CHNG_DT.Name = "txtSTUD_CHNG_DT";
            this.txtSTUD_CHNG_DT.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_CHNG_DT.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Change Date:";
            // 
            // txtSTUD_DEL_FLG
            // 
            this.txtSTUD_DEL_FLG.Location = new System.Drawing.Point(145, 228);
            this.txtSTUD_DEL_FLG.MaxLength = 9;
            this.txtSTUD_DEL_FLG.Name = "txtSTUD_DEL_FLG";
            this.txtSTUD_DEL_FLG.Size = new System.Drawing.Size(24, 20);
            this.txtSTUD_DEL_FLG.TabIndex = 30;
            this.txtSTUD_DEL_FLG.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Delete Flag:";
            this.label9.Visible = false;
            // 
            // txtUSER_CHNG_ID
            // 
            this.txtUSER_CHNG_ID.Location = new System.Drawing.Point(146, 231);
            this.txtUSER_CHNG_ID.MaxLength = 8;
            this.txtUSER_CHNG_ID.Name = "txtUSER_CHNG_ID";
            this.txtUSER_CHNG_ID.Size = new System.Drawing.Size(99, 20);
            this.txtUSER_CHNG_ID.TabIndex = 32;
            this.txtUSER_CHNG_ID.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "User Change ID:";
            this.label14.Visible = false;
            // 
            // cmdList
            // 
            this.cmdList.Location = new System.Drawing.Point(126, 228);
            this.cmdList.Name = "cmdList";
            this.cmdList.Size = new System.Drawing.Size(75, 23);
            this.cmdList.TabIndex = 33;
            this.cmdList.Text = "List";
            this.cmdList.UseVisualStyleBackColor = true;
            this.cmdList.Visible = false;
            this.cmdList.Click += new System.EventHandler(this.cmdList_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(235, 178);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 34;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(122, 224);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 35;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Visible = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUndelete
            // 
            this.cmdUndelete.Location = new System.Drawing.Point(126, 229);
            this.cmdUndelete.Name = "cmdUndelete";
            this.cmdUndelete.Size = new System.Drawing.Size(75, 23);
            this.cmdUndelete.TabIndex = 36;
            this.cmdUndelete.Text = "Undelete";
            this.cmdUndelete.UseVisualStyleBackColor = true;
            this.cmdUndelete.Visible = false;
            this.cmdUndelete.Click += new System.EventHandler(this.cmdUndelete_Click);
            // 
            // cmdPurge
            // 
            this.cmdPurge.Location = new System.Drawing.Point(128, 235);
            this.cmdPurge.Name = "cmdPurge";
            this.cmdPurge.Size = new System.Drawing.Size(75, 23);
            this.cmdPurge.TabIndex = 37;
            this.cmdPurge.Text = "Purge";
            this.cmdPurge.UseVisualStyleBackColor = true;
            this.cmdPurge.Visible = false;
            this.cmdPurge.Click += new System.EventHandler(this.cmdPurge_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(103, 234);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(36, 20);
            this.txtMessage.TabIndex = 38;
            this.txtMessage.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Message:";
            this.label15.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSTUD_ID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSTUD_FIRST_NM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSTUD_LAST_NM);
            this.groupBox1.Controls.Add(this.cmdAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGPA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMAJOR_CD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSTUD_CHNG_TM);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmdInquire);
            this.groupBox1.Controls.Add(this.txtSTUD_ADD_DT);
            this.groupBox1.Controls.Add(this.txtSTUD_CHNG_DT);
            this.groupBox1.Controls.Add(this.cmdUpdate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 273);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emailTxt);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.integrateBtn);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmdProcess);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmdPurge);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmdUndelete);
            this.groupBox2.Controls.Add(this.txtUSER_ADD_ID);
            this.groupBox2.Controls.Add(this.cmdDelete);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmdList);
            this.groupBox2.Controls.Add(this.txtSTUD_ADD_TM);
            this.groupBox2.Controls.Add(this.txtUSER_CHNG_ID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSTUD_DEL_FLG);
            this.groupBox2.Location = new System.Drawing.Point(348, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 273);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Integration To WebService";
            // 
            // integrateBtn
            // 
            this.integrateBtn.Location = new System.Drawing.Point(17, 97);
            this.integrateBtn.Name = "integrateBtn";
            this.integrateBtn.Size = new System.Drawing.Size(293, 77);
            this.integrateBtn.TabIndex = 0;
            this.integrateBtn.Text = "INTEGRATE";
            this.integrateBtn.UseVisualStyleBackColor = true;
            this.integrateBtn.Click += new System.EventHandler(this.integrateBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Email:";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(47, 25);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.ReadOnly = true;
            this.emailTxt.Size = new System.Drawing.Size(263, 20);
            this.emailTxt.TabIndex = 41;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Integration Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdProcess;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTUD_ID;
        private System.Windows.Forms.Button cmdInquire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTUD_FIRST_NM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSTUD_LAST_NM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtGPA;
        private System.Windows.Forms.TextBox txtMAJOR_CD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUSER_ADD_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtSTUD_ADD_DT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtSTUD_ADD_TM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtSTUD_CHNG_TM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtSTUD_CHNG_DT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSTUD_DEL_FLG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUSER_CHNG_ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cmdList;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUndelete;
        private System.Windows.Forms.Button cmdPurge;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button integrateBtn;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label16;
    }
}

