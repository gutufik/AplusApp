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
    public partial class EditProjectPage : ContentPage
    {
        Project selectedProject;
        public EditProjectPage(Project project)
        {
            InitializeComponent();
            selectedProject = project;
            projectNameEntry.Text = selectedProject.Name;
            projectDescEntry.Text = selectedProject.Description;
            phoneEntry.Text = selectedProject.PhoneNumber;
            emailEntry.Text = selectedProject.Email;
            addressEntry.Text = selectedProject.Address;
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("", $"Вы точно хотите изменить {selectedProject.Name}", "Изменить", "Отмена");
            Project project = new Project() 
            {
                Id = selectedProject.Id,
                Name = projectNameEntry.Text,
                Description = projectDescEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Email = emailEntry.Text,
                Address = addressEntry.Text
            };
            if (result)
            {
                App.Database.AddProject(project);
                await Navigation.PushAsync(new ProjectsPage());
            }
        }

        private async void DeleteClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("", $"Вы точно хотите удалить {selectedProject.Name}", "Удалить", "Отмена");
            if (result)
            {
                App.Database.DeleteProject(selectedProject.Id);
                await Navigation.PushAsync(new ProjectsPage());
            }
        }
    }
}