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

            AddCommand = new RelayCommand(AddTask);
            DeleteCommand = new RelayCommand<TaskInfo>(t => DeleteTask(t));
        }

        private ObservableCollection<TaskInfo> taskInfos = new ObservableCollection<TaskInfo>();

        public ObservableCollection<TaskInfo> TaskInfos
        {
            get { return taskInfos; }
            set { taskInfos = value; RaisePropertyChanged(); }
        }

        private string content = string.Empty;

        /// <summary>
        /// 编辑器内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 排除
        /// </summary>
        public RelayCommand<TaskInfo> ExcludeCommand { get; private set; }
        /// <summary>
        /// 收藏
        /// </summary>
        public RelayCommand<TaskInfo> KeppCommand { get; private set; }

        /// <summary>
        /// 添加
        /// </summary>
        public RelayCommand AddCommand { get; private set; }
        /// <summary>
        /// 删除
        /// </summary>
        public RelayCommand<TaskInfo> DeleteCommand { get; private set; }

        public void AddTask()
        {
            if (string.IsNullOrWhiteSpace(Content)) return;
            TaskInfos.Add(new TaskInfo() { Content = Content });
            Content = string.Empty;
        }

        public void DeleteTask(TaskInfo t)
        {
            TaskInfos.Remove(t);
        }
    }
}
