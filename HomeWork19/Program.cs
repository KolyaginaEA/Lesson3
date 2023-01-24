namespace Ekaterina
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.Write("num = ");
            int num = System.Convert.ToInt32(System.Console.ReadLine());
            Palindrome(num);
            System.Console.ReadKey(true);
        }

        static bool Palindrome(int num)
        {
            if (num > 99999 || num < 10000)
            {
                System.Console.WriteLine("Число не пятизначное");
                return false;
            }
            if (num % 10 != num / 10000)
            {
                System.Console.WriteLine("Число не палиндром");
                return false;
            }
            if ((num % 100) / 10 != (num - (num / 10000) * 10000) / 1000)
            {
                System.Console.WriteLine("Число не палиндром");
                return false;
            }
            System.Console.WriteLine("Число палиндром");
            return true;
        }
    }
}