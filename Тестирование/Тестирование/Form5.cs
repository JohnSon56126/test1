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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            label1.Text = "Это Тест. Пройди его" +
                    "\nДля этого нужно выбрать 1 вариант ответа." +
                    "\nПриложение создано студентом группы ИС-21" +
                    "\n\nСоздатель - Поляков Евгений";
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
