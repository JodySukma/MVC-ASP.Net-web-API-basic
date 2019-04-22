using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace SoalKe_1_WEB.Models
{
    public class HitungServiceModel
    {
        public string Url { get; set; } = @"http://localhost:2000/api/Hitung/";

        public double Penjumlahan(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Penjumlahan/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Pengurangan(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Pengurangan/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Perkalian(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Perkalian/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Pembagian(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Pembagian/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double HasilBagi(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"HasilBagi/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Faktorial(double nilai)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Faktorial/{nilai}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Ganjil(double nilai)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Ganjil/{nilai}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Genap(double nilai)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Genap/{nilai}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }
    }
}
