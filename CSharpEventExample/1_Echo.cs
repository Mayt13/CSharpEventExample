using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEventExample
{
    class Echo //publisher
    {
        public void Run()
        {   
            while (true)
            {
                Console.WriteLine("Echo imput:");
                string _echo = Console.ReadLine();
                if (_echo.Equals("q"))
                    return;
                EventCollection(this, new EchoArgs(_echo)); //raises a new event
            }
        }
        public event EventHandler <EchoArgs> EventCollection; //registers as publisher
    }
    class EchoArgs : EventArgs
    {
        public EchoArgs(string name)
        {
            Name = name;
        }
        public string Name;
    }
}
