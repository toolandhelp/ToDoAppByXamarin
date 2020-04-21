using AppFiast.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppFiast.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<MenuGroup> menuModels;
        //private ObservableCollection<MenuModel> menuSubModels;

        public ObservableCollection<MenuGroup> MenuModels
        {
            get { return menuModels; }
            set { menuModels = value; RaisePropertyChanged(); }
        }
        //public ObservableCollection<MenuModel> MenuSubModels
        //{
        //    get { return menuSubModels; }
        //    set { menuSubModels = value; RaisePropertyChanged(); }
        //}

        public MainViewModel()
        {
            MenuModels = new ObservableCollection<MenuGroup>();

            MenuModels.Add(new MenuGroup("组一", new List<MenuModel>()
            {
                new MenuModel() { IconFont = "\xe64c", Title = "我的一天", BackColor = "#218868" },
                new MenuModel() { IconFont = "\xe632", Title = "重要", BackColor = "#EE3B3B" },
                new MenuModel() { IconFont = "\xe613", Title = "已计划日程", BackColor = "#218868" },
                new MenuModel() { IconFont = "\xe603", Title = "已分配给你", BackColor = "#EE3B3B" },
                new MenuModel() { IconFont = "\xe696", Title = "任务", BackColor = "#218868" }
             }));

            MenuModels.Add(new MenuGroup("组二", new List<MenuModel>()
            {
                new MenuModel() {  IconFont = "\xe739", Title = "购物清单", BackColor = "#009ACD" },
                new MenuModel() {  IconFont = "\xe739", Title = "杂货清单", BackColor = "#009ACD" },
                new MenuModel() {  IconFont = "\xe739", Title = "待办事项", BackColor = "#009ACD" }
            }));

            //menuModels.Add(new MenuModel() { IconFont = "\xe64c", Title = "我的一天", BackColor = "#218868" });
            //menuModels.Add(new MenuModel() { IconFont = "\xe632", Title = "重要", BackColor = "#EE3B3B" });
            //menuModels.Add(new MenuModel() { IconFont = "\xe613", Title = "已计划日程", BackColor = "#218868" });
            //menuModels.Add(new MenuModel() { IconFont = "\xe603", Title = "已分配给你", BackColor = "#EE3B3B" });
            //menuModels.Add(new MenuModel() { IconFont = "\xe696", Title = "任务", BackColor = "#218868" });

            //menuSubModels = new ObservableCollection<MenuModel>();
            //menuSubModels.Add(new MenuModel() {  Title = "购物清单" });
            //menuSubModels.Add(new MenuModel() {  Title = "杂货清单"});
            //menuSubModels.Add(new MenuModel() {  Title = "待办事项"});


        }
    }
}
