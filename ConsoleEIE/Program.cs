namespace ConsoleEIE;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Please enter your name(Eng) : ");

        String name = Console.ReadLine();

        Console.WriteLine("Hello, Welcome " + name);

        Console.WriteLine("Please enter your gender (M/W): ");
        String gender = Console.ReadLine().ToUpper();
        Console.WriteLine("Please enter your height (cm) : ");

        int height = Convert.ToInt16(Console.ReadLine());
        int weight = (gender == "M") ? height - 100 : (gender == "W") ? height - 110 : 0;

        Console.WriteLine($"Your ideal weight is {weight.ToString()} kg");
    }
}