using FinancialManagerUI.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerUI.ViewModels
{
    internal class MainWindowViewModel:ViewModelBase
    {
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
    }
}
