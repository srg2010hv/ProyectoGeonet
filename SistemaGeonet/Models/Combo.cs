using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGeonet.Models
{
    public class Combo
    {
        [Key]
        public int idCombo { get; set; }

        public string descripcion { get; set; }

        public decimal precio_regular { get; set; }

        public decimal precio_descuento { get; set; }

        public string estado { get; set; }

        public string imagen_combo { get; set; }

        public ICollection<EquipoxCombo> equipoxCombos { get; set; }
    }
}
