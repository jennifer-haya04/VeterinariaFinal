//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeterinariaFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public int idProducto { get; set; }
        public string nombreProd { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> idCategoria { get; set; }
        public string img { get; set; }
    
        public virtual categoria categoria { get; set; }
    }
}
