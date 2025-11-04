using System.ComponentModel.DataAnnotations;

namespace APIW.Movies.DAL.Models.Dtos
{
    public class CategoryCreateDto
    {   [Required(ErrorMessage ="El nombre de la categoria es obligatoria.")]
        [MaxLength(100, ErrorMessage ="El nombre de la categoria no debe exceder los 100 caracteres.")]
        public string Name { get; set; }
    }
}
