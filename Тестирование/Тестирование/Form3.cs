using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестирование
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form4();

            f3.Show();
            button1.Enabled = false;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                DialogResult result = MessageBox.Show("Вы уверенны. что хотите закончить тестирование?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form2();

            f3.Show();
            button1.Enabled = false;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton26.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton32.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton33.Checked == true)
            {
                points = points + 1;
            }
            label4.Text = "Количество набранных баллов: " + Convert.ToString(points);

        }
    }
}
