namespace LB1
{

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть сторону a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (!ArePositive(a, b, c))
            {
                Console.WriteLine("Помилка, сторони повинні бути додатними числами.");
                return;
            }

            if (!IsValid(a, b, c))
            {
                Console.WriteLine("Помилка, такого трикутника не існує");
                return;
            }

            double perimeter = CalculatePerimeter(a, b, c);
            Console.WriteLine($"Периметр: {perimeter}");

            double area = CalculateArea(a, b, c);
            Console.WriteLine($"Площа: {area}");

            string type = TriangleType(a, b, c);
            Console.WriteLine($"Вид трикутника: {type}");
        }

        static bool ArePositive(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0;
        }

        static bool IsValid(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        static double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static double CalculateArea(double a, double b, double c)
        {
            double p = CalculatePerimeter(a, b, c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static string TriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "рівносторонній";
            }
            else if (a == b || a == c || b == c)
            {
                return "рівнобедрений";
            }
            else if (IsRightTriangle(a, b, c))
            {
                return "прямокутний";
            }
            else
            {
                return "довільний";
            }
        }

        static bool IsRightTriangle(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.0001;
        }
    }
}
