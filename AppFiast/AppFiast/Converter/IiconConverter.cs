using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppFiast.Converter
{
    public class IiconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && bool.TryParse(value.ToString(), out bool retult))
            {
                var r = parameter.ToString();
                if (retult)
                {
                    if (r == "L")
                        return "\xe657";
                    else
                        return "\xe676";

                }
                else
                {
                    if (r == "L")
                        return "\xe612";
                    else
                        return "\xe614";
                }
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
