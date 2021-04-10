using System.ComponentModel.DataAnnotations;

namespace DVP.Models
{
    public class Usuario{
        public Usuario()
        {
        }
        public Usuario(string nombre, string correo)
        {
            Nombre = nombre;
            Email = correo;
        }
        [Key]
        public int Id { set; get; }
        [Required]
        [MaxLength(50)]
        public string Nombre { set; get; }
        [Required]
        [MaxLength(50)]
        public string Email { set; get; }
    }
}
