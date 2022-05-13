
//Прижибиток Артем, ІК-13, Варіант 25


namespace laba
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;  /*змінна для голосних літер*/
            int count2 = 0;  /*змінна для приголосних літер*/


            StreamWriter sw = new StreamWriter("D:/1.txt"); /*створення нового файлу*/
            Console.WriteLine("Enter a word or a sentence : ");
            sw.WriteLine(Console.ReadLine()); /*введення слова чи речення*/
            sw.Close(); /*закриття файлу*/

            StreamReader sr = new StreamReader("D:/1.txt"); /*відкривання файлу для читання*/
            string s = File.ReadLines("D:/1.txt").First(); /*перероблення тексту файла у змінну строки*/

            List<char> lines = new List<char>(); /*створення списку типу char*/
            char[] arr = s.ToCharArray(); /*перероблення строки у масив символів*/
            lines.AddRange(arr); /*додавання масиву символів у список символів*/

            for (int i = 0; i < arr.Length; i++) /*проходження по списку символів*/
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u') /*умова додавання голосних літер*/
                {
                    count1++;
                }
                else /*умова додавання приголосних літер*/
                {
                    count2++;
                }
            }

            Console.WriteLine("The number of vowel letters = " + count1); /*виведення кількості голосних літер*/
            Console.WriteLine("The number of consonants letters = " + count2); /*виведення кількості приголосних літер*/
        }

    }
}


