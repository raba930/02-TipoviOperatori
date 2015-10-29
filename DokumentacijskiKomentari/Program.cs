using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(DuljinaDvijeRiječi("dva", "2"));
        }

        /// <summary>
        ///   Izračunava kvadrat broja.
        /// </summary>
        /// <param name="broj">
        ///   Broj čiji kvadrat treba izračunati.
        /// </param>
        /// <returns>
        ///   Zadani broj na kvadrat, tipa <c>double</c>.
        /// </returns>
        static double Kvadrat(double broj)
        {
            return broj * broj;
        }

        /// <summary>
        /// Funkcija ljepi dva stringa i vraća broj slova te dvije rijeci koje su joj prosljeđene
        /// </summary>
        /// <param name="prva">
        /// String Prva rijec
        /// </param>
        /// <param name="druga">
        /// String Druga rijec
        /// </param>
        /// <returns>vrača broj slova prve i druge rečenice</returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return (prva + druga).Length;
        }
    }
}
