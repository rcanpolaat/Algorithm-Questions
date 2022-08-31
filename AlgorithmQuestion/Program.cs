using System;
using System.Collections.Generic;

namespace AlgorithmQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            questions question = new questions();
            //question.printevennumbers();
            //question.printdividednumbers();
            //question.printtoptobottom();
            //question.printnumberofwordsletters();

            Console.ReadLine();
        }
    }

    class questions
    {
        public void printevennumbers()
        {
            int n, m;
            List<int> nums = new List<int>();
            Console.WriteLine("Hi user! Please enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter {0} positive numbers", n);
            for (int i = 0; i < n; i++)
            {
                m = Convert.ToInt32(Console.ReadLine());
                if (m < 0)
                {
                    Console.WriteLine("Number must be positive");
                    i--;
                }
                if (m % 2 == 0 && m>0)
                    nums.Add(m);
            }
            Console.WriteLine("Even numbers from the numbers you entered: ");
            foreach(var num in nums)
            {
                Console.Write(num + " ");
            }
        }

        public void printdividednumbers()
        {
            int n, m, x;
            List<int> nums = new List<int>();
            Console.WriteLine("Hi user! Please enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hi user! Please enter other number");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter {0} positive numbers", n);
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("Number must be positive");
                    i--;
                }
                if (x % m == 0 || x == m)
                    nums.Add(x);
            }
            Console.WriteLine("Numbers dividing by {0} from the numbers you entered: ",m);
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
        }

        public void printtoptobottom()
        {
            int n;
            string x;
            List<string> words = new List<string>();
            Console.WriteLine("Hi user! Please enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter {0} words", n);
            for (int i = 0; i < n; i++)
            {
                x = Console.ReadLine();
                words.Add(x);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }

        public void printnumberofwordsletters()
        {
            string m;
            int x;
            Console.WriteLine("Hi user! Please enter a sentence.");
            m = Console.ReadLine();
            string[] words = m.Split(' ');
            Console.WriteLine("Number of words : {0}", words.Length);
            x = m.Length - (words.Length-1);
            Console.WriteLine("Number of letters : {0}", x);
        }
    }
      
}
