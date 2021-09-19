using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task3
{
    class User
    {
        public int step { get; private set; }

        public void MakeTurn(string[] possibleSteps)
        {
            try
            {
                string str;
                str = Console.ReadLine();
                if (str == "?")
                {
                    GUI.ShowHelpTable(possibleSteps);
                    str = Console.ReadLine();
                }
                step = int.Parse(str);
                if (step < 0 || step > possibleSteps.Length)
                {
                    throw new Exception("Incorrect users input");
                }
            }
            catch
            {
                throw new Exception("Incorrect users input");
            }

        }

    }
}
