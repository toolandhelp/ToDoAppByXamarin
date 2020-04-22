using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFiast.Module
{
    public partial class ChecklistDetail
    {
        public string Id { get; set; }
        public string ChecklistId { get; set; }
        public string Content { get; set; }

    }

    public partial class ChecklistDetail : ViewModelBase
    {
        private bool isDeleted;
        private bool isFavorite;


        /// <summary>
        /// 删除
        /// </summary>
        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 收藏
        /// </summary>
        public bool IsFavorite
        {
            get { return isFavorite; }
            set { isFavorite = value; RaisePropertyChanged(); }

        }
    }
}
