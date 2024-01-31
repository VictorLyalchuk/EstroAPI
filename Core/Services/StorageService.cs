using AutoMapper;
using Core.DTOs.Site;
using Core.Entities.Site;
using Core.Interfaces;
using Core.Mapper;
using Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class StorageService : IStorageService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Storage> _storageRepository;
        public StorageService(IMapper mapper, IRepository<Storage> storageRepository)
        {
            _mapper = mapper;
            _storageRepository = storageRepository;
        }
        public async Task AddQuantityStorageAsync(StorageDTO [] storagesDTO)
        {
            var storages = _mapper.Map<Storage[]>(storagesDTO);
            foreach (var storage in storages)
            {
                if(storage.ProductQuantity > 0)
                {
                    var existingStorage = await _storageRepository.GetByIDAsync(storage.Id);
                    if (existingStorage != null)
                    {
                        existingStorage.ProductQuantity += storage.ProductQuantity; 
                        existingStorage.inStock = true;

                        await _storageRepository.UpdateAsync(existingStorage);
                        await _storageRepository.SaveAsync();
                    }
                }
            }
        }
        public async Task CreateStorageForProduct(StorageDTO storageDTO)
        {
            var storage = _mapper.Map<Storage>(storageDTO);
            await _storageRepository.InsertAsync(storage);
            await _storageRepository.SaveAsync();
        }
        public async Task<List<StorageDTO>> GetStorageByProductIdAsync(int productId)
        {
            var storages = await _storageRepository.GetListBySpec(new StorageSpecification.GetStorageByProductId(productId));
            return _mapper.Map<List<StorageDTO>>(storages);
        }

    }
}
