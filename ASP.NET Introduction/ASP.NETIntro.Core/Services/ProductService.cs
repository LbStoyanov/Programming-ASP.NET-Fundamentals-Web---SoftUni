using ASP.NETIntro.Core.Contracts;
using ASP.NETIntro.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NETIntro.Core.Services
{
    /// <summary>
    /// Manipulates product data
    /// </summary>
    public class ProductService : IProductService
    {
        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>List of products</returns>
        public Task<IEnumerable<ProductDto>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
