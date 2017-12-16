using System;
using System.Windows.Data;

namespace NsiViewerDevExpress.Common
{
    public class ConverterRefAttrType : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return -1;

            switch ((int)value)
            {
                case 0:
                    return NSIDataTypes.String;
                case 1:    
                    return NSIDataTypes.Integer;
                case 2:    
                    return NSIDataTypes.Real;
                case 3:    
                    return NSIDataTypes.DateTime;
                case 4:    
                    return NSIDataTypes.ReferenceRecord;
            }
            return -1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}