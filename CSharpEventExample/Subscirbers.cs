using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CSharpEventExample
{
    class Sub1
    {
        public static void Run()
        {
            var echo = new Echo();
            echo.EventCollection += EventListener;
            echo.Run();
        }
        public static void EventListener(object sender, EchoArgs args)
        {
            Console.WriteLine("Echo says: " + args.Name);
        }
    }
    class Sub2
    {
        public static void Run()
        {
            var echo = new EchoNotify();
            echo.PropertyChanged += EventListener; //registering event listerner as the handler, other way RaiseEvent.Add(), -= to remove in deconstructor/finlizer ~myclass()
            echo.Run();
        }
        public static void EventListener(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine("Echo says: " + args.PropertyName);
        }
    }
    class Sub3
    {
        public static void Run()
        {
            var echo = new EchoNotifyBinding();
            echo.PropertyChanged += EventListener; //registering event listerner as the handler, other way RaiseEvent.Add(), -= to remove in deconstructor/finlizer ~myclass()
            echo.Run();
        }
        public static void EventListener(object sender, PropertyChangedEventArgs args)
        {
            if (!args.PropertyName.Equals(nameof(EchoNotifyBinding.Entry)))
                return;

            var _sender = sender as EchoNotifyBinding;
            Console.WriteLine("Echo says: " + _sender.Entry);
        }
    }
    class Sub4
    {
        public static void Run() 
        {
            var echo = new EchoNotifyBindAlt();
            echo.PropertyChanged += EventListener; //registering event listerner as the handler, other way RaiseEvent.Add(), -= to remove in deconstructor/finlizer ~myclass()
            echo.Run();
        }

        public static void EventListener(object sender, PropertyChangedEventArgs args)
        {
            var _sender = sender as EchoNotifyBindAlt;
            switch (args.PropertyName)
            {
                case nameof(EchoNotifyBindAlt.Entry):
                    Console.WriteLine("Echo says: " + _sender.Entry);
                    break;
                case nameof(EchoNotifyBindAlt.Entry2):
                    Console.WriteLine("Echo2 says: " + _sender.Entry2);
                    break;
            }
            
        }
    }
}


