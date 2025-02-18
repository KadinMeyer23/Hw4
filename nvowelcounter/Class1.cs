//Kadin Meyer
//2/18/2025
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nvowelcounter
{
    public class VowCount
    {


        public string find_vowels(string sentence, int count) {
            string newstring = string.Empty;
            for (int i=0; i < sentence.Length; i++) {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o'|| sentence[i] == 'u' || sentence[i] == 'A' || sentence[i] == 'E' 
                    || sentence[i] == 'I' || sentence[i] == 'U'||sentence[i] == 'O' )
                {
                    newstring += sentence[i];
                }
            
            
            }
            if (newstring.Length < count) { return "Invalid"; }

            string new_string2 = "";

            for (int i = 0; i < count; i++)
            {
                new_string2 += newstring[i];
            }


            return new_string2; }
    }
}
