﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InventoryManagement.Data;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class BatchService : IBatchService
    {
        private readonly ApplicationDBContext _db;
        private readonly IMapper _mapper;
        
        public BatchService(ApplicationDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BatchDTO>> GetAllAssociatedBatches(int productId)
        {
            var result = await _db.Batches.Where(p => p.ProductId == productId).ToListAsync();
            return Converter.BatchesToDto(result);
        }

        public async Task<BatchDTO> GetBatchById(int id)
        {
            return _mapper.Map<BatchDTO>(await _db.Batches.FindAsync(id));
            // return Converter.BatchToDto(await _db.Batches.FindAsync(id));
        }

        public async Task<bool> BatchExistsById(int id)
        {
            return await _db.Batches.Where(p => p.BatchId == id).AnyAsync();
        }

        public async Task DeleteBatchById(int id)
        {
            var batch = await _db.Batches.FindAsync(id);
            _db.Batches.Remove(batch);        
        }

        public async Task DeleteBatch(BatchDTO batch)
        {
            _db.Batches.Remove(Converter.BatchDtoToDb(batch));
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAllAssociatedBatches(IEnumerable<BatchDTO> allBatches)
        {
            foreach (var batch in allBatches)
            {
                await DeleteBatch(batch);
            }
        }

        public async Task CreateBatch(BatchDTO batch)
        {
            await _db.Batches.AddAsync(Converter.BatchDtoToDb(batch));
            await _db.SaveChangesAsync();
        }

        public async Task UpdateBatch(BatchDTO batch)
        {
            _db.Batches.Update(Converter.BatchDtoToDb(batch));
            await _db.SaveChangesAsync();
        }
        
    }
}