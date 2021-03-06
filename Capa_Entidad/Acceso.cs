//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Entidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Acceso
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Passworld { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Passworld")]
        public string ConfirPassworld { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<int> EmpleadoID { get; set; }

        public string Mensaje { get; set; }
    }
}
