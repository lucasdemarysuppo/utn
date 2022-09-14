using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm
{
    internal class Articulo
    {
            //        Código de artículo.
            //        Nombre.
            //        Descripción.
            //Marca(seleccionable de una lista desplegable).
            //Categoría(seleccionable de una lista desplegable.
            //Imagen.
            //Precio.

        public Articulo() { }

        public int CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }

        
    }
}
