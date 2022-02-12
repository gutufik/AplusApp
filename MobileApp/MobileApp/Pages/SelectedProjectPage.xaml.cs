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
        public string title { get; set; }
        public SelectedProjectPage(Project project)
        {
            InitializeComponent();
            title = project.Name;
            selectedProject = project;

            Children.Add(new AboutProjectPage(project));
            Children.Add(new ImagesPage());
            Children.Add(new ContactsPage(project));

            this.BindingContext = this;
        }

        private async void EditProjectClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProjectPage(selectedProject));
        }
    }
}