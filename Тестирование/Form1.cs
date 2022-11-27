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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(); 
        }
        Form2 form2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form f3 = new Form2();

                f3.Show();
                button1.Enabled = false;
                this.Visible = false;


            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton3.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton6.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton10.Checked == true)
            {
                points = points + 1;
            }
            
        }

        
    }
}
