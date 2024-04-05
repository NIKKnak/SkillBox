using Methods.DZ1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.DZ2
{
    internal class ReversString
    {
        public void ReversStringText(string inputString)
        {

            SplitText splitText = new SplitText();
            string[] brokenString = splitText.SplitInputText(inputString);

            int a = brokenString.Length;

            StringBuilder sb = new StringBuilder(50);

            while (a >0)
            {
                sb.Append(brokenString[a-1] + " ");
                a--;
            }

            Console.WriteLine(sb);

        }






    }
}
