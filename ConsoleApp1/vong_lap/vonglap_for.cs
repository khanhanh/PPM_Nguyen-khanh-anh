
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vong_lap
{
    /// <summary><para></para></para></summary>
    /// <Modified>
    /// Name     Date         Comments
    /// khanh  4/11/2020   created
    /// </Modified>
    class vonglap_for
    {
        static void Main(string[] args)
        { int a;
            Console.WriteLine("cac gia tri cua vong lap ");
            Console.WriteLine("------------------------ ");
            for ( a=10 ; a < 30; a++)
            {
                Console.WriteLine("cac gia tri cua a {0}", a);
            }
            Console.ReadLine();
            Console.ReadKey();
        }


    }
}
