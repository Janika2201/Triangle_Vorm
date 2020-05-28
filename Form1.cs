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
<<<<<<< HEAD
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона а");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Высота  h");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.HeightOfTriangle()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); }
=======
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
>>>>>>> 2ccdfd7fe42fbe3be18487ae59a4ef0ff9cbfec2
            else listView1.Items[6].SubItems.Add("Не существует");
            listView1.Items[7].SubItems.Add(triangle.TriangleofType());
            pictureBox1.Image = Image.FromFile(triangle.ImageType());


        }
        private void Run_button_DobleClick(object sender, MouseEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
