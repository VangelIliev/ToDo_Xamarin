using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ToDo
{
     public class Data
    {
        public string Header { get; set; }
        public string Detail { get; set; }
        public int Index { get; set; }
        private ObservableCollection<Data> data;

        
        public ObservableCollection<Data> Datas // delete add 
        {
            get
            {
                return data ?? (data = new ObservableCollection<Data>());
            }
            set
            {

            }
            
        }
    }
}
