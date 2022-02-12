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
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage(Project project)
        {
            InitializeComponent();
            Title = "Контакты";
            phoneEntry.Text = project.PhoneNumber;
            emailntry.Text = project.Email;
            addressEntry.Text = project.Address;
        }
    }
}