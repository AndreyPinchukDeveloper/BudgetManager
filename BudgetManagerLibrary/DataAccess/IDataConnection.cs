using BudgetManagerLibrary.Models;

namespace BudgetManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        MoneyModel CreateChange(MoneyModel model);
        
    }
}
