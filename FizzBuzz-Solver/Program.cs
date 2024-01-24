using FizzBuzz_Solver;

bool applicationRunning = true;

while (applicationRunning)
{
    Console.Write("\nProvide a number that is divisible by 3 or 5 and press enter: ");
    int userNumberInput = InputHelper.ConvertConsoleInputToInteger(Console.ReadLine()!);
    FizzBuzz.StartFizzBuzzCheck(userNumberInput);
}