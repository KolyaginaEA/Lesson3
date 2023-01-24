namespace Ekaterina
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.Write("N = ");
            int N = System.Convert.ToInt32(System.Console.ReadLine());
            Cube(N);
            System.Console.ReadKey(true);
        }

        static bool Cube(int N)
        {
            if(N < 1)
            {
                System.Console.Write("Число меньше 1");
                return false;
            }
            for (int i = 1; i <= N; i++)
            {
                System.Console.Write("{0} ", System.Math.Pow(i, 3));
            }
            return true;
        }
    }
}