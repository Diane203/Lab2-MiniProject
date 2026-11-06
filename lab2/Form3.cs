using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            Text = "Choose Activity";
            ClientSize = new System.Drawing.Size(430, 320);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = System.Drawing.Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Font = new System.Drawing.Font("Segoe UI", 10F);

            Label title = new Label
            {
                Text = "Choose an activity",
                Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Navy,
                AutoSize = true,
                Location = new System.Drawing.Point(115, 35)
            };

            Button btnBike = new Button
            {
                Text = "Bicycle Rental",
                Location = new System.Drawing.Point(55, 105),
                Size = new System.Drawing.Size(145, 55),
                BackColor = System.Drawing.Color.RoyalBlue,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnBike.Click += BtnBike_Click;

            Button btnMush = new Button
            {
                Text = "Mushroom",
                Location = new System.Drawing.Point(230, 105),
                Size = new System.Drawing.Size(145, 55),
                BackColor = System.Drawing.Color.ForestGreen,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnMush.Click += BtnMush_Click;

            Button btnBack = new Button
            {
                Text = "Back to Login",
                Location = new System.Drawing.Point(75, 215),
                Size = new System.Drawing.Size(125, 38),
                FlatStyle = FlatStyle.Flat
            };
            btnBack.Click += BtnBack_Click;

            Button btnClose = new Button
            {
                Text = "Close",
                Location = new System.Drawing.Point(230, 215),
                Size = new System.Drawing.Size(125, 38),
                FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += BtnClose_Click;

            Controls.AddRange(new Control[] { title, btnBike, btnMush, btnBack, btnClose });
        }

        private void BtnBike_Click(object? sender, EventArgs e)
        {
            BicycleForm bike = new BicycleForm();
            bike.Show();
            this.Hide();
        }

        private void BtnMush_Click(object? sender, EventArgs e)
        {
            MushroomForm mush = new MushroomForm();
            mush.Show();
            this.Hide();
        }

        private void BtnBack_Click(object? sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Close();
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Do you want to close the application?",
                "Close application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}