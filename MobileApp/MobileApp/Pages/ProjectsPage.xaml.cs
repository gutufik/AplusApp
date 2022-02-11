using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public List<string> Projects { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
            Projects = new List<string>();
            FillList();
            this.BindingContext = this;
        }

        public void FillList()
        {
            for (int i = 0; i < 20; i++)
            {
                Projects.Add($"Проект {i + 1}");
            }
        }

        private async void lwProjectsItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new SelectedProjectPage(lwProjects.SelectedItem.ToString()));
        }
    }
}
