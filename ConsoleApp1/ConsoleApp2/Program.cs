using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenh if else trong C#");
            Console.WriteLine("-------------------------------");

          
            int a = 10;
            
            if (a > 20)
            {
             
                Console.WriteLine("a lớn hon 20");
            }
            else
            {
                Console.WriteLine("a nho hơn 20");
            }
            Console.WriteLine("Gia tri cua a la: {0}", a);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
