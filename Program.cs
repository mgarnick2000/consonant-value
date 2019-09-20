using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace consonant_value
{
    class Program
    {
        static void Main(string[] args)
        {
            // string z = "zodiac";
            // string c = "chruschtschov";
            // string k = "khrushchev";
            string s = "strength";
            // string cp = "catchphrase";
            // string twelfth = "twelftstreet";
            // string m = "mischtschenkoana";
            // Solve(z);
            Solve(s);
            // Solve(c);
            // Solve(k);
        }

        static int Solve(string s)
        {
            Dictionary<char, int> alpha = new Dictionary<char, int>();
            alpha.Add('a', 1);
            alpha.Add('b', 2);
            alpha.Add('c', 3);
            alpha.Add('d', 4);
            alpha.Add('e', 5);
            alpha.Add('f', 6);
            alpha.Add('g', 7);
            alpha.Add('h', 8);
            alpha.Add('i', 9);
            alpha.Add('j', 10);
            alpha.Add('k', 11);
            alpha.Add('l', 12);
            alpha.Add('m', 13);
            alpha.Add('n', 14);
            alpha.Add('o', 15);
            alpha.Add('p', 16);
            alpha.Add('q', 17);
            alpha.Add('r', 18);
            alpha.Add('s', 19);
            alpha.Add('t', 20);
            alpha.Add('u', 21);
            alpha.Add('v', 22);
            alpha.Add('w', 23);
            alpha.Add('x', 24);
            alpha.Add('y', 25);
            alpha.Add('z', 26);


            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int vposition = s.IndexOfAny(vowels);

            string str = s.Substring(0, vposition);
            
            int nextv = s.IndexOfAny(vowels, vposition + 1);

            int nc = vposition + 1;

            int flength = s.Length - vposition - 1;

            string fstr = s.Substring(nc, flength);

            int nextstrl = nextv - nc;

            string nxstr = nextstrl > 0 ? s.Substring(nc, nextstrl) : fstr;
            int res = 0;
            
            int total = 0;

            for ( int j = 0; j < nxstr.Length; j++) {
                int w = alpha[nxstr[j]];
                res = res + w;
            }

            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int v = alpha[str[i]];
                result = result + v;
            }

            if (result > res) {
                total = result;
            } else {
                total = res;
            }
            WriteLine(total);
            return total;
        }
    }
}
