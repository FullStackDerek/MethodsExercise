namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter in a holiday: ");
            //string holiday = Console.ReadLine();

            //Console.WriteLine("Enter an animal: ");
            //string animal = Console.ReadLine();

            //Console.WriteLine("Enter a type of toy: ");
            //string toy = Console.ReadLine();

            //Console.WriteLine("Enter in a celebrity: ");
            //string celebrity = Console.ReadLine();

            //Console.WriteLine($"'Twas the night before {holiday} when all through the house, \n" +
            //    $"Not a creature was stirring, not even a {animal} \n" +
            //    $"The {toy} were hung by the chimney with care \n" +
            //    $"In hopes that {celebrity} soon would be there");


            //Console.WriteLine(Add(4, 5));
            //Console.WriteLine(Subtract(10, 2));
            //Console.WriteLine(Multiply(10, 2));
            //Console.WriteLine(Divide(10, 2));
            //Console.WriteLine(Modulus(10, 2));
            Console.WriteLine(AddWithParams(1, 2, 3));
        }

        static int Add(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer;
        }

        static int Subtract(int num1, int num2)
        {
            int answer = num1 - num2;
            return answer;
        }

        static int Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }

        static int Divide(int num1, int num2)
        {
            int answer = num1 / num2;
            return answer;
        }

        static int Modulus(int num1, int num2)
        {
            int answer = num1 % num2;
            return answer;
        }


        static int AddWithParams(params int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum = sum + item;
            }
            return sum;
        }
    }
}
