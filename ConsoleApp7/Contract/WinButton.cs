using ConsoleApp7.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Contract
{
    class WinButton : IButton
    {
        void IButton.Click()
        {
            throw new NotImplementedException();
        }
    }
}
