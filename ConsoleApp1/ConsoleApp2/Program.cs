using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenh if else trong C#");
            Console.WriteLine("-------------------------------");

            int A, B;
         string strA, strB;
          
            

            Console.Write("moi ban nhap A:" );
            strA = Console.ReadLine();

            Console.Write("moi ban nhap B:");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine("A bang B");
            }
            
             
               
           
            else if(A==B)
            {
                Console.WriteLine("A bang hơn B");
            }
            else if(A > B){
                Console.WriteLine("A lon hon B");
            }
            else
            {
                Console.WriteLine("A nho hon B");
            }
              
            
        
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
