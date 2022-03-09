using System;

namespace overload_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLetter("tasklari yazin","a"));
        }

        static bool HasLetter(string text)
        {
            char letter = 'a';
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    return true;
                }
            }
            return false;
        }



        static bool HasLetter(string text,string word)
        {
          
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (text[i]==word[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
    
}
