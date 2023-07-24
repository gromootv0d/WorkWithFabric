using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFabric
{
    public class FileReader
    {
        public int[] ReadDataFromFile(string fileName)
        {
            int[] data = null;

            try
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(fileName);

                // Проверяем, что файл содержит хотя бы одну строку
                if (lines.Length == 0)
                {
                    Console.WriteLine("Файл пуст.");
                    return null;
                }

                // Создаем массив для хранения данных
                data = new int[lines.Length];

                // Преобразуем строки в числа и сохраняем в массив
                for (int i = 0; i < lines.Length; i++)
                {
                    if (!int.TryParse(lines[i], out data[i]))
                    {
                        // Если не удалось преобразовать строку в число, выводим ошибку и возвращаем null
                        Console.WriteLine($"Ошибка при чтении данных из файла. Некорректные данные в строке {i + 1}: {lines[i]}");
                        return null;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл '{fileName}' не найден.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении данных из файла: {ex.Message}");
            }

            return data;
        }
    }

    public class FileWriter
    {
        public void WriteDataToFile(string fileName, string sortType, int[] sortedData)
        {
            try
            {
                // Создаем или перезаписываем файл с указанным именем
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Записываем информацию о типе сортировки
                    writer.WriteLine($"Тип сортировки: {sortType}");

                    // Записываем отсортированные данные в файл
                    for (int i = 0; i < sortedData.Length; i++)
                    {
                        writer.WriteLine(sortedData[i]);
                    }
                }

                Console.WriteLine("Данные успешно записаны в файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи данных в файл: {ex.Message}");
            }
        }
    }

}
