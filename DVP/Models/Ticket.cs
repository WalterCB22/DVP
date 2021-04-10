using System;
using System.ComponentModel.DataAnnotations;


namespace DVP.Models
{
    public class Ticket
    {
        public Ticket()
        {
            FechaDeCreacion = DateTime.Now;
            FechaDeActualizacion = DateTime.Now;
        }
        public Ticket(int usuario, bool estado, string desc = null )
        {
            UsuarioId = usuario;
            Estado = estado;
            Descripcion = desc;
            FechaDeCreacion = DateTime.Now;
            FechaDeActualizacion = DateTime.Now;
        }

        [Key]
        public int Id { set; get; }
        [Required]
        public DateTime FechaDeCreacion { set; get; }
        [Required]
        public DateTime FechaDeActualizacion { set; get; }
        [Required]
        public bool Estado { set; get; }
        public Usuario Usuario { set; get; }
        [Required]
        public int UsuarioId { set; get; }
        public string Descripcion { set; get; }
        
    }
}
