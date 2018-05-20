using System;
using System.Globalization;
using System.Windows.Data;

namespace AdaptiveWpfLayout
{
    public class AdaptiveIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return false;
            }

            if (!int.TryParse(value.ToString(), out int firstOperand))
            {
                throw new InvalidOperationException("The value could not be converted to an integer");
            }


            var parameters = parameter.ToString().Split('|');
            if (parameters.Length != 3)
                throw new IndexOutOfRangeException($"Converter parameter should have 3 fields: " +
                    $"{{limit}}|{{resultForLess}}|{{resultForMore}} but {parameters.Length} found ('{parameter}')");

            if (!int.TryParse(parameters[0], out int limit))
                throw new InvalidOperationException($"The limit ('{parameters[0]}') could not be converted to an integer");

            if (!int.TryParse(parameters[0], out int resultForLess))
                throw new InvalidOperationException($"The limit ('{parameters[1]}') could not be converted to an integer");

            if (!int.TryParse(parameters[0], out int resultForMore))
                throw new InvalidOperationException($"The limit ('{parameters[1]}') could not be converted to an integer");

            return firstOperand < limit ? resultForLess : resultForMore;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
