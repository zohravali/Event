using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void Func(string word);
    class MyClass
    {
        public void Space(string word)
        {
            StringBuilder word1 = new();
            word1.Append(word[0]);
            for (int i = 1; i < word.Length; i++)
            {
                word1.Append('_');
                word1.Append(word[i]);
            }
            Console.WriteLine(word1);
        }

        public void Reverse(string word)
        {
            StringBuilder word1 = new();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                word1.Append(word[i]);
            }

            Console.WriteLine(word1);
        }
    }

    class Run
    {

        public void RunFunc(Func func, string word)
        {
            func.Invoke(word);
        }
    }
}
