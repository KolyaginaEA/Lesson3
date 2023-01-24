namespace Ekaterina
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] A = new int[3];
            int[] B = new int[3];
            System.Console.Write("a1 = ");
            A[0] = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("a2 = ");
            A[1] = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("a3 = ");
            A[2] = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("b1 = ");
            B[0] = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("b2 = ");
            B[1] = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("b3 = ");
            B[2] = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Расстояние: {0}", Len(A, B));
            System.Console.ReadKey(true);
        }

        static double Len(int[] A, int[] B)
        {
            return System.Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]) + (A[2] - B[2]) * (A[2] - B[2]));

        }
    }
}