﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGeonet.Models
{
    public class EquipoxProveedor
    {
        [Key]
        public int idEquipoxProveedor { get; set; }

        [DisplayName("Equipo")]
        public int idEquipo { get; set; }


        public int idProveedor { get; set; }

        [DisplayName("Precio ($)")]
        public decimal   precio { get; set; }

        [DisplayName("Unidad de medida ")]

        public string unidad_medida { get; set; }

        [DisplayName("Factor de conversión (unidades)")]
        public decimal factor_conversion { get; set; }

        [DisplayName("Código de proveedor")]
        public string codigo_proveedor { get; set; }

        public Equipo equipo { get; set; }

        public Proveedor proveedor { get; set; }

        public ICollection<EquipoxOC> equiposxoc { get; set; }

    }
}

