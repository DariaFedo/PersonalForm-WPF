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
}
