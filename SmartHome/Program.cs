using System;

namespace SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SmartHomee _hometest = new SmartHomee();
            string command = "turn off fan";
            _hometest.SetCommand(command);
        }
    }
}
