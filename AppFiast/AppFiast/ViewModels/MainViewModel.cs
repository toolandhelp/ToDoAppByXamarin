﻿using AppFiast.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppFiast.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<MenuModel> menuModels;

        public ObservableCollection<MenuModel> MenuModels
        {
            get { return menuModels; }
            set { menuModels = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            MenuModels = new ObservableCollection<MenuModel>();
            menuModels.Add(new MenuModel() { IconFont = "\xe64c", Title = "我的一天", BackColor = "#218868" });
            menuModels.Add(new MenuModel() { IconFont = "\xe632", Title = "重要", BackColor = "#EE3B3B" });
            menuModels.Add(new MenuModel() { IconFont = "\xe613", Title = "已计划日程", BackColor = "#218868" });
            menuModels.Add(new MenuModel() { IconFont = "\xe603", Title = "已分配给你", BackColor = "#EE3B3B" });
            menuModels.Add(new MenuModel() { IconFont = "\xe696", Title = "任务", BackColor = "#218868" });
        }
    }
}
