using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infoline.DL.mpm.Data.Entities
{
    public class mpm
    {
        [Key]
        public int Id { get; set; }
        public string Ogrenci { get; set; }
        public string Sinav { get; set; }
        public int Type { get; set; }
        public string Soru { get; set; }
        public bool Cevap { get; set; }
        public int Puan { get; set; }
    }
}
