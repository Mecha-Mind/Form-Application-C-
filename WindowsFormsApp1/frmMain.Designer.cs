namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkbox = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.personEmail = new System.Windows.Forms.Label();
            this.personPhone = new System.Windows.Forms.Label();
            this.perosnAddress = new System.Windows.Forms.Label();
            this.perosnName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "";
            this.btnSubmit.BackColor = System.Drawing.Color.Purple;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(460, 394);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 44);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Press Me";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkbox
            // 
            this.chkbox.AutoSize = true;
            this.chkbox.BackColor = System.Drawing.Color.DimGray;
            this.chkbox.Location = new System.Drawing.Point(392, 338);
            this.chkbox.Margin = new System.Windows.Forms.Padding(6);
            this.chkbox.Name = "chkbox";
            this.chkbox.Size = new System.Drawing.Size(283, 28);
            this.chkbox.TabIndex = 1;
            this.chkbox.Text = "Swear You Are a human :X";
            this.chkbox.UseVisualStyleBackColor = false;
            this.chkbox.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Red;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(147, 332);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(109, 41);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accepted";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(399, 52);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 34);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtPersonName_TextChanged);
            // 
            // personEmail
            // 
            this.personEmail.AutoSize = true;
            this.personEmail.BackColor = System.Drawing.Color.DarkCyan;
            this.personEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personEmail.ForeColor = System.Drawing.Color.White;
            this.personEmail.Location = new System.Drawing.Point(143, 122);
            this.personEmail.Name = "personEmail";
            this.personEmail.Padding = new System.Windows.Forms.Padding(10);
            this.personEmail.Size = new System.Drawing.Size(165, 40);
            this.personEmail.TabIndex = 8;
            this.personEmail.Text = "Enter Your Email";
            this.personEmail.Click += new System.EventHandler(this.personEmail_Click);
            // 
            // personPhone
            // 
            this.personPhone.AutoSize = true;
            this.personPhone.BackColor = System.Drawing.Color.DarkCyan;
            this.personPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personPhone.ForeColor = System.Drawing.Color.White;
            this.personPhone.Location = new System.Drawing.Point(143, 195);
            this.personPhone.Name = "personPhone";
            this.personPhone.Padding = new System.Windows.Forms.Padding(10);
            this.personPhone.Size = new System.Drawing.Size(172, 40);
            this.personPhone.TabIndex = 9;
            this.personPhone.Text = "Enter Your Phone";
            this.personPhone.Click += new System.EventHandler(this.personPhone_Click);
            // 
            // perosnAddress
            // 
            this.perosnAddress.AutoSize = true;
            this.perosnAddress.BackColor = System.Drawing.Color.DarkCyan;
            this.perosnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perosnAddress.ForeColor = System.Drawing.Color.White;
            this.perosnAddress.Location = new System.Drawing.Point(143, 268);
            this.perosnAddress.Name = "perosnAddress";
            this.perosnAddress.Padding = new System.Windows.Forms.Padding(10);
            this.perosnAddress.Size = new System.Drawing.Size(187, 40);
            this.perosnAddress.TabIndex = 10;
            this.perosnAddress.Text = "Enter Your Address";
            this.perosnAddress.Click += new System.EventHandler(this.perosnAddress_Click);
            // 
            // perosnName
            // 
            this.perosnName.AutoSize = true;
            this.perosnName.BackColor = System.Drawing.Color.DarkCyan;
            this.perosnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perosnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perosnName.Location = new System.Drawing.Point(147, 52);
            this.perosnName.Name = "perosnName";
            this.perosnName.Padding = new System.Windows.Forms.Padding(10);
            this.perosnName.Size = new System.Drawing.Size(169, 42);
            this.perosnName.TabIndex = 7;
            this.perosnName.Text = "Enter Your Name";
            this.perosnName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.perosnName.Click += new System.EventHandler(this.perosnName_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(399, 122);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 34);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(399, 195);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(276, 34);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(399, 268);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(276, 34);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(392, 385);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(10);
            this.lblText.Size = new System.Drawing.Size(20, 51);
            this.lblText.TabIndex = 11;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(12, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10);
            this.btnExit.Size = new System.Drawing.Size(41, 55);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEmailError
            // 
            this.lblEmailError.AccessibleName = "";
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Location = new System.Drawing.Point(675, 95);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmailError.Size = new System.Drawing.Size(0, 24);
            this.lblEmailError.TabIndex = 13;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Location = new System.Drawing.Point(675, 174);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(0, 24);
            this.lblPhoneError.TabIndex = 13;
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Location = new System.Drawing.Point(675, 247);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(0, 24);
            this.lblAddressError.TabIndex = 13;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Location = new System.Drawing.Point(671, 25);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 24);
            this.lblNameError.TabIndex = 14;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.perosnAddress);
            this.Controls.Add(this.personPhone);
            this.Controls.Add(this.personEmail);
            this.Controls.Add(this.perosnName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.chkbox);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "First App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Move += new System.EventHandler(this.frmMain_Move);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkbox;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label personEmail;
        private System.Windows.Forms.Label personPhone;
        private System.Windows.Forms.Label perosnAddress;
        private System.Windows.Forms.Label perosnName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

