using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Last_flipper
{
    public class chars_flipper
    {


        public string flipper(string sentence) {

            char fc = sentence[0];
            int length = sentence.Length;
            char lc = sentence[length - 1];
            string new_string = "";
            new_string += lc;


            if (sentence.Length < 2) { return "Incomparible"; }
            else if (fc == lc) { return "Two's a pair"; }



            for (int i = 1; i < (length - 1); i++)
            {
                new_string += sentence[i];
            }
            new_string += fc;
            
            
            
            
            return new_string; }
    }
}
