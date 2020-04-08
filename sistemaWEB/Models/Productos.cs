using System;
using System.Collections.Generic;

namespace sistemaWEB.Models
{
    public partial class Productos
    {
        public int ProductosId { get; set; }
        public int CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
