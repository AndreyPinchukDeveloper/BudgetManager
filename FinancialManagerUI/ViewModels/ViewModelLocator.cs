using Microsoft.Extensions.DependencyInjection;

namespace FinancialManagerUI.ViewModels
{
    class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>();//add main(in charge) model main window
    }
}
