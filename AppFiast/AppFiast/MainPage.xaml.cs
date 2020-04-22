using AppFiast.Module;
using AppFiast.ViewModels;
using AppFiast.Views;
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
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = new MainViewModel();
        }


        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionView lv = sender as CollectionView;
            var m = lv.SelectedItem as MenuModel;

            if (m == null) return;

            //修改子窗口标题头部颜色
            (App.Current.MainPage as NavigationPage).BarBackgroundColor = Color.FromHex(m.BackColor);
            //(App.Current.MainPage as NavigationPage).BackgroundColor = Color.FromHex(m.BackColor);

            Navigation.PushAsync(new ItemDetailPage()
            {
                Title = m.Title,
                //修改窗体内部颜色
                BackgroundColor = Color.FromHex(m.BackColor),
                BindingContext = new ItemDetailViewModel(m.TaskInfos)
            });

            lv.SelectedItem = null;
        }
    }
}