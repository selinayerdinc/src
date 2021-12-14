using API.Core.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);             //async olması için bunu ekliyoruz.
        
        /// <summary>
        /// All Product List
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<Product>> GetProductAsync();                                   // Değişiklik yapamayacağımız çoklu kayıtları tutan bir liste
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandAsync();

    }
}
// belli başlı classlara bağlı olmamak için interface kullanıyoruz.Kavramları soyutlaştırıyoruz.
//Dependency injection ı repository kullanarak yapıyoruz.