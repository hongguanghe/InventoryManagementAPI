using System.Collections.Generic;
using AutoMapper;
using InventoryManagement.Controllers.Models;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Mappings
{
    public class DtoToResponse : Profile
    {
        public DtoToResponse()
        {
            CreateMap<ProductDTO, ProductResponse>();
            CreateMap<BatchDTO, BatchResponse>();
        }
    }
    
    public class ProductsDtoToResponse : Profile
    {
        public ProductsDtoToResponse()
        {
            CreateMap<ProductDTO, ProductResponse>();
            CreateMap<BatchDTO, BatchResponse>();
            CreateMap<IEnumerable<ProductDTO>, ProductsResponse>();
        }
    }
    
    public class BatchesDtoToResponse : Profile
    {
        public BatchesDtoToResponse()
        {
            CreateMap<IEnumerable<BatchDTO>, BatchesResponse>();
        }
    }
}