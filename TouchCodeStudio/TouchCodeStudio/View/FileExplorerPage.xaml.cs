using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TouchCodeStudio.View
{
    public partial class FileExplorerPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public FileExplorerPage()
        {
            InitializeComponent();
        }
    }
}
