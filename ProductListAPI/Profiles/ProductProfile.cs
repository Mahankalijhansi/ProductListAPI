using AutoMapper;
using ProductList.Models.Models.Domain;
using ProductList.Models.Models.Dto;

namespace ProductListAPI.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto,Product>();
        }
    }
}
