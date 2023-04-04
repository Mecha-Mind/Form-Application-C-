using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        //private void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    string personName = txtName.Text;

        //    if (String.IsNullOrEmpty(personName) || !Regex.IsMatch(personName, @"^[a-zA-Z\s]+$"))
        //    {
        //        return;
        //    } else
        //    {
        //        lblText.Text = "Hello " + personName + "\nWelcome In TheRiver";
        //        txtName.BackColor = Color.Red;
        //        lblText.ForeColor = Color.Red;
        //        MessageBox.Show("Submited");
        //    }
        //    //txtName.ReadOnly = true;
        //    btnAccept.Visible = true;
        //    btnSubmit.Visible = false;
        //}
        /// <summary>
        /// This is An update method submit button with full validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            // All inputs are valid, so proceed with submission
            string personName = txtName.Text;

            lblText.Text = "Hello " + personName + "\nWelcome In TheRiver";
            txtName.BackColor = Color.Red;
            lblText.ForeColor = Color.Red;
            MessageBox.Show("Submitted");

            // Disable form inputs and show accept button
            DisableInputs();
            btnAccept.Visible = true;
            btnSubmit.Visible = false;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            // Validate name input
            if (String.IsNullOrEmpty(txtName.Text) || !Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
            {
                SetError(txtName, "Please enter a valid name (letters and spaces only)");
                isValid = false;
            }
            else
            {
                ClearError(txtName);
            }

            // Validate email input
            if (String.IsNullOrEmpty(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                SetError(txtEmail, "Please enter a valid email address");
                isValid = false;
            }
            else
            {
                ClearError(txtEmail);
            }

            // Validate phone input
            if (String.IsNullOrEmpty(txtPhone.Text) || !Regex.IsMatch(txtPhone.Text, @"^[0-9]{10}$"))
            {
                SetError(txtPhone, "Please enter a valid 10-digit phone number");
                isValid = false;
            }
            else
            {
                ClearError(txtPhone);
            }

            // Validate address input
            if (String.IsNullOrEmpty(txtAddress.Text) || !Regex.IsMatch(txtAddress.Text, @"^[a-zA-Z0-9\s,'-]*$"))
            {
                SetError(txtAddress, "Please enter a valid address (letters, numbers, spaces, commas, apostrophes, and hyphens only)");
                isValid = false;
            }
            else
            {
                ClearError(txtAddress);
            }

            return isValid;
        }


        private void SetError(Control control, string message)
        {
            errorProvider.SetError(control, message);
            control.BackColor = Color.LightPink;
        }

        private void ClearError(Control control)
        {
            errorProvider.SetError(control, "");
            control.BackColor = SystemColors.Window;
        }

        private void DisableInputs()
        {
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAddress.ReadOnly = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("What Are You Doing Here!!");

            this.Size = new Size(900,500);
            this.StartPosition = FormStartPosition.Manual;
            int x=340, y=40;
            lblNameError.Location= new Point(x-15, y-30);
            txtName.Location = new Point(x, y);

            lblEmailError.Location = new Point(x - 15, (y*3) - 30);
            txtEmail.Location = new Point(x, (y * 3));

            lblPhoneError.Location = new Point(x - 15, (y * 5) - 30);
            txtPhone.Location = new Point(x, (y * 5));

            lblAddressError.Location = new Point(x - 15, (y * 7) - 30);
            txtAddress.Location = new Point(x, (y * 7));

            int z = 240;
            perosnName.Location = new Point((x - z), y - 2);
            personEmail.Location = new Point((x - z), (y * 3 - 2));
            personPhone.Location = new Point((x - z), (y*5 - 2));
            perosnAddress.Location = new Point((x - z), (y*7 - 2));


            chkbox.Location = new Point(x, (y * 8)+15);


            btnExit.Location = new Point(10, 390);

        }
        /// <summary>
        /// This Method On A button with name accepted make a transfare to the second form when clicked and hide the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accepted");
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }


        /// <summary>
        /// ValidateInput
        /// </summary>
        //private void ValidateInput(Control control, string pattern)
        //{
        //    if (!Regex.IsMatch(control.Text, pattern))
        //    {
        //        MessageBox.Show("Invalid input");
        //        control.Focus();
        //        if (control is TextBox textBox)
        //        {
        //            textBox.SelectAll();
        //        }
        //    }
        //}

        /// The Next Method an update of this one.
        /// <summary>
        /// ValidateInput
        /*
            The ValidateInput method is a generic method that validates the input of a Control object using a regular expression pattern.
            It takes two parameters: sender, which is the control that raised the event,
            and pattern, which is a string containing the regular expression pattern to match against the control's text.

            The method first casts the sender parameter to a Control object and retrieves the compiled regular expression pattern from a cache.
            If the pattern is not found in the cache, the method compiles the pattern using the RegexOptions.Compiled option and adds it to the cache.

            The method then uses the regular expression pattern to test the control's text.
            If the text does not match the pattern, the method displays an error message box, sets the focus to the control,
            and selects all the text in the control (if it is a TextBox).

            By caching the compiled regular expression patterns, 
            the ValidateInput method can improve the performance of regular expression matching and avoid unnecessary recompilation of the same pattern.
            The method can be used with any control that raises a TextChanged event, making it a reusable and generic solution for input validation.
         */
        /// </summary>
        /// 
        ///
        /*
            This method takes a Control object as a parameter and returns the label control that is associated with it.
            The method assumes that the label is the previous sibling control of the textbox, but you can modify it to fit your specific layout.
         */
        //private Label GetLabelForControl(Control control)
        //{
        //    // Assumes that the label is the control with the same name as the textbox, followed by "Error".
        //    var labelName = "lbl" + control.Name.Substring(3) + "Error";
        //    var label = control.Parent.Controls[labelName] as Label;
        //    if (label != null)
        //    {
        //        return label;
        //    }
        //    throw new InvalidOperationException("Label not found for control.");
        //}


        private static readonly Dictionary<string, Regex> regexCache = new Dictionary<string, Regex>();

        private void ValidateInput(string input, string pattern, Label errorLabel)
        {
            if (!regexCache.TryGetValue(pattern, out var regex))
            {
                regex = new Regex(pattern, RegexOptions.Compiled);
                regexCache[pattern] = regex;
            }
            if (!regex.IsMatch(input))
            {
                errorLabel.Text = "Invalid input";
                errorLabel.ForeColor = Color.Red;
            }
            else
            {
                errorLabel.Text = "Valid";
                errorLabel.ForeColor = Color.GreenYellow;
            }
        }







        /// <summary>
        /// PersonName:
        /// The following regex pattern matches a PersonName in the format Only words and spaces:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPersonName_TextChanged(object sender, EventArgs e)
        {
            // Validate person name before submit
            string userName = txtName.Text;
            ValidateInput(userName, @"^[a-zA-Z\s]+$", lblNameError);
            //if (!Regex.IsMatch(userName, @"^[a-zA-Z\s]+$"))
            //{
            //    lblNameError.Text = "Please enter a valid name";
            //    lblNameError.ForeColor = Color.Red;
            //    return;
            //}
            //else
            //{
            //    lblNameError.Text = "Valid";
            //    lblNameError.ForeColor = Color.GreenYellow;
            //}



            //lblNameError.RightToLeft = RightToLeft.Yes;
            //lblNameError.TextAlign = ContentAlignment.MiddleRight;
        }
        /// <summary>
        /// Email:
        /// The following regex pattern matches a Email in the format email@words.words must be only one @:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            ValidateInput(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", lblEmailError);
            //if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            //{
            //    lblEmailError.Text = "Please enter a valid email";
            //    lblEmailError.ForeColor = Color.Red;
            //    return;
            //}else
            //{
            //    lblEmailError.Text = "Valid";
            //    lblEmailError.ForeColor = Color.GreenYellow;
            //}
        }
        /// <summary>
        /// Phone number:
        /// The following regex pattern matches a US phone number in the format(123) 456-7890 or 123-456-7890 or 1234567890:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            ValidateInput(phone, @"^\(?\d{3}\)?[\s-]?\d{3}[\s-]?\d{4}$", lblPhoneError);
            //if (!Regex.IsMatch(phone, @"^\(?\d{3}\)?[\s-]?\d{3}[\s-]?\d{4}$"))
            //{
            //    lblPhoneError.Text = "Please enter a valid phone number";
            //    lblPhoneError.ForeColor = Color.Red;
            //    return;
            //}
            //else
            //{
            //    lblPhoneError.Text = "Valid";
            //    lblPhoneError.ForeColor = Color.GreenYellow;
            //}
        }
        /// <summary>
        /// Address:
        /// The following regex pattern matches a US address in the format 123 Main St, Anytown, CA 90210:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string address = txtAddress.Text;
            ValidateInput(address, @"^(\d+)\s+([a-zA-Z]+\s[a-zA-Z.]+)\s*,\s*([a-zA-Z]+)\s*,\s*([A-Z]{2})\s+(\d{5})(-\d{4})?$", lblAddressError);
            //if (!Regex.IsMatch(address, @"^(\d+)\s+([a-zA-Z]+\s[a-zA-Z.]+)\s*,\s*([a-zA-Z]+)\s*,\s*([A-Z]{2})\s+(\d{5})(-\d{4})?$"))
            //{
            //    lblAddressError.Text = "Please enter a valid address";
            //    lblAddressError.ForeColor = Color.Red;
            //    return;
            //}
            //else
            //{
            //    lblAddressError.Text = "Valid";
            //    lblAddressError.ForeColor = Color.GreenYellow;
            //}
        }



        private void setForm()
        {

            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }


        private void frmMain_Resize(object sender, EventArgs e)
        {
            setForm();
        }
        private void frmMain_Move(object sender, EventArgs e)
        {
            setForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void lblPhone_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void perosnName_Click(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void personEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void personPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Focus();
        }

        private void perosnAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
