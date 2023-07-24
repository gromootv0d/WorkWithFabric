using System.Text;
using WorkWithFabric;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введите тип сортировки (selection, insertion или merge):");
        string sortType = Console.ReadLine();

        Console.WriteLine("Введите имя файла с входными данными:");
        string inputFileName = Console.ReadLine();

        Console.WriteLine("Введите имя файла с выходными данными:");
        string outputFileName = Console.ReadLine();

        int[] data;


        // Чтение данных из файла
        FileReader fileReader = new FileReader();
        data = fileReader.ReadDataFromFile(inputFileName);

        // Выбор фабрики сортировки в зависимости от аргумента sortType
        SortFactory factory;
        switch (sortType)
        {
            case "selection":
                factory = new SelectionSortFactory();
                break;
            case "insertion":
                factory = new InsertionSortFactory();
                break;
            case "merge":
                factory = new MergeSortFactory();
                break;
            default:
                Console.WriteLine("Invalid sort type.");
                return;
        }

        // Сортировка и запись данных в файл
        Sorter sorter = new Sorter(factory);
        sorter.Sort(data);

        FileWriter fileWriter = new FileWriter();
        fileWriter.WriteDataToFile(outputFileName, sortType, data);

        Console.WriteLine("Sorting completed and data written to the output file.");
    }
}
