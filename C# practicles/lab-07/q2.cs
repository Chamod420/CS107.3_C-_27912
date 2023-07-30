using System;
using System.Windows.Forms;

namespace SignupFormApp
{
    public partial class Form1 : Form
    {
        private User newUser = new User();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (AreFieldsValid())
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    newUser.FirstName = txtFirstName.Text;
                    newUser.LastName = txtLastName.Text;
                    newUser.DateOfBirth = dateTimePickerDOB.Value;
                    newUser.Email = txtEmail.Text;
                    newUser.Username = txtUsername.Text;
                    newUser.Password = txtPassword.Text;

                    SecondForm secondForm = new SecondForm(newUser);
                    secondForm.Show();

                    this.Hide(); // Hide the current form
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password do not match. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields with valid values.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private bool AreFieldsValid()
        {
            // Check if all fields are filled with values
            return !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                   !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                   !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                   !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                   !string.IsNullOrWhiteSpace(txtConfirmPassword.Text);
        }

        private void ResetFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dateTimePickerDOB.Value = DateTime.Now;
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
