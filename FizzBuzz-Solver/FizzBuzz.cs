namespace FizzBuzz_Solver
{
    public class FizzBuzz
    {
        public static void StartFizzBuzzCheck(int number)
        {
            StartNumberCheck(number);
        }

        private static void StartNumberCheck(int number)
        {
            if (number % 3 != 0 && number % 5 != 0)
            {
                Console.WriteLine($"--> The number {number} is not divisible by 3 or 5. Please try again.");
            }
            else
            {
                RunFizzBuzzCheck(number);
            }
        }

        private static void RunFizzBuzzCheck(int number)
        {
            if (NumberIsDivisibleBy3And5(number))
            {
                Console.WriteLine("--> FizzBuzz");
                return;
            }

            if (NumberIsDivisibleBy3(number))
            {
                Console.WriteLine("--> Fizz");
            }

            if (NumberIsDivisibleBy5(number))
            {
                Console.WriteLine("--> Buzz");
            }
        }

        private static bool NumberIsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        private static bool NumberIsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }

        private static bool NumberIsDivisibleBy3And5(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}
