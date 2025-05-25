using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendataan_Santri.models
{
    public class Santri
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string Sekolah { get; set; }
        public string NamaAyah { get; set; }
        public string NamaIbu { get; set; }
        public string Alamat { get; set; }
    }
}
