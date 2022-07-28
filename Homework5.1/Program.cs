using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._1
{

    internal class Program
    {
        //Задание 1
        /// <summary>
        /// Метод, который из строки выводит масив слов.
        /// </summary>
        /// <param name="Text">Строковая переменная, которую нужно переобразить в массив</param>
        /// <returns></returns>
        static string[] Textinput(string Text)
        {

            string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           
            return words;
        }
        /// <summary>
        /// Метод который разделяет строку на слова и выводит на экран.
        /// </summary>
        /// <param name="words">Массив, который нужно разделить</param>
        static void Print(string[] words)
        {
            foreach (string c in words)
            { 
                Console.WriteLine(words);
            }
           
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите предложение");
            string Text = Console.ReadLine();
            string[] words = Textinput(Text);
            Print(words);
            Console.ReadKey();



        }
    }
}   
