using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    class LogAbscract
    {
        protected String formatLog(string[] strings)
        {
            return String.Join(";n/r", strings);
        }

        protected void writeConsole(String s)
        {
            Console.WriteLine(s);
        }

        protected void writeConsole(String[] s)
        {
            Console.WriteLine(formatLog(s));
        }
    }
}
