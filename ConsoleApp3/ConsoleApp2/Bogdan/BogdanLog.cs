using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan
{
    class BogdanLog : core.LogAbscract, core.LogInterface1
    {
        private static BogdanLog instance;
        List<string> list = new List<string>();
        

        public BogdanLog()
        {
        }

        public static BogdanLog getIntance()
        {
            if (instance == null)
                instance = new BogdanLog();
            return instance;
        }

        public core.LogInterface1 log(string str)
        {
            list.Add(str);
            return this;
        }

     
        public core.LogInterface1 write()
        {
            writeConsole(list.ToArray());
            return this;
        }
    }
}
