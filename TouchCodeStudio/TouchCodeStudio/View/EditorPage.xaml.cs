using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TouchCodeStudio.View
{
    public partial class EditorPage : ContentPage
    {
        public EditorPage()
        {
            InitializeComponent();

            

            editor.IsEnabled = false;

            TapGestureRecognizer editorTapRecognizer = new TapGestureRecognizer();
            editorTapRecognizer.Tapped += EditorTapRecognizer_Tapped;
            editorTapRecognizer.Command = new Command(EditorTapRecognizer_Command);
            editor.GestureRecognizers.Add(editorTapRecognizer);
        }

        private void EditorTapRecognizer_Command()
        {
            Debug.WriteLine("Command executed");
        }

        private void EditorTapRecognizer_Tapped(object sender, EventArgs e)
        {
            Debug.WriteLine("Tapped");
        }
    }
}
