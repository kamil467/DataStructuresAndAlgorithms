using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
   public static class CountNumberOfVowels
    {
        public static void NumberOfVowels()
        {
            // count the vowels irespective of cases.
            string vowels = "aeiou";
            Console.WriteLine("Vowel string {0}", vowels);
            string targetText = "Kamil"; // mix of cases allowed.
            Console.WriteLine("Target Text {0}", targetText);
            var charArrayVowels = vowels.ToLower().ToCharArray();
            var charArrayTargetText = targetText.ToLower().ToCharArray();
            for(int i = 0; i< charArrayVowels.Length; i++)
            {
                var matchCounter = 0;
                for(int j = 0; j< charArrayTargetText.Length; j++)
                {
                    if(charArrayTargetText[j] ==  charArrayVowels[i])
                    {
                        // matched
                        matchCounter++;
                    }
                    
                }
                Console.WriteLine("Character {0} appeared {1} times ", charArrayVowels[i], matchCounter);
            }
            

        }
    }
}
