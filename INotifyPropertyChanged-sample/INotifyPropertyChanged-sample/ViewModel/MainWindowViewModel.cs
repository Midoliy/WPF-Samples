using INotifyPropertyChanged_sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged_sample.ViewModel
{
    public class MainWindowViewModel
    {
        public NotifiableProperty<int> Number { get; set; }

        public MainWindowViewModel()
        {
            Number = new NotifiableProperty<int>(10);
        }

    }
}
