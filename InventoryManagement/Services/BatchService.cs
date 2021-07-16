using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Data;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class BatchService : IBatchService
    {
        private readonly ApplicationDBContext _db;
        
        public BatchService(ApplicationDBContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<BatchDTO>> GetAllAssociatedBatches(int productId)
        {
            var result = await _db.Batches.Where(p => p.ProductId == productId).ToListAsync();
            return Converter.BatchesToDto(result);
        }

        public Task<BatchDTO> GetBatchById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> BatchExistsById(int id)
        {
            return await _db.Batches.Where(p => p.BatchId == id).AnyAsync();
        }

        public Task DeleteBatchById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteBatch(BatchDTO batch)
        {
            _db.Batches.Remove(Converter.BatchDtoToDb(batch));
            await _db.SaveChangesAsync();
        }

        public Task DeleteAllAssociatedBatches(IEnumerable<BatchDTO> allBatches)
        {
            throw new System.NotImplementedException();
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