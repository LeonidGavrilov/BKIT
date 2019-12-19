using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] blahBlah)
        {
            Console.WriteLine("Введите параметры фигур \n");
            double inn1, inn2;
            inn1 = Convert.ToDouble(Console.ReadLine());
            inn2= Convert.ToDouble(Console.ReadLine());
            Rectangle rec = new Rectangle(inn1, inn2);
            Square sc = new Square(inn2);
            Circle cir = new Circle(inn2);

            rec.Print();
            sc.Print();
            cir.Print();


            Console.ReadKey();
        }
    }
}
