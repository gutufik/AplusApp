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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void btnSignUpClicked(object sender, EventArgs e)
        {
            User user = new User()
            {
                Login = loginEntry.Text,
                Email = emailEntry.Text,
                Password = passwordEntry.Text
            };
            App.Database.SaveItem(user);

            await Navigation.PopAsync();
        }
    }
}