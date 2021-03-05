using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CSharpEventExample
{
    class EchoNotifyBinding : INotifyPropertyChanged //publisher
    {

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Echo imput:");
                Entry = Console.ReadLine(); //calls set method calling event
                if (Entry.Equals("q"))
                    return;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged; //registers as publisher
        private string _entry;


        public string Entry
        {
            get { return _entry; }
            set
            {
                _entry = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Entry))); //raises a new event
            }
        }
    }
}

