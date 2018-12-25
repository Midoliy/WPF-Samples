using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace IValueConverter_sample.Model.ValueConverter
{
    public class IntToBrushConverter : IValueConverter
    {
        /// <summary>
        /// ViewModel -> XAML
        /// </summary>
        /// <param name="value">ViewModel側のプロパティ値</param>
        /// <param name="targetType">valueの型</param>
        /// <param name="parameter">Bindingで指定されているパラメータ</param>
        /// <param name="culture">カルチャー情報</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (int.TryParse(value.ToString(), out int i))
            {
                if (i < 10) return new SolidColorBrush(Colors.Blue);
                if (i < 20) return new SolidColorBrush(Colors.Green);
                if (i < 30) return new SolidColorBrush(Colors.Yellow);
            }
            return new SolidColorBrush(Colors.Red);
        }

        /// <summary>
        /// XAML -> ViewModel
        /// </summary>
        /// <param name="value">XAML側のプロパティ値</param>
        /// <param name="targetType">valueの型</param>
        /// <param name="parameter">Bindingで指定されているパラメータ</param>
        /// <param name="culture">カルチャー情報</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
