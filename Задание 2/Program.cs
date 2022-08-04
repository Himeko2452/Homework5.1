using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
   /// <summary>
        /// Метод разделяющий слова в предложении
        /// </summary>
        /// <param name="Text">Строковая переменная, которую нужно разделить в массив</param>
        /// <returns></returns>


        static string[] SplitWords(string Text)
        {
            string[] arrayWord = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        
            return arrayWord;
        }
        /// <summary>
        /// Метод меняющий слова местами
        /// </summary>
        /// <param name="Text">Массив, слова которого необходимо поменять местами </param>
        /// <returns></returns>

        

        static string ReverseWords(string Text)
        {
            string[] arrayWord = SplitWords(Text);
            foreach (var e in arrayWord)
            {
                Console.WriteLine(e);
            }
            Array.Reverse(arrayWord);
            string newString = string.Join(" ", arrayWord);

            return newString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string inputPhrase = Console.ReadLine();
            string arrayWord = ReverseWords(inputPhrase);
            Console.WriteLine(arrayWord);            
            Console.ReadKey();
        }
    }
}      
