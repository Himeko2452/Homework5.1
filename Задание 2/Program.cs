using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        /// <summary>
        /// Метод разделяющий слова в предложении
        /// </summary>
        /// <param name="Text">Строковая переменная, которую нужно разделить в массив</param>
        /// <returns></returns>
        static string SplitWords(string Text)
        {
            string[] arrayWord = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var e in arrayWord)
            {
                Console.WriteLine(e);
            }
            string newText = ReverseWords(arrayWord);
            return newText;
        }
        /// <summary>
        /// Метод меняющий слова местами
        /// </summary>
        /// <param name="Text">Массив, слова которого необходимо поменять местами </param>
        /// <returns></returns>
        static string ReverseWords(string[] Text)
        {
            Array.Reverse(Text);
            string newString = string.Join(" ", Text);
            return newString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string inputPhrase = Console.ReadLine();

            inputPhrase = SplitWords(inputPhrase);
            Console.WriteLine(inputPhrase);
            
            Console.ReadKey();
        }
    }
}      