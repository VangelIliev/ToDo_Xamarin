using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdatePage : ContentPage
    {
        
        
        
     
        public UpdatePage(Data data)
        {
            InitializeComponent();
        }

         Data data = new Data();
         
        async private void Button_OnClicked(object sender, EventArgs e)
        {
            data.Header = Entry.Text;
            data.Detail = Detail.Text; 
            Task.Datas.Insert(Task.Datas.Count - 1,data);
            Task.Datas.RemoveAt(Task.Datas.Count - 1);
            await Navigation.PopAsync();
        }
    }
}