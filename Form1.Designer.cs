namespace project1csc323
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
            this.button2 = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btnsignin = new System.Windows.Forms.Button();
            this.gbsignup = new System.Windows.Forms.GroupBox();
            this.tbcreditcardinfo = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.tbpasswordsignup = new System.Windows.Forms.TextBox();
            this.lblcreditcard = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.tbemailsignup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gblogin = new System.Windows.Forms.GroupBox();
            this.gbsignup.SuspendLayout();
            this.gblogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(2, 81);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "email";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(6, 145);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(52, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "password";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(88, 74);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(158, 20);
            this.tbemail.TabIndex = 4;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(88, 138);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(158, 20);
            this.tbpassword.TabIndex = 5;
            // 
            // btnsignin
            // 
            this.btnsignin.Location = new System.Drawing.Point(200, 288);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(75, 23);
            this.btnsignin.TabIndex = 7;
            this.btnsignin.Text = "sign in";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // gbsignup
            // 
            this.gbsignup.Controls.Add(this.tbcreditcardinfo);
            this.gbsignup.Controls.Add(this.tbaddress);
            this.gbsignup.Controls.Add(this.tblastname);
            this.gbsignup.Controls.Add(this.tbfirstname);
            this.gbsignup.Controls.Add(this.tbpasswordsignup);
            this.gbsignup.Controls.Add(this.lblcreditcard);
            this.gbsignup.Controls.Add(this.lbladdress);
            this.gbsignup.Controls.Add(this.lbllastname);
            this.gbsignup.Controls.Add(this.lblfirstname);
            this.gbsignup.Controls.Add(this.label2);
            this.gbsignup.Controls.Add(this.btnsignup);
            this.gbsignup.Controls.Add(this.tbemailsignup);
            this.gbsignup.Controls.Add(this.label1);
            this.gbsignup.Location = new System.Drawing.Point(297, 28);
            this.gbsignup.Name = "gbsignup";
            this.gbsignup.Size = new System.Drawing.Size(270, 311);
            this.gbsignup.TabIndex = 8;
            this.gbsignup.TabStop = false;
            this.gbsignup.Text = "sign up";
            this.gbsignup.Visible = false;
            // 
            // tbcreditcardinfo
            // 
            this.tbcreditcardinfo.Location = new System.Drawing.Point(99, 249);
            this.tbcreditcardinfo.Name = "tbcreditcardinfo";
            this.tbcreditcardinfo.Size = new System.Drawing.Size(141, 20);
            this.tbcreditcardinfo.TabIndex = 12;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(99, 213);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(141, 20);
            this.tbaddress.TabIndex = 11;
            // 
            // tblastname
            // 
            this.tblastname.Location = new System.Drawing.Point(99, 169);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(141, 20);
            this.tblastname.TabIndex = 10;
            // 
            // tbfirstname
            // 
            this.tbfirstname.Location = new System.Drawing.Point(99, 125);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(141, 20);
            this.tbfirstname.TabIndex = 9;
            // 
            // tbpasswordsignup
            // 
            this.tbpasswordsignup.Location = new System.Drawing.Point(99, 81);
            this.tbpasswordsignup.Name = "tbpasswordsignup";
            this.tbpasswordsignup.Size = new System.Drawing.Size(141, 20);
            this.tbpasswordsignup.TabIndex = 8;
            // 
            // lblcreditcard
            // 
            this.lblcreditcard.AutoSize = true;
            this.lblcreditcard.Location = new System.Drawing.Point(-3, 252);
            this.lblcreditcard.Name = "lblcreditcard";
            this.lblcreditcard.Size = new System.Drawing.Size(77, 13);
            this.lblcreditcard.TabIndex = 7;
            this.lblcreditcard.Text = "credit card info";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(7, 213);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(44, 13);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Text = "address";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(7, 169);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(52, 13);
            this.lbllastname.TabIndex = 5;
            this.lbllastname.Text = "last name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(7, 128);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(49, 13);
            this.lblfirstname.TabIndex = 4;
            this.lblfirstname.Text = "firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(165, 287);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 2;
            this.btnsignup.Text = "sign up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // tbemailsignup
            // 
            this.tbemailsignup.Location = new System.Drawing.Point(99, 32);
            this.tbemailsignup.Name = "tbemailsignup";
            this.tbemailsignup.Size = new System.Drawing.Size(141, 20);
            this.tbemailsignup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "email";
            // 
            // gblogin
            // 
            this.gblogin.Controls.Add(this.btnsignin);
            this.gblogin.Controls.Add(this.tbpassword);
            this.gblogin.Controls.Add(this.lblpassword);
            this.gblogin.Controls.Add(this.lblemail);
            this.gblogin.Controls.Add(this.tbemail);
            this.gblogin.Location = new System.Drawing.Point(10, 28);
            this.gblogin.Name = "gblogin";
            this.gblogin.Size = new System.Drawing.Size(281, 310);
            this.gblogin.TabIndex = 9;
            this.gblogin.TabStop = false;
            this.gblogin.Text = "login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.gblogin);
            this.Controls.Add(this.gbsignup);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "login/signup UI";
            this.gbsignup.ResumeLayout(false);
            this.gbsignup.PerformLayout();
            this.gblogin.ResumeLayout(false);
            this.gblogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.GroupBox gbsignup;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.TextBox tbemailsignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcreditcardinfo;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.TextBox tbfirstname;
        private System.Windows.Forms.TextBox tbpasswordsignup;
        private System.Windows.Forms.Label lblcreditcard;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gblogin;
    }
}

