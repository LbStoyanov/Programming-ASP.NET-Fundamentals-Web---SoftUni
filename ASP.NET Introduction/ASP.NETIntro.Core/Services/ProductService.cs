using ASP.NETIntro.Core.Contracts;
using ASP.NETIntro.Core.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ASP.NETIntro.Core.Services
{
    /// <summary>
    /// Manipulates product data
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IConfiguration config;

        /// <summary>
        /// IoC
        /// </summary>
        /// <param name="config">Application configuratuin</param>
        public ProductService(IConfiguration config)
        {
            this.config = config;
        }
        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>List of products</returns>
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            //string dataPath = config.GetValue();
            //throw new NotImplementedException();

            string dataPath = config.GetSection("DataFiles:Products").Value;

            string data = await File.ReadAllTextAsync("dataPath");

            return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(data);
        }
    }
}
