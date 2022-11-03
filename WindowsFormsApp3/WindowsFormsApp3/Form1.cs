using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox6.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox9.Text == ""|| textBox7.Text != textBox8.Text)
            {
                DialogResult result = MessageBox.Show(
        "Заполните пустые поля или исправте ошибку");
            }
            else
            {
                DialogResult result = MessageBox.Show(
        $"Логин - {textBox9.Text}\nПароль - {textBox8.Text}",
                "Регистрация пройдена успешно");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.Text=="")
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.PasswordChar = '*';
            if (textBox7.TextLength<=12&&textBox7.TextLength>=4)
            {
                label18.Visible = false;
            }
            else
            {
                label18.Visible = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.PasswordChar = '*';
            if (textBox7.Text==textBox8.Text)
            {
                label19.Visible = false;
            }
            else
            {
                label19.Visible = true;
            }
        }
    }
}
