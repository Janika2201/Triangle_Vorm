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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void DoubleClick_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a, b, c;
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                a = 7;
                b = 5;
                c = 2;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);// считываем значение стороны а
                b = Convert.ToDouble(textBox2.Text);// считываем значение стороны b
                c = Convert.ToDouble(textBox3.Text);// считываем значение стороны c
            }
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона а");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Высота  h");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Возможен");
            listView1.Items.Add("Тип");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.HeightOfTriangle()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Да"); }
            else listView1.Items[6].SubItems.Add("Нет");
            listView1.Items[7].SubItems.Add(triangle.TriangleofType());
        }
    }
}
