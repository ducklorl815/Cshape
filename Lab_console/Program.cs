using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi.C#!");
            Console.Write("請輸入姓名: ");   //write 直接同一行執行//
            string Name = Console.ReadLine(); //把右邊的值丟回左邊//
            Console.WriteLine("Hi! " + Name);
            Console.Write("你幾歲呢? ");
            string age = Console.ReadLine();
            Console.WriteLine("好的~ 安安!!" + Name +"你"+ age +"歲喔!!");
            Console.ReadKey();
        }
    }
}
