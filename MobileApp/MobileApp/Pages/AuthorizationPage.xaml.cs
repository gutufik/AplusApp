using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobileApp.DataBase;

namespace MobileApp
{
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        private async void btnSignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        private async void btnLoginClicked(object sender, EventArgs e)
        {
            var user = App.Database.GetItems().Where(u => u.Login == loginEntry.Text && u.Password == passwordEntry.Text).ToList();
            if ( user.Count != 0)
            {
                await Navigation.PushAsync(new ProjectsPage());
            }    
            else
            {
                await DisplayAlert("Ошибка авторизации", "Неверный логин или пароль", "Закрыть");
            }
        }
    }
}
