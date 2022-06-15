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
        #region NameOfSomething
        private string _Title = "MyWindow";
        /// <summary>
        /// Name of something
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region NewCategory
        private string _NewCategory = "";
        public string NewCategory
        {
            get => _NewCategory;
            set => Set(ref _NewCategory, value);
        }
        #endregion
    }
}
