using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSalariuAlexandra
{
    class WageCalculator
    {
        public void HoursCalculator6()
        {
            string[] days = new string[] { "Miercuri", "Joi", "Vineri", "Sambata", "Duminica" };
            double TotalPay = 0;
           // Console.WriteLine("Cat castigi pe ora?");
            double payRate/* = Convert.ToDouble(Console.ReadLine())*/;
            double HoursPaid;
            double Payday = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("La ce ora ai intrat {0}?", days[i]);

                string starttime = Console.ReadLine();

                TimeSpan spanStart = TimeSpan.Parse(starttime);

                Console.WriteLine("La ce ora ai iesit {0}?", days[i]);
                string endtime = Console.ReadLine();
                TimeSpan spanEnd = TimeSpan.Parse(endtime);

                Console.WriteLine("Cat ai avut pauza?");
                double pauza = Convert.ToDouble(Console.ReadLine());

                if (spanEnd > spanStart)
                {
                    TimeSpan TotalHoursAtWork = (spanEnd - spanStart);
                    HoursPaid = TotalHoursAtWork.TotalHours - pauza;
                    Console.WriteLine(HoursPaid);
                    payRate = 9.4;
                    TotalPay = payRate * HoursPaid;
                    Console.WriteLine("Ai de luat {0} pentru {1}", TotalPay, days[i]);

                }
                else if (spanStart > spanEnd)
                {
                    TimeSpan TotalHoursAtWork = (spanStart - spanEnd);
                    HoursPaid = TotalHoursAtWork.TotalHours - pauza;
                    Console.WriteLine(HoursPaid);
                    payRate = 9.4;
                    TotalPay = payRate * HoursPaid;
                    Console.WriteLine("Ai de luat {0} pentru {1}", TotalPay, days[i]);

                }
                Payday += TotalPay;
            }

            Console.WriteLine("In total, saptamana asta ai castigat {0} de Lire.", Payday);
            Console.ReadLine();

        }
    }
}
