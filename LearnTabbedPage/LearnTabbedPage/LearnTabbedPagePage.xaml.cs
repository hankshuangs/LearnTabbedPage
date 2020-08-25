using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace LearnTabbedPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnTabbedPagePage : Xamarin.Forms.TabbedPage
    {
        public LearnTabbedPagePage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom).SetBarItemColor(Color.Black).SetBarSelectedItemColor(Color.Blue);
        }
    }
}