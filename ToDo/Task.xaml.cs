using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace ToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Task : ContentPage
    {
       
        
        public Task()
        {
            InitializeComponent();
            
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

         Data data = new Data();
         private int index = 0;
        private void Button_OnAdd(object sender, EventArgs e)
        {
            
            string header = Entry.Text;
            string detail = Detail.Text;
            

            data.Header = header;
            data.Detail = detail;
            
            if (header != null && detail != null)
            {
                data.Datas.Add(data);
                Entry.Text = "";
                Detail.Text = "";
                data.Index++;
            }

            ListView.ItemsSource = data.Datas;


        }

        async private void Button_OnLogOut(object sender, EventArgs e)
        {
              var action = await DisplayAlert("Alert",
                "Are you sure you want to Log Out ?",
                "LogOut",
                "Stay");
              if (action)
              {
                // problem to solve Clear username and password when loggout
                await Navigation.PopAsync();
              }
                
        }


        private void Button_OnRemove(object sender, EventArgs e)
        {
            data.Datas.Remove(data);

        }

         async private void Button_OnUpdate(object sender, EventArgs e)
        {
           
            
            ListView.ItemsSource = data.Datas;
            await Navigation.PushAsync(new UpdatePage(data));
        }

        
      

         private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
         {
            var indexOf = data.Datas.IndexOf(e.SelectedItem as Data);
         }
    }
}