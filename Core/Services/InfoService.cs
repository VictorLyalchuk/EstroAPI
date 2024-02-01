using AutoMapper;
using Core.DTOs.Site;
using Core.Entities.Information;
using Core.Entities.Site;
using Core.Interfaces;
using Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class InfoService : IInfoService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Info> _infoRepository;
        public InfoService(IMapper mapper, IRepository<Info> infoRepository)
        {
            _mapper = mapper;
            _infoRepository = infoRepository;
        }
        public async Task<List<Info>>? GetInfoAsync(string subName)
        {
            var infos = await _infoRepository.GetListBySpec(new InfoSpecification.GetAll(subName));
            return _mapper.Map<List<Info>>(infos);
        }
    }
}
