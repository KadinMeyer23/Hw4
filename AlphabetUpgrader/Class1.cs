//Kadin Meyer
//2/18/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetUpgrader
{
    public class AlphaUpgrade
    {


        public string Alpha_Upgrader(string sentence) {

            string newSentence = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ') { newSentence += " "; }
                else
                {

                    int CharAscii = (int)sentence[i];
                    CharAscii += 1;
                    newSentence = newSentence + (char)CharAscii;
                }
            }
            return newSentence;
        }


    }
}
