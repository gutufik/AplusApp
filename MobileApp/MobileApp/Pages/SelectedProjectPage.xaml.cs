using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.DataBase;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedProjectPage : TabbedPage
    {
        Project selectedProject;
        public SelectedProjectPage(Project project)
        {
            InitializeComponent();
            Title = project.Name;
            selectedProject = project;
        }

        private async void EditProjectClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProjectPage(selectedProject));
        }
    }
}