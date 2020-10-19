﻿using System;
using System.Collections.Generic;
using System.Text;
using WPF_MVVM.ViewModels.Base;

namespace WPF_MVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title window

        private string _Title = "Анализ статистики CV19";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
    }
}