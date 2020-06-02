using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

         async private void Button_OnClicked(object sender, EventArgs e)
         {

             string username = UsernameRegister.Text;
             string password = PasswordRegister.Text;
             string repeatPassword = RepeatPassword.Text;
             string email = EmailRegister.Text;
             
                 if (username != null && password != null && email != null && repeatPassword != null)
                 {
                     if (password == repeatPassword)
                     {
                         var user = new Users()
                         {
                             Email = EmailRegister.Text,
                             Password = PasswordRegister.Text,
                             Username = UsernameRegister.Text
                         };
                         await App.Database.SaveUsersAsync(user);
                         await Navigation.PopAsync();
                     }
                     else
                     {
                         DisplayAlert("Alert", "Passwords must match", "OK");

                     }

                 }
                 else
                 {
                     DisplayAlert("Alert", "Fields cannot be empty", "OK");
                 }
         }

             
           
         }
    }
