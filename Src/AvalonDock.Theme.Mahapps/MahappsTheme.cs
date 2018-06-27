using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDock.Theme.Mahapps
{
    public class MahappsTheme : Xceed.Wpf.AvalonDock.Themes.Theme
    {
        public override Uri GetResourceUri()
        {
            return new Uri(
                "/AvalonDock.Theme.Mahapps;component/Theme.xaml",
                UriKind.Relative);
        }
    }
}
