using System;
using System.Collections.Generic;
using System.Linq;

namespace AddHocW2_D2
{
    class Program
    {
        List<string> people = new List<string>();
        static void Main(string[] args)
        {
            List<string> people = new List<string>();
            people.Add("Martti");
            people.Add("Elli");
            people.Add("Paavo");
            people.Add("Hugo");

            IEnumerable<string> demo = people.Where(p => p.Length > 4);

            people[1] = "Girl Power";
            

            foreach (string name in demo)
            {
                Console.WriteLine(name);
            }


            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");

            IEnumerable<string> demo2 = (IEnumerable<string>)Month;
            
            
            IEnumerator<string> demo3 = Month.GetEnumerator();

            while(demo3.MoveNext())
            {
                Console.WriteLine(demo3.Current);
            }

            /*Console.WriteLine(Environment.NewLine);

            foreach(string kuukausi in demo2)
            {
                Console.WriteLine(kuukausi);
            }*/

        }

        public IEnumerable<string> testiMetodi(string haku)
        {
            IEnumerable<string> demo = people.Where(p => p.Contains(haku));
            return demo;
        }

        static public void muuta(string muutos, List<string> testi)
        {
            testi[0] = muutos;
        }
    }
}
