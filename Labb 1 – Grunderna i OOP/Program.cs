namespace Labb_1___Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi har 2 st Cirklar första har en radie på 5 och den andra på 6.");
            Console.WriteLine("");
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            Console.WriteLine("Cirkel med 5 i radie");
            circle1.getArea();
            circle1.getVolume();
            circle1.getCircumference();
            Console.WriteLine(" ");
            Console.WriteLine("Cirkel med 6 i radie");
            circle2.getArea();
            circle2.getVolume();
            circle2.getCircumference();
            Console.WriteLine(" ");
            Console.WriteLine("Arean på en triangel med sidorna 30,30 och 50 blir:");
            Triangle triangle = new Triangle(30, 30, 50);
            Console.WriteLine(triangle.getArea());
        }
    }
}