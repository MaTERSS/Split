/*
 Дана строка с текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.
 */
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            string text = "Сталкер — это персонаж, исследующий опасные и загадочные зоны," + 
                " наполненные аномалиями и артефактами, в поисках приключений и тайн, часто вдохновленный произведениями литературы и кино.";
            Console.WriteLine($"Исходный текст:\n" + text);
            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}