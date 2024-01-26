using System.ComponentModel.DataAnnotations;

namespace Back_end.Entidades
{
    public class producto
    {
        [Required(ErrorMessage ="Debe indicar un {0}")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public String descripcion { get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public int precio { get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public int descuento { get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public int peso { get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public String tipoPeso { get; set; }
        [Required(ErrorMessage = "Debe indicar una {0}")]
        public int categoria { get; set; }

        public producto(string nombre, int iD, string descripcion, int precio, int descuento, int peso, string tipoPeso, int categoria)
        {
            this.nombre = nombre;
            ID = iD;
            this.descripcion = descripcion;
            this.precio = precio;
            this.descuento = descuento;
            this.peso = peso;
            this.tipoPeso = tipoPeso;
            this.categoria = categoria;
        }
    }
}
