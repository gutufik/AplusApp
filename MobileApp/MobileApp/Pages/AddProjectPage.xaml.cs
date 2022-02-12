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
    public partial class AddProjectPage : ContentPage
    {
        public AddProjectPage()
        {
            InitializeComponent();
            Title = "Создать проект";
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            Project project = new Project() 
            {
                Name = projectNameEntry.Text,
                Description = projectDescEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Address = addressEntry.Text
            };
            App.Database.AddProject(project);

            await Navigation.PushAsync(new ProjectsPage());
        }
    }
}