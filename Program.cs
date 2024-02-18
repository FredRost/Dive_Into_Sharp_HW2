namespace Dive_Into_Sharp_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            // Преобразуем двумерный массив в одномерный для сортировки
            int[] flattenedArray = FlattenArray(a);

            // Сортируем одномерный массив
            Array.Sort(flattenedArray);

            // Выводим отсортированные элементы на печать
            Console.WriteLine("Отсортированные данные:");

            for (int i = 0; i < flattenedArray.Length; i++)
            {
                Console.Write(flattenedArray[i] + " ");
                if ((i + 1) % a.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        // Метод для преобразования двумерного массива в одномерный
        static int[] FlattenArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] flattenedArray = new int[rows * cols];
            int k = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flattenedArray[k++] = array[i, j];
                }
            }

            return flattenedArray;
        }
    }
}
