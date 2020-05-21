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
        public Triangle(double A, double B, double C, double H)//конструктор 
        {
            a = A;
            b = B;
            c = C;
            h = H;//высота
        }
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
        public bool ExistTriangle // свойство позволяющее установить, существует ои треугольник с задаными сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b)) //сумма 2 сторон должна быть больше третьей
                    return false;
                else return true;
            }
        }
    }
}
