using BudgetManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagerLibrary
{
    public class DataAccess
    {
        Random random = new Random();

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
            for (int i = 0; i < total; i++)
            {
                result.Add(GetReciept((i + 1),list,length));
            }
            return result;
        }

        private MoneyModel GetReciept(int id, List<string> data, int length)
        {
            MoneyModel result = new MoneyModel();
            result.NameOfChange = GetItemOfList(data, length);
            return result;
        }

        private string GetItemOfList (List<string> data, int length)
        {
            return data[random.Next(0, length)];
        }
    }
}
