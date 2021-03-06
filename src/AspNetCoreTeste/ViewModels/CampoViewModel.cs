﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTeste.ViewModels
{
    public class CampoViewModel
    {
        public CampoViewModel()
        {
            Dia = DateTime.Now;
            PossuiCampo = false;
        }
        public DateTime Dia { get; set; }
        public string DiaSemana { get; set; }
        public string Dirigente { get; set; }
        public string Local { get; set; }
        public bool PossuiCampo { get; set; }
        public string Horario { get; set; }
    }
}
