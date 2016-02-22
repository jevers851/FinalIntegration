namespace TXSeries_DUP001
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(913, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cmdProcess
            // 
            this.cmdProcess.Location = new System.Drawing.Point(850, 375);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(75, 23);
            this.cmdProcess.TabIndex = 1;
            this.cmdProcess.Text = "Process";
            this.cmdProcess.UseVisualStyleBackColor = true;
            this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(851, 164);
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
            this.label1.Location = new System.Drawing.Point(13, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raw Data (commarea):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // txtSTUD_ID
            // 
            this.txtSTUD_ID.Location = new System.Drawing.Point(105, 40);
            this.txtSTUD_ID.MaxLength = 9;
            this.txtSTUD_ID.Name = "txtSTUD_ID";
            this.txtSTUD_ID.Size = new System.Drawing.Size(99, 20);
            this.txtSTUD_ID.TabIndex = 5;
            // 
            // cmdInquire
            // 
            this.cmdInquire.Location = new System.Drawing.Point(851, 135);
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
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name:";
            // 
            // txtSTUD_FIRST_NM
            // 
            this.txtSTUD_FIRST_NM.Location = new System.Drawing.Point(105, 66);
            this.txtSTUD_FIRST_NM.MaxLength = 20;
            this.txtSTUD_FIRST_NM.Name = "txtSTUD_FIRST_NM";
            this.txtSTUD_FIRST_NM.Size = new System.Drawing.Size(155, 20);
            this.txtSTUD_FIRST_NM.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name:";
            // 
            // txtSTUD_LAST_NM
            // 
            this.txtSTUD_LAST_NM.Location = new System.Drawing.Point(105, 92);
            this.txtSTUD_LAST_NM.MaxLength = 25;
            this.txtSTUD_LAST_NM.Name = "txtSTUD_LAST_NM";
            this.txtSTUD_LAST_NM.Size = new System.Drawing.Size(199, 20);
            this.txtSTUD_LAST_NM.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "GPA:";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(105, 118);
            this.txtGPA.Mask = "0.00";
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(40, 20);
            this.txtGPA.TabIndex = 12;
            // 
            // txtMAJOR_CD
            // 
            this.txtMAJOR_CD.Location = new System.Drawing.Point(105, 144);
            this.txtMAJOR_CD.MaxLength = 5;
            this.txtMAJOR_CD.Name = "txtMAJOR_CD";
            this.txtMAJOR_CD.Size = new System.Drawing.Size(57, 20);
            this.txtMAJOR_CD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Major:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(105, 170);
            this.txtDOB.Mask = "0#/0#/####";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(155, 20);
            this.txtDOB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "DOB:";
            // 
            // txtUSER_ADD_ID
            // 
            this.txtUSER_ADD_ID.Location = new System.Drawing.Point(105, 196);
            this.txtUSER_ADD_ID.MaxLength = 8;
            this.txtUSER_ADD_ID.Name = "txtUSER_ADD_ID";
            this.txtUSER_ADD_ID.Size = new System.Drawing.Size(99, 20);
            this.txtUSER_ADD_ID.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "User Add ID:";
            // 
            // txtSTUD_ADD_DT
            // 
            this.txtSTUD_ADD_DT.Location = new System.Drawing.Point(105, 222);
            this.txtSTUD_ADD_DT.Mask = "0#/0#/####";
            this.txtSTUD_ADD_DT.Name = "txtSTUD_ADD_DT";
            this.txtSTUD_ADD_DT.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_ADD_DT.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Add Date:";
            // 
            // txtSTUD_ADD_TM
            // 
            this.txtSTUD_ADD_TM.Location = new System.Drawing.Point(105, 248);
            this.txtSTUD_ADD_TM.Mask = "##:##:##";
            this.txtSTUD_ADD_TM.Name = "txtSTUD_ADD_TM";
            this.txtSTUD_ADD_TM.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_ADD_TM.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Add Time:";
            // 
            // txtSTUD_CHNG_TM
            // 
            this.txtSTUD_CHNG_TM.Location = new System.Drawing.Point(106, 325);
            this.txtSTUD_CHNG_TM.Mask = "##:##:##";
            this.txtSTUD_CHNG_TM.Name = "txtSTUD_CHNG_TM";
            this.txtSTUD_CHNG_TM.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_CHNG_TM.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Change Time:";
            // 
            // txtSTUD_CHNG_DT
            // 
            this.txtSTUD_CHNG_DT.Location = new System.Drawing.Point(106, 299);
            this.txtSTUD_CHNG_DT.Mask = "0#/0#/####";
            this.txtSTUD_CHNG_DT.Name = "txtSTUD_CHNG_DT";
            this.txtSTUD_CHNG_DT.Size = new System.Drawing.Size(72, 20);
            this.txtSTUD_CHNG_DT.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Change Date:";
            // 
            // txtSTUD_DEL_FLG
            // 
            this.txtSTUD_DEL_FLG.Location = new System.Drawing.Point(106, 351);
            this.txtSTUD_DEL_FLG.MaxLength = 9;
            this.txtSTUD_DEL_FLG.Name = "txtSTUD_DEL_FLG";
            this.txtSTUD_DEL_FLG.Size = new System.Drawing.Size(24, 20);
            this.txtSTUD_DEL_FLG.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Delete Flag:";
            // 
            // txtUSER_CHNG_ID
            // 
            this.txtUSER_CHNG_ID.Location = new System.Drawing.Point(105, 274);
            this.txtUSER_CHNG_ID.MaxLength = 8;
            this.txtUSER_CHNG_ID.Name = "txtUSER_CHNG_ID";
            this.txtUSER_CHNG_ID.Size = new System.Drawing.Size(99, 20);
            this.txtUSER_CHNG_ID.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "User Change ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 436);
            this.Controls.Add(this.txtUSER_CHNG_ID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSTUD_DEL_FLG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSTUD_CHNG_TM);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSTUD_CHNG_DT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSTUD_ADD_TM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSTUD_ADD_DT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUSER_ADD_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMAJOR_CD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSTUD_LAST_NM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSTUD_FIRST_NM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdInquire);
            this.Controls.Add(this.txtSTUD_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdProcess);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

