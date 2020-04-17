using AppFiast.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFiast
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            lv.SelectedItem = null;
        }

        private void ListViewSub_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            lv.SelectedItem = null;
        }
    }
}