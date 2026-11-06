using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Text = "Bicycle and Mushroom Rental";
            ClientSize = new System.Drawing.Size(430, 300);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = System.Drawing.Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Font = new System.Drawing.Font("Segoe UI", 10F);

            Label title = new Label
            {
                Text = "Welcome",
                Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Navy,
                AutoSize = true,
                Location = new System.Drawing.Point(160, 25)
            };

            Label usernameLabel = new Label
            {
                Text = "Username:",
                AutoSize = true,
                Location = new System.Drawing.Point(75, 90)
            };

            TextBox usernameTextBox = new TextBox
            {
                Name = "txtUsername",
                Location = new System.Drawing.Point(170, 86),
                Width = 180
            };

            Label passwordLabel = new Label
            {
                Text = "Password:",
                AutoSize = true,
                Location = new System.Drawing.Point(75, 130)
            };

            TextBox passwordTextBox = new TextBox
            {
                Name = "txtPassword",
                Location = new System.Drawing.Point(170, 126),
                Width = 180,
                UseSystemPasswordChar = true
            };

            Button loginButton = new Button
            {
                Text = "Login",
                Location = new System.Drawing.Point(110, 190),
                Size = new System.Drawing.Size(100, 38),
                BackColor = System.Drawing.Color.RoyalBlue,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            loginButton.Click += (sender, e) => Login(usernameTextBox.Text, passwordTextBox.Text);

            Button closeButton = new Button
            {
                Text = "Close",
                Location = new System.Drawing.Point(225, 190),
                Size = new System.Drawing.Size(100, 38),
                FlatStyle = FlatStyle.Flat
            };
            closeButton.Click += BtnClose_Click;

            Controls.AddRange(new Control[]
            {
                title, usernameLabel, usernameTextBox, passwordLabel,
                passwordTextBox, loginButton, closeButton
            });
        }

        private void Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty!", "Error");
                return;
            }

            bool containsLetter = false;
            foreach (char character in username)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    MessageBox.Show("Username can contain only letters and numbers.", "Invalid username");
                    return;
                }

                if (char.IsLetter(character))
                {
                    containsLetter = true;
                }
            }

            if (!containsLetter)
            {
                MessageBox.Show("Username must contain at least one letter.", "Invalid username");
                return;
            }

            ChooseForm choose = new ChooseForm();
            choose.Show();
            Hide();
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {

        }
    }
}