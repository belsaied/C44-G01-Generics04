namespace CalculatorTask
{
    internal class Program
    {
        public delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            
            int num1 = ValidInteger("Enter the first number:");

           
            int num2 = ValidInteger("Enter the second number:");

            Console.WriteLine("Choose operation: (+, -, *, /)");
            string op = Console.ReadLine();

            Operation operation_Delegate_Func;

            // Choose the delegate based on input
            switch (op)
            {
                case "+":
                    operation_Delegate_Func = Add;
                    break;
                case "-":
                    operation_Delegate_Func = Subtract;
                    break;
                case "*":
                    operation_Delegate_Func = Multiply;
                    break;
                case "/":
                    operation_Delegate_Func = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            // Use the delegate to compute result
            int result = operation_Delegate_Func(num1, num2);
            Console.WriteLine($"Result: {result}");
        }

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
            return a / b;
        }

        public static int ValidInteger(string str)
        {
            int number;
            Console.WriteLine(str);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number please enter a valid integer");
            }
            return number;
        }
    }
}
