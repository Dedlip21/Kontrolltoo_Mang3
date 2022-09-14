using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    class Tegelane : Uksus, IComparable<Tegelane>
    {
        private string nimi;
        private List<Ese> eseList = new List<Ese>();

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public int punktideArv()
        {
            //tagastab tegelase esemete punktide arvude summa
            throw new NotImplementedException();
        }

        public string info()
        {
            double end = 0;
            Console.WriteLine($"{nimi}");
            foreach (string line in File.ReadLines(@"..\..\..\Esemed.txt"))
            {
                if (eseList.Count() == 3)  continue; 

                string[] row = line.Split(";");
                end += double.Parse(row[1]);
                Ese ese = new Ese(row[0], int.Parse(row[1]));
                eseList.Add(ese);
                Console.WriteLine(row[0] + " " + row[1]);
            }
            Console.WriteLine(eseList.Count());
            Console.WriteLine(end);
            return ($"{nimi}");
        }

        public int LisaEse(int punkt_arv)
        {
            //double end = 0;
            //Console.WriteLine($"{nimi}");
            foreach (string line in File.ReadLines(@"..\..\..\Esemed.txt"))
            {
                //if (eseList.Count() == 3)  continue; 

                string[] row = line.Split(";");
                punkt_arv += int.Parse(row[1]);
                Ese ese = new Ese(row[0], int.Parse(row[1]));



                eseList.Add(ese);
                Console.WriteLine(row[0] + " " + row[1]);
            }
            Console.WriteLine("Choose you item");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(eseList[choice].info());
            Console.WriteLine(punkt_arv);

            return punkt_arv;
        }

        public int CompareTo(Tegelane? other)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) return 1;

            // The temperature comparison depends on the comparison of
            // the underlying Double values.
            return nimi.CompareTo(other.nimi);
        }

        public void väljastaEsemed()
        {
            //väljastatakse ekraanile tegelase esemed nii, et iga ese on eraldi real.
        }
    }
}
