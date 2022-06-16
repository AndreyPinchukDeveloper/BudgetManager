using System.Windows;

namespace FinancialManagerUI.Infrastructure.Commands.Base
{
    internal class CloseApplicationCommand:Command
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter) => Application.Current.Shutdown();
    }
}
