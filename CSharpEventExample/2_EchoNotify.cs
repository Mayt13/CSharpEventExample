using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CSharpEventExample
{
    class EchoNotify : INotifyPropertyChanged //publisher
    {
        public void Run()
        {   
            while (true)
            {
                Console.WriteLine("Echo imput:");
                string _echo = Console.ReadLine();
                if (_echo.Equals("q"))
                    return;
                PropertyChanged(this, new PropertyChangedEventArgs(_echo)); //raises a new event
            }
        }
        public event PropertyChangedEventHandler PropertyChanged; //registers as publisher
    }
}
