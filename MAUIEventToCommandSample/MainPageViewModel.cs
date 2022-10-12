using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIEventToCommandSample
{
     public class MainPageViewModel
     {
          public ICommand TextChangedCommand =>
               new Command((newText) =>
               {
                    Console.WriteLine(newText.ToString());
               });
     }
}
