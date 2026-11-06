using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class BicycleForm : Form
    {
        TextBox txtStart = new TextBox();
        TextBox txtEnd = new TextBox();
        TextBox txtTotal = new TextBox();

        public BicycleForm()
        {
            Text = "Bicycle Rental";
            ClientSize = new System.Drawing.Size(450, 400);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = System.Drawing.Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Font = new System.Drawing.Font("Segoe UI", 10F);

            Label title = new Label
            {
                Text = "Bicycle Rental",
                Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Navy,
                AutoSize = true,
                Location = new System.Drawing.Point(145, 25)
            };

            Label rateInfo = new Label
            {
                Text = "Price per hour:\r\n" +
                       "00-07 and 21-24: 500 RWF\r\n" +
                       "07-14 and 19-21: 1,000 RWF\r\n" +
                       "14-19: 1,500 RWF",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(25, 65),
                Size = new System.Drawing.Size(400, 75)
            };

            Label startLabel = new Label { Text = "Start time (0-23):", AutoSize = true, Location = new System.Drawing.Point(65, 160) };
            txtStart.Location = new System.Drawing.Point(215, 156);
            txtStart.Width = 150;

            Label endLabel = new Label { Text = "End time (1-24):", AutoSize = true, Location = new System.Drawing.Point(65, 200) };
            txtEnd.Location = new System.Drawing.Point(215, 196);
            txtEnd.Width = 150;

            Label totalLabel = new Label { Text = "Total:", AutoSize = true, Location = new System.Drawing.Point(65, 240) };
            txtTotal.Location = new System.Drawing.Point(215, 236);
            txtTotal.Width = 150;
            txtTotal.ReadOnly = true;
            txtTotal.BackColor = System.Drawing.Color.White;

            Button btnCalc = new Button
            {
                Text = "Calculate",
                Location = new System.Drawing.Point(65, 295),
                Size = new System.Drawing.Size(105, 38),
                BackColor = System.Drawing.Color.RoyalBlue,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnCalc.Click += BtnCalc_Click;

            Button btnBack = new Button
            {
                Text = "Back",
                Location = new System.Drawing.Point(180, 295),
                Size = new System.Drawing.Size(90, 38),
                FlatStyle = FlatStyle.Flat
            };
            btnBack.Click += BtnBack_Click;

            Button btnLogout = new Button
            {
                Text = "Logout",
                Location = new System.Drawing.Point(280, 295),
                Size = new System.Drawing.Size(90, 38),
                FlatStyle = FlatStyle.Flat
            };
            btnLogout.Click += BtnLogout_Click;

            Controls.AddRange(new Control[]
            {
                title, rateInfo, startLabel, txtStart, endLabel, txtEnd,
                totalLabel, txtTotal, btnCalc, btnBack, btnLogout
            });
        }

        private void BtnCalc_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtStart.Text, out int start))
            {
                MessageBox.Show("Enter a whole number for the start time, from 0 to 23.", "Invalid start time");
                return;
            }

            if (start < 0 || start > 23)
            {
                MessageBox.Show("The start time must be between 0 and 23.", "Invalid start time");
                return;
            }

            if (!int.TryParse(txtEnd.Text, out int end))
            {
                MessageBox.Show("Enter a whole number for the end time, from 1 to 24.", "Invalid end time");
                return;
            }

            if (end < 1 || end > 24)
            {
                MessageBox.Show("The end time must be between 1 and 24.", "Invalid end time");
                return;
            }

            if (end <= start)
            {
                MessageBox.Show("The end time must be later than the start time.", "Invalid time range");
                return;
            }

            int total = 0;
            for (int i = start; i < end; i++)
            {
                if ((i >= 0 && i < 7) || (i >= 21 && i < 24)) total += 500;
                else if ((i >= 7 && i < 14) || (i >= 19 && i < 21)) total += 1000;
                else if (i >= 14 && i < 19) total += 1500;
            }
            txtTotal.Text = total.ToString() + " RWF";
        }

        private void BtnBack_Click(object? sender, EventArgs e)
        {
            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Close();
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}