using System;
using System.ComponentModel;

namespace CSharpEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("" +
                    "Choose Implementation:\n" +
                    "1)Echo\n" +
                    "2)EchoNotify\n" +
                    "3)EchoNotifyBinding\n" +
                    "4)EchoNotifyBindingAlternating");
                var imput = Console.ReadLine();
                int caseswitch;
                if (imput == "q")
                {
                    return;
                }
                else if (imput == "1" || imput == "2" || imput == "3" || imput == "4")
                {
                    caseswitch = int.Parse(imput);
                    switch (caseswitch)
                    {
                        case (1):
                            Sub1.Run();
                            break;
                        case (2):
                            Sub2.Run();
                            break;
                        case (3):
                            Sub3.Run();
                            break;
                        case (4):
                            Sub4.Run();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("invlaid keypress");
                }
            }
        }
    }
}
