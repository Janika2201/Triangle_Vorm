using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO.Internal;

namespace Triangle_Vorm
{
    class Triangle
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double h;
        public Triangle(double A, double B, double C)//конструктор 
        {
            a = A;
            b = B;
            c = C;

        }
        public Triangle(double H, double C)
        {
            c = C;
            h = H;
        }
        //методы
        public string outputA() // выводим сторону а, данный метод возвращает строковое значение
        {
            return Convert.ToString(a); // a - ссылка на внутренее поле обьекта класса
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public double AreaOfTriangle() // нахождение площади
        {
            double S = 0;
            S = 1 / 2 * b * h;//формула
            return S;
        }
        public double Perimeter() // сумма всех сторон типо double
        {
            double p = 0;
            p = a + b + c; // вычисление
            return p; // возврат
        }
        public double Surface() // аналогично периметру
        {
            double h = 0;
            double p = 0;
            p = (a + b + c) / 2;
            h = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return h;
        }
        public double Area()//вычисление площади 
        {
            double S = 0;
            S = (a * h) / 2;
            return S;
        }
        //свойства
        public double GetSetA // свойство позволяющее установить либо изменить значение стороны а
        {
            get //устанавливаем
            { return a; }
            set // меняем
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetH//свойство высоты
        {
            get
            { return h; }
            set
            {
                h = value;
            }
        }
        public bool ExistTriangle // свойство позволяющее установить, существует ли треугольник с задаными сторонами
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return true;
                else return false;
            }
        }
        public string TriangleofType//определение типа треугольника
        {
            get
            {
                if (a == b && b == c && c == a)
                {
                    return "Равносторонний";
                }
                else if (b == c || a == b || c == a)
                {
                    return "Равнобедренный";
                }
                else return "Разносторонний";
            }
        }
    }
}