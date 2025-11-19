namespace ConsoleEIE;

class Program {
    static void Main(string[] args) {
        String name, gender;
        int height;
        
        do {
            Console.Clear();
            //? Input Name
            do {
                Console.Write("Please enter your name(Eng) : ");
                name = Console.ReadLine();
            } while (name == "");

            Console.WriteLine("Hello, Welcome " + name);

            //? Input Gender 
            do {
                Console.Write("Please enter your gender (M/W): ");
                gender = Console.ReadLine().ToUpper();
            } while (gender != "M" && gender != "W");

            //? Input 
            do {
                Console.Write("Please enter your height (cm) : ");
            } while (!int.TryParse(Console.ReadLine(), out height));

            int weight = (gender == "M") ? height - 100 : (gender == "W") ? height - 110 : 0;

            Console.WriteLine($"Your ideal weight is {weight.ToString()} kg \n");
            
            Console.WriteLine("Press Q to exit program Or press any other key to continue...");
        }while(Console.ReadKey().Key != ConsoleKey.Q);
    }
}