using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace FormAdvanced
{
    /// <summary>
    /// Interaction logic for BasicInformation.xaml
    /// </summary>
    public partial class BasicInformation : UserControl
    {
        List<string> countryList = new List<string>();
        CultureInfo[] countries = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;

        public BasicInformation()
        {
            InitializeComponent();
        }

        private void name_LF(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) is false)
            {
                string text = name.Text.First().ToString().ToUpper() + name.Text.Substring(1);
                name.Text = text;
            }
        }

        private void surname_LF(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) is false)
            {
                string text = lastName.Text.First().ToString().ToUpper() + lastName.Text.Substring(1);
                lastName.Text = text;
            }
        }

        private void BasicInformation_Load(object sender, EventArgs e)
        {
            foreach(CultureInfo country in countries)
            {
                region = new RegionInfo(country.LCID);
                if (!(countryList.Contains(region.EnglishName)))
                {
                    countryList.Add(region.EnglishName);
                    CountryBox.Items.Add(region.EnglishName + " (" + region.ISOCurrencySymbol + ")");
                }
            }
        }

  
    }

    public class RadioBoolToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            char integer = (char)value;
            if (integer == char.Parse(parameter.ToString()))
                return true;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}
