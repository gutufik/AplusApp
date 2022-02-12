﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.DataBase;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public IEnumerable<Project> Projects { get; set; }
        //public List<string> Projects { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
            Title = "Проекты";
            Projects = App.Database.GetProjects();
            this.BindingContext = this;
        }

        public void FillList()
        {
            App.Database.AddProject(new Project());
        }

        private async void lwProjectsItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new SelectedProjectPage(lwProjects.SelectedItem as Project));
        }

        private async void AddProjectClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProjectPage());
        }
    }
}
