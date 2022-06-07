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

        public static List<string> listOfExpenditures = new List<string>
        {
            "Auto",
            "Medicine",
            "Sport",
            "Family"
        };

        public static List<string> listOfReciepts = new List<string>
        {
            "Salary",
            "Dividends",
            "Illegal market :)"
        };

        public List<RecieptsCategoryModel> GetRecieptList()
        {
            List<RecieptsCategoryModel> result = new List<RecieptsCategoryModel>();
            int total = listOfReciepts.Count;
            for (int i = 0; i < total; i++)
            {
                result.Add(GetReciept(i + 1));
            }
            return result;
        }

        private RecieptsCategoryModel GetReciept(int id)
        {
            RecieptsCategoryModel result = new RecieptsCategoryModel();
            result.NameOfReciept = GetItemOfList(listOfReciepts);
            return result;
        }

        private string GetItemOfList (List<string> data)
        {
            return data[random.Next(0, listOfReciepts.Count)];
        }
    }
}
