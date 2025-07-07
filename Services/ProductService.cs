using GvnAtlas.ElasticSearchAPI.Dtos;
using GvnAtlas.ElasticSearchAPI.Repositories;

namespace GvnAtlas.ElasticSearchAPI.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task SaveAsync(ProductCreateDto request)
        {

            if (request is null)
            {
                throw new ArgumentNullException(nameof(request), "Request cannot be null");
            }
            var product = request.CreateProduct();
            var savedProduct = await _productRepository.SaveAsync(product);
            

        }
    }
}
