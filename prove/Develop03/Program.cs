using System;

using System.Collections.Generic;

using System.Linq;

 

namespace ScriptureMemorizer

{

    class Program

    {

        static void Main(string[] args)

        {

            var scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

            while (!scripture.AllWordsHidden())

            {

                Console.Clear();

                scripture.Display();

                Console.WriteLine("Press ENTER to hide a word or type 'quit' to exit:");

                var input = Console.ReadLine();

                if (input?.ToLower() == "quit")

                {

                    break;

                }

                scripture.HideWords();

            }

            Console.Clear();

            Console.WriteLine("Congratulations! All words have been hidden.");

        }

    }
class Reference

    {

        public string Book { get; }

        public int Chapter { get; }

        public int StartVerse { get; }

        public int? EndVerse { get; }

 

        public Reference(string book, int chapter, int startVerse, int? endVerse = null)

        {

            Book = book;

            Chapter = chapter;

            StartVerse = startVerse;

            EndVerse = endVerse;

        }

 

        public override string ToString()

        {

            return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";

        }

    }

 

    class Word

    {

        public string Text { get; }

        public bool IsHidden { get; set; }

 

        public Word(string text)

        {

            Text = text;

        }

    }

 

    class Scripture

    {

        public Reference Reference { get; }

        private List<Word> Words { get; }

 

        public Scripture(Reference reference, string text)

        {

            Reference = reference;

            Words = text.Split(' ').Select(word => new Word(word)).ToList();

        }

 

        public void Display()

        {

            Console.WriteLine($"{Reference}\n{string.Join(" ", Words.Select(word => word.IsHidden ? "____" : word.Text))}\n");

        }

 

        public void HideWords(int count = 1)

        {

            var visibleWords = Words.Where(word => !word.IsHidden).ToList();

            var random = new Random();

            for (int i = 0; i < Math.Min(count, visibleWords.Count); i++)

            {

                var wordToHide = visibleWords[random.Next(visibleWords.Count)];

                wordToHide.IsHidden = true;

            }

        }

 

        public bool AllWordsHidden()

        {

            return Words.All(word => word.IsHidden);

        }

    }

}


 

