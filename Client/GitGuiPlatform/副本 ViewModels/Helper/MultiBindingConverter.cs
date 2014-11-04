using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Cafe.GitGuiPlatform.ViewModels.Helper
{
    public class MultiBindingConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (!values.Cast<string>().Any(Text => string.IsNullOrEmpty(Text)))
            {
                int nowYear = System.Convert.ToInt16(DateTime.Now.Year);
                int nowMonth = System.Convert.ToInt16(DateTime.Now.Month);
                int nowDay = System.Convert.ToInt16(DateTime.Now.Day);
                
                int dayValue = System.Convert.ToInt16(values[0]);
                int monthValue = System.Convert.ToInt16(values[1]);
                int yearValue = System.Convert.ToInt16(values[2]);
                
                if( yearValue > nowYear)
                {
                    return false;
                }
                else if( yearValue == nowYear )
                {
                    if( monthValue > nowMonth)
                    {
                        return false;
                    }else if( monthValue == nowMonth )
                    {
                        if( dayValue > nowDay)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return true;
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
