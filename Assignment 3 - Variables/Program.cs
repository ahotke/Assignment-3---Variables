namespace Assignment_3___Variables
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string coursename = " Computer Science ", name = " Ashton ";
            double price = 7.99, radius = 8.25;
            int roomnum = 405, gradyear = 2026;

            double area = radius * Math.PI;

            area = Math.Round(area, 1);

            Console.WriteLine("I am learning about" + coursename);
            Console.WriteLine("");
            Console.WriteLine("The total cost is " + price);
            Console.WriteLine("");
            Console.WriteLine("The room number is " + roomnum);
            Console.WriteLine("");
            Console.WriteLine("My name is" + name + "and I graduate in " + gradyear);
            Console.WriteLine("");
            Console.WriteLine("The area of the circle is roughly " + area);


        }
    }
}
