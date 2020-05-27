using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text); // считываем значение стороны а
            b = Convert.ToDouble(txtB.Text);// считываем значение стороны b
            c = Convert.ToDouble(txtC.Text);// считываем значение стороны c
            Triangle triangle = new Triangle(a, b, c);// создаем объект класса Triangle с именем triangle
            listView1.Items.Add("Сторона а");// добавляем соответсвующие ячейки в коллекцию items объекта listview1
            listView1.Items.Add("Сторона b");//
            listView1.Items.Add("Сторона c");//
            listView1.Items.Add("Существует?");//
            listView1.Items.Add("Спецификатор");//
            listView1.Items[0].SubItems.Add(triangle.outputA());//
            listView1.Items[1].SubItems.Add(triangle.outputB());//
            listView1.Items[2].SubItems.Add(triangle.outputC());//
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));//выводим периметр
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface())); // выводим значение площади
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }// свойство Triangle.exist
            else listView1.Items[6].SubItems.Add("Не существует");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Run_button_DobleClick(object sender, MouseEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
