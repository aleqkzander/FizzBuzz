namespace FizzBuzz_Solver
{
    public class InputHelper
    {
        public static int ConvertConsoleInputToInteger(string input)
        {
            if (ConvertToInt(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine($"--> Your input: {input} is not a valid number so 0 is assumed");
                return 0;
            }
        }

        private static bool ConvertToInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
    }
}
