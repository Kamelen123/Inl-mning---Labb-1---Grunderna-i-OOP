

namespace Inlämning___Labb_1___Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle (5);

            Circle circle2 = new Circle(6);

            float firstArea = circle.GetArea();
            float secondArea = circle2.GetArea();
            Console.WriteLine("The area of a circal with a radius of " + circle.radius + " meters is " + firstArea + " square meters.");

            Console.WriteLine("The area of a circal with a radius of " + circle2.radius + " meters is " + secondArea + " square meters.");
            Console.ReadKey();
        }
    }
    internal class Circle
    {
        public int radius;
        public float pi = 3.141f;

        public Circle (int Radius)
        {
            this.radius = Radius;
        }
        public float GetArea()
        {
            float area = radius * radius * pi;
            return area;
        }
    }
}