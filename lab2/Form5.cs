using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            Text = "Mushroom Identifier";
            ClientSize = new System.Drawing.Size(450, 320);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = System.Drawing.Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Font = new System.Drawing.Font("Segoe UI", 10F);

            Label title = new Label
            {
                Text = "Mushroom Identifier",
                Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.ForestGreen,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, 25),
                Size = new System.Drawing.Size(450, 40)
            };

            Label instruction = new Label
            {
                Text = "Answer the questions to identify the mushroom.",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(25, 80),
                Size = new System.Drawing.Size(400, 30)
            };

            Button btnStart = new Button
            {
                Text = "Start Guessing",
                Location = new System.Drawing.Point(145, 125),
                Size = new System.Drawing.Size(160, 45),
                BackColor = System.Drawing.Color.ForestGreen,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnStart.Click += BtnStart_Click;

            Button btnBack = new Button
            {
                Text = "Back",
                Location = new System.Drawing.Point(110, 220),
                Size = new System.Drawing.Size(100, 38),
                FlatStyle = FlatStyle.Flat
            };
            btnBack.Click += BtnBack_Click;

            Button btnLogout = new Button
            {
                Text = "Logout",
                Location = new System.Drawing.Point(235, 220),
                Size = new System.Drawing.Size(100, 38),
                FlatStyle = FlatStyle.Flat
            };
            btnLogout.Click += BtnLogout_Click;

            Controls.AddRange(new Control[] { title, instruction, btnStart, btnBack, btnLogout });
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            DialogResult ans1 = MessageBox.Show("Does your mushroom have gills?", "Question 1", MessageBoxButtons.YesNo);
            if (ans1 == DialogResult.No)
            {
                MessageBox.Show("Your mushroom is: Cepe de bordeaux", "Result");
                return;
            }

            DialogResult ans2 = MessageBox.Show("Does your mushroom have a ring?", "Question 2", MessageBoxButtons.YesNo);
            if (ans2 == DialogResult.Yes)
            {
                DialogResult ans3 = MessageBox.Show("Does it grow in a forest?", "Question 3", MessageBoxButtons.YesNo);
                if (ans3 == DialogResult.Yes) MessageBox.Show("Your mushroom is: Amonite tue-mouche", "Result");
                else
                {
                    DialogResult ans4 = MessageBox.Show("Does it have a convex cup?", "Question 4", MessageBoxButtons.YesNo);
                    if (ans4 == DialogResult.Yes) MessageBox.Show("Your mushroom is: Agaric Jaunissant", "Result");
                    else MessageBox.Show("Your mushroom is: Coprin chevelu", "Result");
                }
            }
            else
            {
                DialogResult ans3 = MessageBox.Show("Does it have a convex cup?", "Question 3", MessageBoxButtons.YesNo);
                if (ans3 == DialogResult.Yes) MessageBox.Show("Your mushroom is: Pied bleu", "Result");
                else MessageBox.Show("Your mushroom is: Girolle", "Result");
            }
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