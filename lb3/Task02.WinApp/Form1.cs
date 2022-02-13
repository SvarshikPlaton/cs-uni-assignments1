using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryProduct;

namespace Task02.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        static List<Product> products = new List<Product>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""|| textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "" || textBox5.Text == ""|| textBox6.Text == "" ||
                textBox7.Text == ""|| (textBox8.Visible && textBox8.Text==""))
            {
                MessageBox.Show("Введите все поля!");
            }
            else if (float.TryParse(textBox4.Text,out float price) && 
                (int.TryParse(textBox6.Text, out int count)||float.TryParse(textBox6.Text, out float weight))&&
                DateTime.TryParse(textBox3.Text,out DateTime time))
            {
                Product product;
                if (comboBox1.SelectedIndex == 0)
                    product = new CountProduct(textBox1.Text, textBox2.Text, textBox3.Text, price,
                        textBox5.Text, count, textBox7.Text);
                else
                    product = new WeightProduct(textBox1.Text, textBox2.Text, textBox3.Text, price,
                        textBox5.Text, float.Parse(textBox6.Text), textBox7.Text, textBox8.Text);

                products.Add(product);
                dataGridView1.RowCount = products.Count;
                for (int i=0; i<products.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = products[i].GetInfo();
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = (i % 2 == 0) ? SystemColors.ButtonHighlight : SystemColors.ButtonFace;

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
            } else
                MessageBox.Show("Неправильный формат чисел или даты");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                label6.Text = "Количество:";
                label7.Text = "Цвет:";
                textBox8.Visible = false;
                label8.Visible = false;
            }
            else
            {
                label6.Text = "Вес:";
                label7.Text = "Страна производитель:";
                textBox8.Visible = true;
                label8.Visible = true;
            }
        }
    }
}
