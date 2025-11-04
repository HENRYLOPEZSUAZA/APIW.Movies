using APIW.Movies.DAL.Models;

namespace APIW.Movies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync();// me retorna una lista de categorias
        Task<Category> GetCategoryAsync(int id);// me retorna una categoria por su id
        Task<bool> CategoryExistsByIdAsync(int id);// me retorna true o false si existe una categoria por su id
        Task<bool> CategoryExistsByNameAsync(string name);// me retorna true o false si existe una categoria por su nombre
        Task<bool> CreateCategoryAsync(Category category);// me crea una categoria
        Task<bool> UpdateCategoryAsync(Category category);// me actualiza una categoria
        Task<bool> DeleteCategoryAsync(int id);// me elimina una categoria

    }
}
