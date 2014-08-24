using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace SimpleChat.Client.Wpf.Converters
{
    public class StatusToColorConverter:IValueConverter
    {
        public Dictionary<int, Color> _LookUpDictionary=new Dictionary<int, Color>
        {
            {0, Colors.Red},
            {1,Colors.Green},
            {2,Colors.Fuchsia},
            {3,Colors.Gray},
            {4,Colors.Orange}
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var wert = value as int?;
            if(wert == null)
                return null;
            return new SolidColorBrush(_LookUpDictionary[(int)wert]);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
