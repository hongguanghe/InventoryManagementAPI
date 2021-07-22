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
}