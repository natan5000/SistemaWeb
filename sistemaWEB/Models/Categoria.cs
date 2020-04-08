using System;
using System.Collections.Generic;

namespace sistemaWEB.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Productos>();
        }

        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
