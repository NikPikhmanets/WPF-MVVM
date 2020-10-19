using System.Windows;
using System.Windows.Input;
using WPF_MVVM.Infrastructure.Commands;
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

        #region Status :string - Status application

        private string _Status = "Done!";

        public string Status { 
            get => _Status; 
            set => Set(ref _Status, value);
        }
        #endregion

        #region Commands

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion
        }
    }
}
