using System;
using System.Collections.ObjectModel;
using AppFiast.Models;
using GalaSoft.MvvmLight;

namespace AppFiast.ViewModels
{
    public class ItemDetailViewModel : ViewModelBase
    {
        public ItemDetailViewModel(ObservableCollection<TaskInfo> TaskInfos)
        {
            this.taskInfos = TaskInfos;

            TaskInfos.Add(new TaskInfo() { });
            TaskInfos.Add(new TaskInfo() { });
            TaskInfos.Add(new TaskInfo() { });
        }

        private ObservableCollection<TaskInfo> taskInfos = new ObservableCollection<TaskInfo>();

        public ObservableCollection<TaskInfo> TaskInfos
        {
            get { return taskInfos; }
            set { taskInfos = value; RaisePropertyChanged(); }
        }
    }
}
