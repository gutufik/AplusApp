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
    public partial class AboutProjectPage : ContentPage
    {
        public string projectDescription { get; set; }
        public AboutProjectPage(Project project)
        {
            InitializeComponent();
            projectDescription = project.Description;
            Title = "О проекте";
            BindingContext = this;
        }
    }
}