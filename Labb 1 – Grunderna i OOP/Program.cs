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
            circle1.DisplayArea();
            circle1.DisplayCircumference();
            circle1.DisplayVolume();
            Console.WriteLine(" ");
            Console.WriteLine("Cirkel med 6 i radie");
            circle2.DisplayArea();
            circle2.DisplayVolume();
            circle2.DisplayCircumference();
            Console.WriteLine(" ");
            Triangle triangle = new Triangle(30, 30, 50);
            triangle.DisplayArea();
        }
    }
}