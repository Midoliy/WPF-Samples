using IValueConverter_sample.Model.Command;
using IValueConverter_sample.Model.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValueConverter_sample.ViewModel
{
    public class MainWindowViewModel
    {
        public NotifiableProperty<int> Number { get; private set; }
        public DelegateCommand Command { get; }

        public MainWindowViewModel()
        {
            Number = new NotifiableProperty<int>(0);
            Command = new DelegateCommand(v => 
            {
                if (Number.Value < 40)
                    Number.Value++;
                else
                    Number.Value = 0;
            });
        }

    }
}
