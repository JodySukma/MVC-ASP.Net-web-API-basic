using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoalKe_1_WEB.Models
{
    public class HitungModel
    {
        public double Angka1 { get; set; } = 0;
        public double Angka2 { get; set; } = 0;

        public string Operasi { get; set; } = "+";

        public double result
        {
            get
            {
                if (Operasi == "+")
                    return Angka1 + Angka2;
                else if (Operasi == "-")
                    return Angka1 - Angka2;
                else if (Operasi == "*")
                    return Angka1 * Angka2;
                else if (Operasi == "%")
                    return Angka1 % Angka2;
                else if (Operasi == "!")
                    return Faktorial(Angka1);
                else
                    return Angka1 / Angka2;
            }
        }

        public double Faktorial(double nilai_1)
        {
            if (nilai_1 == 1)
                return 1;
            return nilai_1 * Faktorial(nilai_1 - 1);
        }
    }
}
