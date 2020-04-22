using AppFiast.Module;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppFiast.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Checklists = new ObservableCollection<Checklist>();
            Checklists.Add(new Checklist() { IconFont = "\xe64c", Title = "我的一天", BackColor = "#218868", });
            Checklists.Add(new Checklist() { IconFont = "\xe632", Title = "重要", BackColor = "#EE3B3B", });
            Checklists.Add(new Checklist() { IconFont = "\xe613", Title = "已计划日程", BackColor = "#218868", });
            Checklists.Add(new Checklist() { IconFont = "\xe603", Title = "已分配给你", BackColor = "#EE3B3B", });
            Checklists.Add(new Checklist() { IconFont = "\xe696", Title = "任务", BackColor = "#218868", });
            Checklists.Add(new Checklist() { IconFont = "\xe739", Title = "购物清单", BackColor = "#009ACD", });
            Checklists.Add(new Checklist() { IconFont = "\xe739", Title = "杂货清单", BackColor = "#009ACD", });
            Checklists.Add(new Checklist() { IconFont = "\xe739", Title = "待办事项", BackColor = "#009ACD", });

        }



        private ObservableCollection<Checklist> checklists;
        public ObservableCollection<Checklist> Checklists
        {
            get { return checklists; }
            set { Checklists = value; RaisePropertyChanged(); }
        }
    }
}
