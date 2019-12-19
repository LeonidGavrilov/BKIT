using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args )
        {
            Console.Title = ("Гаврилов Л.Я. ИУ5-33Б");
            double a=0, b=0, c=0;
            if (args.Length == 0)
            {
                Console.WriteLine("Введите коэффициеты через enter");



                unsafe
                {
                    void Inn(double* i)
                    {

                        string buff;

                    Ass: buff = Console.ReadLine();

                        for (int q = 0; q < buff.Length; q++)
                        {

                            if ((int)buff[q] < 43 || (int)buff[q] > 57)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Введите строку заново \n");
                                Console.ResetColor();
                                goto Ass;
                            }

                        }



                        if (buff.Contains("."))
                            buff = buff.Replace(".", ",");
                        if (buff.Contains(" "))
                            buff = buff.Remove(buff.IndexOf(' '));

                        (*i) = Convert.ToDouble(buff);

                    }

                    Inn(&a);
                    Inn(&b);
                    Inn(&c);
                }
            }


            if (args.Length == 3) {

                a = Convert.ToDouble(args[0]);
                b = Convert.ToDouble(args[1]);
                c = Convert.ToDouble(args[2]);

            }
            Console.WriteLine($"Коэффициент А:{a}  Коэффициент В:{b}  Коэффициент С:{c}");


            double d = (b * b - 4 * a * c);
            Console.WriteLine($"Дискриминант (для приведенного квадратного) ={d} \n");

            if (a == 0 && b == 0 && c == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Корней бесконечно много \n");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(1); ;
            }
            if (d < 0 || (a == 0 && b == 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней биквадратного уравнения нет \n");
                Console.ResetColor();
                Console.ReadKey();
                System.Environment.Exit(1); ;
            }


            if (b == 0 && c == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" 0 \n");
                Console.ResetColor();
                Console.ReadKey();
                System.Environment.Exit(1); ;

            }
            if (a == 0 && c == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" 0 \n");
                Console.ResetColor();
                Console.ReadKey();
                System.Environment.Exit(1); ;

            }
            if (a == 0)
            {
                double x1 = -Math.Sqrt(-c / b);
                double x2 = Math.Sqrt(-c / b);

                if (double.IsNaN(Math.Sqrt(-c / b)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней биквадратного уравнения нет \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    System.Environment.Exit(1); ;

                }

            }
            if (b == 0)
            {

                if (double.IsNaN(Math.Sqrt(-c / a)))

                {
                    double x1 = Math.Sqrt(Math.Sqrt(-c / a));
                    double x2 = -Math.Sqrt(Math.Sqrt(-c / a));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" {x1} {x2} \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    System.Environment.Exit(1); ;
                }




            }
            if (c == 0)
            {

                if (double.IsNaN(-b / a))
                {
                    double x1 = Math.Sqrt(Math.Sqrt(-b / a));
                    double x2 = -Math.Sqrt(Math.Sqrt(-b / a));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" {x1} {x2} \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    System.Environment.Exit(1); ;
                }
            }
            if (d > 0)
            {
                double t1 = (-b - Math.Sqrt(d)) / 2 * a;
                double t2 = (-b + Math.Sqrt(d)) / 2 * a;
                if (t1 < 0 && t2 < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней биквадратного уравнения нет \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    System.Environment.Exit(1); ;
                }
                else
                {
                    unsafe
                    {
                        double x1 = Math.Sqrt(t1);
                        double x2 = -Math.Sqrt(t1);
                        double x3 = Math.Sqrt(t2);
                        double x4 = -Math.Sqrt(t2);
                        Outt(&x1);
                        Outt(&x2);
                        Outt(&x3);
                        Outt(&x4);


                    }
                }
            }

            unsafe void Outt(double* o)
            {

                if (double.IsNaN(*o) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{*o}  \n");
                    Console.ResetColor();





                }

            }

            Console.ReadKey();

        }
    }

}