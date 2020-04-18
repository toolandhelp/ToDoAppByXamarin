using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppFiast.Models;
using AppFiast.ViewModels;

namespace AppFiast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            xlayout.IsVisible = false;

            btnAdd.Clicked += BtnAdd_Clicked;
            xEdit.Unfocused += XEdit_Unfocused;
        }

        private void XEdit_Unfocused(object sender, FocusEventArgs e)
        {
            btnAdd.IsVisible = true;
            xlayout.IsVisible = false;
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            btnAdd.IsVisible = false;
            xlayout.IsVisible = true;

            xEdit.Focus();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            lv.SelectedItem = null;
        }
    }
}