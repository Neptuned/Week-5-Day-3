using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstDatabase db = new MyFirstDatabase();
            db.Database.Log = s => Console.WriteLine(s);
            var maleGender = db.Genders.First(x => x.abbr == "M");

            var allMalePandas = maleGender.Pandas.ToList();
            Console.ReadLine();

        }
    }
}
