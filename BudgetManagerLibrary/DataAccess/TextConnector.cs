using BudgetManagerLibrary.Models;
using BudgetManagerLibrary.DataAccess.TextHelpers;

namespace BudgetManagerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string ModelsFile = "MoneyModel.csv";
        /// <summary>
        /// Save data changes in the text file
        /// </summary>
        public MoneyModel CreateChange(MoneyModel model)
        {
            // Load text file
            // Convert the text to List<MoneyModel>
            List<MoneyModel> models = ModelsFile.FullFilePath().LoadFile().ConvertToMoneyModel();

            // Find the max ID
            int currentId = 0 + 1;

            if (models.Count > 0)
            {
                currentId = models.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // ADD the new record with the new ID (max + 1)
            models.Add(model);

            // Convert the money to list<string>
            // Save the list<string> to the text file
            models.SaveToModelFile(ModelsFile);

            return model;
        }
    }
}
