using Microsoft.Extensions.DependencyInjection;
using System;

namespace DateAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                DateTime date = DateTime.MinValue;
                int day = 0;
                var container = Startup.ConfigureService();
                var dateAddService = container.GetRequiredService<IDateAddService>();
                var Mdate = container.GetRequiredService<IManipulateDateService>();
                Console.WriteLine($"Enter the date in dd-mm-yyyy:{date}");
                date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine($"Enter the day(s) to add:{day}");
                day = Convert.ToInt32(Console.ReadLine());
                var result = dateAddService.AddDateToInputDate(date, day);
                var mres = Mdate.ManipulatedDate(date, day);
                Console.WriteLine(result);
                Console.WriteLine(mres);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Follow the specified input format!");
                //throw ex;
            }
            
        }
    }
}
