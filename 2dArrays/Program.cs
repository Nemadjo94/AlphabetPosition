using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrays
{
    class Program
    {
        
            public static string AlphabetPosition(string text)
            {
                string upperText = text.ToUpper();
                string result = "";

                Dictionary<char, int> dic = new Dictionary<char, int>()
                {
                  {'A',1}, {'B',2}, {'C',3}, {'D',4}, {'E',5},
                  {'F',6}, {'G',7}, {'H',8}, {'I',9}, {'J',10},
                  {'K',11}, {'L',12}, {'M',13}, {'N',14}, {'O',15},
                  {'P',16}, {'Q',17}, {'R',18}, {'S',19}, {'T',20},
                  {'U',21},  {'V',22}, {'W',23}, {'X',24}, {'Y',25},
                  {'Z',26},
                };              

                foreach(char c in upperText)
                {
                if (dic.ContainsKey(c))
                {
                    
                    
                       //result += " ";
                    

                    result += dic[c] + " ";
                }
                else continue;
                }
                return result;
            

        }
            static void Main(string[] args)
        {
            string sentence = "The sunset sets at twelve o' clock.";

            Console.WriteLine(AlphabetPosition(sentence));
        }
    }
}
