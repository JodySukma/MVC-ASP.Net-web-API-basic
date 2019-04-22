using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SoalKe_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : ControllerBase
    {
        
        // Penjumlahan
        [HttpGet("Pertambahan/{nilai_1}/{nilai_2}")]
        public int Pertambahan(int nilai_1, int nilai_2) => nilai_1 + nilai_2;

        // Pengurangan
        [HttpGet("Pengurangan/{nilai_1}/{nilai_2}")]
        public int Pengurangan(int nilai_1, int nilai_2) => nilai_1 - nilai_2;

        // Perkalian
        [HttpGet("Perkalian/{nilai_1}/{nilai_2}")]
        public int Perkalian(int nilai_1, int nilai_2) => nilai_1 * nilai_2;

        // Pembagian
        [HttpGet("Pembagian/{nilai_1}/{nilai_2}")]
        public int Pembagian(int nilai_1, int nilai_2) => nilai_1 / nilai_2;

        // hasil bagi
        [HttpGet("HasilBagi/{nilai_1}/{nilai_2}")]
        public int HasilBagi(int nilai_1, int nilai_2) => nilai_1 % nilai_2;

        // faktorial
        [HttpGet("Faktorial/{nilai_1}")]
        public int Faktorial(int nilai_1)
        {
            if (nilai_1 == 1)
                return 1;
            return nilai_1 * Faktorial(nilai_1 - 1);
        }

        // Ganjil
        [HttpGet("Ganjil/{nilai_1}")]
        public bool Ganjil(int nilai_1)
        {
            bool _ganjil;
            if (nilai_1 % 2 == 1)
                _ganjil = true;
            else
                _ganjil = false;

            return _ganjil;
        }

        // Genap
        [HttpGet("Genap/{nilai_1}")]
        public bool Genap(int nilai_1)
        {
            bool _genap;
            if (nilai_1 % 2 == 0)
                _genap = true;
            else
                _genap = false;

            return _genap;
        }
    }
}

