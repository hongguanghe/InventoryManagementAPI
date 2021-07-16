using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.Data;
using InventoryManagement.Data.Entities;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Services
{
    public class BatchService : IBatchService
    {
        private readonly ApplicationDBContext _db;
        
        public BatchService(ApplicationDBContext db)
        {
            _db = db;
        }

        public Task<IEnumerable<BatchDTO>> GetAllAssociatedBatches(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<BatchDTO> GetBatchById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> BatchExistsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBatchById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBatch(BatchDTO batch)
        {
            throw new System.NotImplementedException();
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

        public Task UpdateBatch(BatchDTO batch)
        {
            throw new System.NotImplementedException();
        }
        
    }
}