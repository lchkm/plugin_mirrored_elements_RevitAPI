using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using IsMirroredPlugin;





namespace IsMirroredFinder
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class StartClassFinder : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            // Получаем документ в котором будем искать отзеркаленные элементы
            Document doc = commandData.Application.ActiveUIDocument.Document;

            // Находим все отзеркаленные элементы(Family Instance)
            var allFamilyInstances = new FilteredElementCollector(doc)
                .OfClass(typeof(FamilyInstance))
                .Cast<FamilyInstance>()
                .Where(fi => fi.Mirrored)
                .ToList();

            // Получаем количество отзеркаленных элементов
            int countOfMirroredElements = allFamilyInstances.Count;

            // Создаем и показываем интерфейс
            IsMirroredUI mirroredWPF = new IsMirroredUI(countOfMirroredElements);
            mirroredWPF.Show();

            return Result.Succeeded;
        }
    }
}