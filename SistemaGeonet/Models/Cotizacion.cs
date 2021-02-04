﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGeonet.Models
{
    public class Cotizacion
    {
        [Key]
        public int idCotizacion { get; set; }

        public int idSolicitudCotizacion { get; set; }

        public DateTime fecha_emision { get; set; }

        public DateTime fecha_validez { get; set; }

 
        public decimal precio_subtotal { get; set; }

        public decimal igv { get; set; }

        public decimal precio_total { get; set; }

        

    }
}
