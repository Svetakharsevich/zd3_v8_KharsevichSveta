using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        Qp a;
        Qp b;
        public Form1()
        {
            InitializeComponent();
            a = new Qp(listBox1);
            b=new Qp(listBox2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox5.Text != "")
            {
                a.Remove(textBox5.Text);
                b.Remove2(textBox5.Text);
                listBox1.Items.Clear(); 
                listBox2.Items.Clear();
                a.GetList();
                b.GetList2();
            }
            else
            {
                MessageBox.Show("Номер не был веден","Ошибка");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
                return;
            }
            try
            {
                a.Id = Convert.ToInt32(textBox1.Text); a.Mileage = double.Parse(textBox2.Text); a.Expenditure = double.Parse(textBox3.Text); a.P = int.Parse(textBox4.Text);
                b.Id = Convert.ToInt32(textBox1.Text); b.Mileage = double.Parse(textBox2.Text); b.Expenditure = double.Parse(textBox3.Text); b.P=int.Parse(textBox4.Text) ;
                if (a.Sc == true && textBox1.Text != "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    a.Add();
                    b.AddList2();
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    a.GetList();
                    b.GetList2();
                    MessageBox.Show("Данные добавлены");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка");
            }
        }
    }
}
