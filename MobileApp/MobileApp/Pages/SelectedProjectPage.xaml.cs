using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedProjectPage : TabbedPage
    {
        public SelectedProjectPage(string projectName)
        {
            InitializeComponent();
            Title = projectName;
        }

        private async void EditProjectClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProjectPage());
        }
    }
}