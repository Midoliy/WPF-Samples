using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavior_sample.ViewModel
{
    public class MainWindowViewModel
    {
        public string Message { get; private set; }

        public MainWindowViewModel()
        {
            Message = "Test Message";
        }
    }
}
