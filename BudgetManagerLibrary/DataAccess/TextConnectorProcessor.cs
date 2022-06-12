using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BudgetManagerLibrary.Models;

namespace BudgetManagerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            //D:\Project\BudgetManager\MoneyModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";//reference to App.config
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<MoneyModel> ConvertToMoneyModel(this List<string> lines)
        {
            List<MoneyModel> output = new List<MoneyModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MoneyModel p = new MoneyModel();
                p.Id = int.Parse(cols[0]);
                p.ValueOfMoney = decimal.Parse(cols[1]);
                p.NameOfChange = cols[2];
                p.Note = cols[3];
                output.Add(p);
            }

            return output;
        }

        public static void SaveToModelFile(this List<MoneyModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (MoneyModel m in models)
            {
                lines.Add($"{m.Id},{m.ValueOfMoney},{m.NameOfChange},{m.Note}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }
    }
}
