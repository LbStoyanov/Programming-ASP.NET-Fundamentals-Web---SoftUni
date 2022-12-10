using ASP.NETIntro.Core.Models;

namespace ASP.NETIntro.Core.Contracts
{
    /// <summary>
    /// Manipulates product data
    /// </summary>
    /// 

    //We need interface only if later we will test it, otherwise we can use only the respective class!!!
    public interface IProductService
    {
        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>List of products</returns>
        Task<IEnumerable<ProductDto>> GetAll();

        /// <summary>
        /// Add new product
        /// </summary>
        /// <param name="productDto">Product model</param>
        /// <returns></returns>
        Task Add(ProductDto productDto);

        Task Delete(Guid id);
    }
}
