using ConsoleApp7.Abstract;
using ConsoleApp7.Contract;
using System;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            GUIFactory factorywin = new WinFactory();
            GUIFactory factorymac = new MacFactory();
            IButton buttonwin=new WinButton();  
            IButton buttonmac=new MacButton();
            Application application = new Application(factorywin, buttonwin);
            application.CreateUI();
        }
    }
}
