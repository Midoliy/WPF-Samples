using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged_sample.Model
{
    public class NotifiableProperty<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly PropertyChangedEventArgs _arg;
        private readonly Predicate<T> _predicate;

        public T Value
        {
            get => _value;
            set
            {
                if(value != null && !_value.Equals(value) && _predicate(_value))
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, _arg);
                }
            }
        }

        private T _value;

        public NotifiableProperty(T value = default)
        {
            _arg = new PropertyChangedEventArgs(nameof(Value));
            _predicate = v => true;
            _value = value;
        }

        public NotifiableProperty(T value, Predicate<T> predicate)
            : this(value)
        {
            _predicate = predicate;
        }
    }
}
