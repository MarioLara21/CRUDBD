using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaDeConcepto.Models.ViewModels
{
    public class Usuario
    {
        public int Id(get; set;);
        public string Nombre(get; set;);
        
        public string Clave(get; set;);
    }

    public class ClaseArticulo
    {
        public int Id(get; set;)
        
        public int IdClaseArticulo(get; set;)
        public string nombre(get; set;)
        
        public double precio(get; set;)
    }
    public class Articulo
    {
        public int Id(get; set;)
        public string nombre(get; set;)
    }

}