using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
           
        }


        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        
        
         private async void Button_OnClicked(object sender, EventArgs e)
         {
             
            string username = UsernameLogin.Text;
            string password = PasswordLogin.Text;

             if (username != null && password != null)
             {
                 await Navigation.PushAsync(new Task());
                 UsernameLogin.Text = "";
                 PasswordLogin.Text = "";
             }
             else
             {
                 
                 DisplayAlert("Alert", "Username and Password cannot be empty", "OK");
             }
            
         }

       
    }
}
