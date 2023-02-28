using System;

namespace _27._02._2023
{
    class Program
    {
        static T Swap<T>(T A, T b)
        {
            T Temp;
            Temp = A;
            A = b;
            b = Temp;
            return A;
        }
        static void Main(string[] arr)
        {
            int Obj = Swap(6, 7);
            Console.WriteLine(Obj);
        }
    }
    

}
