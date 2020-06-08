using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private Database usersDatabase = App.Database;

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
                     if (isUserNameTaken(username))
                     {
                         await DisplayAlert("Alert", "Username is taken", "OK");
                     }
                     else
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
                             await DisplayAlert("Alert", "Passwords must match", "OK");

                         }
                     }

                 }
                 else
                 {
                     await DisplayAlert("Alert", "Fields cannot be empty", "OK");
                 }
             
         }

          private bool isUserNameTaken(string username)
         {
          
             List<Users> users = usersDatabase.GetPeopleAsync().Result;

             foreach (var user in users)
             {
                 if (user.Username.Equals(username))
                 {
                     return true;
                 }
            }

             return false;
         }
           
         }
    }
