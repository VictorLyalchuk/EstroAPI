using Core.DTOs.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IStorageService
    {
        Task AddQuantityStorageAsync(StorageDTO [] storagesDTO);
        Task CreateStorageForProduct(StorageDTO storageDTO);
        Task<List<StorageDTO>> GetStorageByProductIdAsync(int productId);
    }
}
