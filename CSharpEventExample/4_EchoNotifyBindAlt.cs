using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CSharpEventExample
{
    class EchoNotifyBindAlt : INotifyPropertyChanged //publisher
    {
        public EchoNotifyBindAlt()
        {
            _entry = string.Empty;
            _entry2 = string.Empty;
        }
        public void Run()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Echo imput:");
                if (i == 0)
                {
                    Entry = Console.ReadLine(); //calls set method calling event
                    i = 1;
                }
                else
                {
                    Entry2 = Console.ReadLine(); //calls set method calling event
                    i = 0;               
                }
                if (Entry.Equals("q") || Entry2.Equals("q"))
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
        private string _entry2;
        public string Entry2
        {
            get { return _entry2; }
            set
            {
                _entry2 = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Entry2))); //raises a new event
            }
        }
    }
}
