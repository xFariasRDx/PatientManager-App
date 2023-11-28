﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientApp.Core.Domain.Entities
{
    public class Medicos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string? Img_Medico { get; set;}

        //Navigation Property
        public ICollection<Citas> citas { get; set; }
    }
}
