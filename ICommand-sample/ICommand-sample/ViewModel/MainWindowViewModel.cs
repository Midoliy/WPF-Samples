using ICommand_sample.Model.Command;
using ICommand_sample.Model.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICommand_sample.ViewModel
{
    public class MainWindowViewModel
    {
        public NotifiableProperty<int> Number { get; set; }
        public DelegateCommand Command { get; set; }
        public DelegateCommand<dynamic> Command2 { get; set; }

        public MainWindowViewModel()
        {
            Number = new NotifiableProperty<int>(0);
            Command  = new DelegateCommand(v => Number.Value++, v => Number.Value < 10);
            Command2 = new DelegateCommand<dynamic>(v => Number.Value++, v => Number.Value < 10);
        }
    }
}
