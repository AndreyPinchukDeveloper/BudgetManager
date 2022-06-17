using BudgetManagerLibrary.Models;

namespace BudgetManagerLibrary
{
    public class ComboBoxDataAccess
    {
        private int count { get; set; }
        //private int 

        public List<string> listOfExpenditures = new List<string>
        {
            "Auto",
            "Medicine",
            "Sport",
            "Family"
        };

        public List<string> listOfReciepts = new List<string>
        {
            "Salary",
            "Dividends",
            "Illegal market :)"
        };

        public List<MoneyModel> GetRecieptList(int total, List<string> list, int length)
        {
            List<MoneyModel> result = new List<MoneyModel>();
            count = list.Count-1;
            for (int i = 0; i < total; i++)
            {
                result.Add(GetReciept((i + 1),list,length));
                count--;
            }
            return result;
        }

        private MoneyModel GetReciept(int id, List<string> data, int length)
        {
            MoneyModel result = new MoneyModel();
            result.NameOfChange = GetItemOfList(data);
            return result;
        }

        private string GetItemOfList (List<string> data)
        {
            return data[count];
        }
    }
}
