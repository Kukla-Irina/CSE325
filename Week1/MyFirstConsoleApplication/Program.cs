namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Irina";
            string location = "Russia";
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);
            Console.WriteLine($"{DateTime.Today:d}");
            DateTime christmas = new DateTime(2025, 12, 25);
            TimeSpan daysUntilChristmas = christmas.Subtract(DateTime.Now);
            Console.WriteLine($"Days until Christmas: {daysUntilChristmas.Days}");

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Write width in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Write height in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadKey();

        }
    }
}
