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
    public partial class Form3 : Form
    {
        ListBox list_;
        Button btn;
        Label lA, lB, lC, lH;
        TextBox txtA, txtB, txtC, txtH;
        public Form3()
        {
            this.Size = new Size(300, 450);
            list_ = new ListBox();
            list_.Location = new Point(10, 10);
            list_.Size = new Size(265, 150);
            list_.Items.Add("Item Column");
            Controls.Add(list_);

            btn = new Button();
            btn.Location = new Point(100, 350);
            btn.Size = new Size(80, 40);
            btn.Text = "Запуск";
            btn.Click += Btn_Click;
            Controls.Add(btn);

            lA = new Label();
            lA.Location = new Point(50, 180);
            lA.Text="Сторона А";
            Controls.Add(lA);

            lB = new Label();
            lB.Location = new Point(50, 215);
            lB.Text = "Сторона B";
            Controls.Add(lB);

            lC = new Label();
            lC.Location = new Point(50, 250);
            lC.Text = "Сторона C";
            Controls.Add(lC);

            lH = new Label();
            lH.Location = new Point(50, 295);
            lH.Text = "Сторона H";
            Controls.Add(lH);

            txtA = new TextBox();
            txtA.Location = new Point(120, 180);
            Controls.Add(txtA);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, c, h;
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtH.Text == "")
            {
                a = 0;
                b = 0;
                c = 0;
                h = 0;
            }
            else
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                h = Convert.ToDouble(txtH.Text);
            }
            Triangle triangle = new Triangle(a, b, c);
            list_.Items.Add("Сторона а:" + " " + triangle.outputA());
            list_.Items.Add("Сторона b:" + " " + triangle.outputB());
            list_.Items.Add("Сторона c:" + " " + triangle.outputC());
            list_.Items.Add("Высота:" + " " + triangle.outputH());
            list_.Items.Add("Периметр а:");

        }
    }
}
