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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form2();

            f3.Show();
            button1.Enabled = false;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f3 = new Form3();

            f3.Show();
            button1.Enabled = false;
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form f3 = new Form1();

            f3.Show();
            button1.Enabled = false;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton13.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton18.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton22.Checked == true)
            {
                points = points + 1;
            }
            label4.Text = "Количество набранных баллов: " + Convert.ToString(points);

        }
    }
}
