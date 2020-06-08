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

        private void Button_OnAdd(object sender, EventArgs e)
        {
            Data toAdd = new Data();
            toAdd.Header = Entry.Text;
            toAdd.Detail = Detail.Text;

            if (toAdd.Header != null && toAdd.Detail != null)
            {
                Datas.Add(toAdd);
                Entry.Text = "";
                Detail.Text = "";
                ListView.ItemsSource = Datas;
            }
        }

        async private void Button_OnLogOut(object sender, EventArgs e)
        {
              var action = await DisplayAlert("Alert",
                "Are you sure you want to Log Out ?",
                "LogOut",
                "Stay");
              if (action)
              {
                  await Navigation.PopAsync();
              }
                
        }


        private void Button_OnRemove(object sender, EventArgs e)
        {
            if (Datas.Count != 0)
            {
                Datas.RemoveAt(Datas.Count - 1);
            }
        }
        
        async private void Update_OnClicked(object sender, EventArgs e)
         {
             if (Datas.Count > 0)
             {
                await Navigation.PushAsync(new UpdatePage(Datas[Datas.Count - 1]));
            }
             
         }

        private static ObservableCollection<Data> datas;
        public static ObservableCollection<Data> Datas 
        {
            get
            {
                return datas ?? (datas = new ObservableCollection<Data>());
            }
            set
            {

            }

        }
    }
}