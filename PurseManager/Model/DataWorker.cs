using System;
using PurseManager.Model.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurseManager.Model
{
    public static class DataWorker
    {
        //TODO - create amount of user's money 
        public static string CreateCategory(string name)
        {
            string result = "Already exist";

            using(AppContext db = new AppContext())//check if already exist
            {
                bool checkIsExist = db.MoneyModel.Any(element => element.Name == name);
                if (!checkIsExist)
                {
                    MoneyModel newMoneyModel = new MoneyModel { name = name };//use new class instead of MoneyModel
                    db.MoneyModel.Add(newMoneyModel);
                    db.SavaChanges();
                    result = "done";
                }
                return result;
            }
        }
        //TODO-create change of budget
        public static string CreateChangeOfBudget(string name, decimal value, string note)
        {
            string result = "Already exist";

            using (AppContext db = new AppContext())//check if already exist
            {
                MoneyModel newMoneyModel = new MoneyModel
                {
                    ValueOfMoney = name,
                    NameOfChange = value,
                    Note = note,
                };
                
                db.MoneyModel.Add(newMoneyModel);
                db.SavaChanges();
                result = "done";
                return result;
            }
        }
        //TODO - remove any changes
        public static string RemoveCategory(MoneyModel moneyModel)//use new class instead of MoneyModel
        {
            string result = "Chosen category doesn't exist";
            using(AppContext db = new AppContext())
            {
                db.MoneyModel.Remove(moneyModel);
                db.SaveChanges();
                result = "The category "+ moneyModel.Name + " has deleted.";
            }
            return result;
        }
        //TODO - opportunity to correct any changes

    }
}
