using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace Bogdan
{
    class Program: SquareCalculation
    {
        static void Main(string[] args)
        {

            try
            {
                Bogdan.LinearCalculation a1 = new Bogdan.LinearCalculation();
                Bogdan.SquareCalculation b1 = new Bogdan.SquareCalculation();


                Console.WriteLine("Введите корни уравнения (a, b, c):");

                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());


                List<double> solution = b1.solve(a, b, c);
                BogdanLog.getIntance().log("Решение: " + string.Join(",", solution)).write();
                Console.ReadLine();
                
            }
            catch (BogdanExeption e)
            {
                BogdanLog.getIntance().log(e.Message);
            }
            

            
            

        }

        public LogInterface1 log(string str)
        {
            throw new NotImplementedException();
        }

        public LogInterface1 write()
        {
            throw new NotImplementedException();
        }

        [Serializable]
        private class BogdanExeption : System.Exception
        {
            public BogdanExeption()
            {
            }

            public BogdanExeption(string message) : base(message)
            {
            }

            public BogdanExeption(string message, System.Exception innerException) : base(message, innerException)
            {
            }

            protected BogdanExeption(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }

   
}   

    

