﻿using System.Collections.Generic;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Controllers.Models
{
    public class ProductsResponse
    {
        public List<ProductResponse> Products { get; set; }
    }
}