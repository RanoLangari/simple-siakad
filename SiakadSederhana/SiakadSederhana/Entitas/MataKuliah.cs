﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiakadSederhana.Entitas
{
    public class MataKuliah
    {
        public string KodeMataKuliah { get; set; } //Key
        public string NamaMataKuliah { get; set; }
        public string Deskripsi { get; set; }
        public double JumlahSks { get; set; }
        
    }
}