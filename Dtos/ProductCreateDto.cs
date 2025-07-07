using GvnAtlas.ElasticSearchAPI.Models;

namespace GvnAtlas.ElasticSearchAPI.Dtos
{
    public record ProductCreateDto(string Name, decimal Price, int Quantity, ProductFeatureDto Feature)
    {
        public Product CreateProduct()
        {
            return new Product
            {
                Name = Name,
                Price = Price,
                Quantity = Quantity,
                ProductFeature = new()
                {
                    Width = Feature.Width,
                    Height = Feature.Height,
                    Color = Feature.Color
                }
            };
        }
    }
}
