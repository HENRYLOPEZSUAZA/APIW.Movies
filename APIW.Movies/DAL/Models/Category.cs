using System.ComponentModel.DataAnnotations;

namespace APIW.Movies.DAL.Models
{
    public class Category : AuditBase
    {
        [Required] //este data anotation indica que el campo es obligatorio
        [Display(Name = "Nombre de la Catgegoria")] //este data anotation indica el nombre que se mostrara en las vistas]
        public string Name { get; set; }



    }
}
