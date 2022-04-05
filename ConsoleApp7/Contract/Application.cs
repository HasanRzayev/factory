using ConsoleApp7.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Contract
{
    class Application
    {
        public GUIFactory factory { get; set; }
        public IButton button { get; set; }
        public Application (GUIFactory factory,IButton button)
        {
            this.factory = factory; 
            this.button = button;
        }
        public void CreateUI()
        {
            factory.createButton();
            button.Click();
            Console.WriteLine("Ui yaratdiniz");
        }
        public void paint()
        {
            Console.WriteLine("Reng tetbiq olundu");
        }

    }
}
