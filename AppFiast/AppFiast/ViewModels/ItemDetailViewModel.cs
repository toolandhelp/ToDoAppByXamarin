using System;
using System.Collections.ObjectModel;
using AppFiast.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace AppFiast.ViewModels
{
    public class ItemDetailViewModel : ViewModelBase
    {
        public ItemDetailViewModel(ObservableCollection<TaskInfo> TaskInfos)
        {
            this.taskInfos = TaskInfos;

            TaskInfos.Add(new TaskInfo() { Content="既然内容hi宿舍都发" });
            TaskInfos.Add(new TaskInfo() { });
            TaskInfos.Add(new TaskInfo() { });

            //🔘点点击改变操作
            ExcludeCommand = new RelayCommand<TaskInfo>(arg =>
            {
                if (arg.IsDeleted)
                    arg.IsDeleted = false;
                else
                    arg.IsDeleted = true;
            });

            //♥点点击改变操作
            KeppCommand = new RelayCommand<TaskInfo>(arg =>
            {
                if (arg.IsFavorite)
                    arg.IsFavorite = false;
                else
                    arg.IsFavorite = true;
            });
        }

        private ObservableCollection<TaskInfo> taskInfos = new ObservableCollection<TaskInfo>();

        public ObservableCollection<TaskInfo> TaskInfos
        {
            get { return taskInfos; }
            set { taskInfos = value; RaisePropertyChanged(); }
        }


        public RelayCommand<TaskInfo> ExcludeCommand { get; private set; }

        public RelayCommand<TaskInfo> KeppCommand { get; private set; }
    }
}
