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
        
        
        int currentIndex; 
        ObservableCollection<Data> update = new ObservableCollection<Data>();
        public UpdatePage(Data data)
        {
            update = data.Datas;
            InitializeComponent();
            Entry.Text = data.Header;
            Detail.Text = data.Detail;
            currentIndex = data.Index;

        }

        Data data = new Data();
        async private void Button_OnClicked(object sender, EventArgs e)
        {
         
            update.RemoveAt(currentIndex - 1);
            data.Header = Entry.Text;
            data.Detail = Detail.Text;
            update.Insert(currentIndex - 1,data);
            data.Datas = update;
            await Navigation.PopAsync();
        }
    }
}