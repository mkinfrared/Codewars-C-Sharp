namespace Codewars.GrasshopperSummation
{
    public class Kata
    {
        public static int summation(int num)
        {
            int result = Factorial(num);

            return result;
        }

        public static int Factorial(int num)
        {
            if (num == 1) return 1;

            int result = num + Factorial(num - 1);

            return result;
        }
    }
}
