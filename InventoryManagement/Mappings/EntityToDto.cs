using AutoMapper;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Mappings
{
    public class EntityToDto : Profile
    {
        public EntityToDto()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Batch, BatchDTO>().ReverseMap();
        }
    }

    // public class ProductToDto : Profile
    // {
    //     public ProductToDto()
    //     {
    //         CreateMap<Product, ProductDTO>();
    //         CreateMap<Batch, BatchDTO>();
    //     }
    // }
    //
    // public class BatchToDto : Profile
    // {
    //     public BatchToDto()
    //     {
    //         CreateMap<Batch, BatchDTO>();
    //         CreateMap<Product, ProductDTO>();
    //     }
    // }
    
}