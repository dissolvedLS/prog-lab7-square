using System;


namespace prog_lab7_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны, для создания квадрата : ");
            double side = 0;
            while (side == 0)
            {
                try
                {
                    side = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка при вводе!");
                    side = 0;
                }
            }
            Square newSquare = new Square(side);

            Console.WriteLine("Квадрат создан!");
            Console.WriteLine("Его периметр: " + newSquare.Perimeter());
            Console.WriteLine("Площадь: " + newSquare.Area());
            Console.WriteLine("Радиус вписанной окружности: {0:f2}", newSquare.r);
            Console.WriteLine("Радиус описанной окружности: {0:f2}", newSquare.R);
        }
    }
}
