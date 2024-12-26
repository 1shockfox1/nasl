using ClassLibrary;


class Program
{
    static void Main()
    {
        Console.Write("Введите координату x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Введите радиус окружности: ");
        double z1 = double.Parse(Console.ReadLine());

        Circle circle = new Circle(z1); 

        bool isInside = circle.IsPointInside(x1, y1);
        if (isInside)
        {
            Console.WriteLine("Точка находится внутри окружности.");
        }
        else
        {
            Console.WriteLine("Точка находится вне окружности.");
        }
    }
}