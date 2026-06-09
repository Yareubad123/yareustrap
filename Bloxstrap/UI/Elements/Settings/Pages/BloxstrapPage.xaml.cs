using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yareustrap.UI.ViewModels.Settings;

namespace yareustrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for yareustrapPage.xaml
    /// </summary>
    public partial class yareustrapPage
    {
        public yareustrapPage()
        {
            DataContext = new yareustrapViewModel();
            InitializeComponent();
        }
    }
}
