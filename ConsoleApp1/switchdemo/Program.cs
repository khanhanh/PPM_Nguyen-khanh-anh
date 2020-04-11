using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'D';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Xuat sac!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Gioi");
                    break;
                case 'D':
                    Console.WriteLine("Trung binh");
                    break;
                case 'F':
                    Console.WriteLine("Hoc lai");
                    break;
                default:
                    Console.WriteLine("Gia tri khong hop le");
                    break;
            }
            Console.WriteLine("Hoc luc cua ban la: {0}",grade);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

/*
int A;
string strA;
char B = 'A';


Console.Write("moi ban nhap so diem mon hoc:");
strA = Console.ReadLine();



if (int.TryParse(strA, out A) == false)
{
    Console.WriteLine("du lieu nhap sai");
}



}
}
}
*/
