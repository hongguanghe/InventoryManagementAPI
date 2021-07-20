using AutoMapper;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Mappings
{
    public class DtoToEntity : Profile
    {
        public DtoToEntity()
        {
            CreateMap<BatchDTO, Batch>();
            CreateMap<ProductDTO, Product>();
        }
    }

    // public class BatchDtOToEntity : Profile
    // {
    //     public BatchDtOToEntity()
    //     {
    //         CreateMap<BatchDTO, Batch>();
    //         CreateMap<ProductDTO, Product>();
    //     }
    // }
    //
    // public class ProductDtoToEntity : Profile
    // {
    //     public ProductDtoToEntity()
    //     {
    //         CreateMap<ProductDTO, Product>();
    //         CreateMap<BatchDTO, Batch>();
    //     }
    // }

}