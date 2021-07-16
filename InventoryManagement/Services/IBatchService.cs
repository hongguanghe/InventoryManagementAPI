using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.Services.DTOs;

namespace InventoryManagement.Services
{
    public interface IBatchService
    {
        Task<IEnumerable<BatchDTO>> GetAllAssociatedBatches(int productId);
        Task<BatchDTO> GetBatchById(int id);
        Task<bool> BatchExistsById(int id);
        Task DeleteBatchById(int id);
        Task DeleteBatch(BatchDTO batch);
        Task DeleteAllAssociatedBatches(IEnumerable<BatchDTO> allBatches);
        Task CreateBatch(BatchDTO batch);
        Task UpdateBatch(BatchDTO batch);
    }
}