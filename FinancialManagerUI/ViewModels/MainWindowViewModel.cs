using FinancialManagerUI.Infrastructure.Commands;
using FinancialManagerUI.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace FinancialManagerUI.ViewModels
{
    internal class MainWindowViewModel:ViewModelBase
    {
        #region Open_WPF_Windows
        private void OpenExpenditureWindow()
        {
            ExpenditureMenuWindow expenditureMenuWindow = new ExpenditureMenuWindow();
            OpenWindow(expenditureMenuWindow);
        }

        private void OpenRecieptWindow()
        {
            RecieptMenuWindow recieptMenuWindow = new RecieptMenuWindow();
            OpenWindow(recieptMenuWindow);
        }

        private void OpenHistoryWindow()
        {
            HistoryWindow historyWindow = new HistoryWindow();
            OpenWindow(historyWindow);
        }

        private void OpenWindow(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        #region NameOfApp
        private string _Title = "My Purse";
        /// <summary>
        /// Name of applicATION
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region AddNewCategory
        /// <summary>
        /// name of new category for expenditure or reciept
        /// </summary>
        private string _NewCategory = "";
        public string NewCategory
        {
            get => _NewCategory;
            set => Set(ref _NewCategory, value);
        }
        #endregion

        #region MyBudget
        /// <summary>
        /// Amount of your budget
        /// </summary>
        private string _MyBudget = "0";
        public string MyBudget
        {
            get => _MyBudget;
            set => Set(ref _MyBudget, value);
        }
        #endregion

        #region AmountOfRecieptOrExpenditure
        /// <summary>
        /// Amount of your budget
        /// </summary>
        private string _AmountOfRecieptOrExpenditure = "0";
        public string AmountOfRecieptOrExpenditure
        {
            get => _AmountOfRecieptOrExpenditure;
            set => Set(ref _AmountOfRecieptOrExpenditure, value);
        }
        #endregion

        #region NoteForRecieptOrExpenditure
        /// <summary>
        /// Amount of your budget
        /// </summary>
        private string _NoteForRecieptOrExpenditure = "notes";
        public string NoteForRecieptOrExpenditure
        {
            get => _NoteForRecieptOrExpenditure;
            set => Set(ref _NoteForRecieptOrExpenditure, value);
        }
        #endregion

        #region Commands

        #region Open_WPF_Windows_Commands
        private LambdaCommand openWindow;
        public LambdaCommand OpenExpenditureWindowCommand
        {
            get{ return openWindow ?? new LambdaCommand(obj => { OpenExpenditureWindow(); }); }
        }
        //TODO - command for all 3 windows here
        #endregion


        #region CloseAplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanOnCloseApplicationCommandExecute(object p) => true;//because always available
        #endregion


        #endregion

        public MainWindowViewModel()
        {
            #region Commands
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanOnCloseApplicationCommandExecute);
            #endregion
        }
    }
}