using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGeonet.Models
{
    public class Proveedor
    {
        [Key]

        public int idProveedor { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Nombre")]
        public string nombre_empresa { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Contacto")]
        public string nombre_contacto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Tipo de documento")]
        public string tipo_documento_identidad { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Número de documento")]
        public string nro_documento_identidad { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("País")]
        public string pais { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Dirección")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Teléfono")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Email")]
        public string email { get; set; }


   

        public ICollection<OrdenCompra> ordenCompras { get; set; }
        public ICollection<EquipoxProveedor> equipoxProveedors { get; set; }
    }
}
