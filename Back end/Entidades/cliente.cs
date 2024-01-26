using System.ComponentModel.DataAnnotations;

namespace Back_end.Entidades
{
    public class cliente
    {
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public String rut {  get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public String apellido {  get; set; }
        public int fono {  get; set; }
        [Required(ErrorMessage = "Debe indicar un {0}")]
        public String correo { get; set; }
        [Required(ErrorMessage = "Debe indicar el nivel de {0}")]
        public int privilegios { get; set; }
        [Required(ErrorMessage = "Debe indicar una contraseña")]
        public String password { get; set; }

    }
}
