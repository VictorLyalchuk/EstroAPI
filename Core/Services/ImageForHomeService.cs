using AutoMapper;
using Core.DTOs.Site;
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
    public class ImageForHomeService : IImageForHomeService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<ImageForHome> _imageForHomeRepository;
        public ImageForHomeService(IMapper mapper, IRepository<ImageForHome> imageForHomeRepository)
        {
            _imageForHomeRepository = imageForHomeRepository;
            _mapper = mapper;
        }
        public async Task<List<ImageForHome>>? GetAllImageAsync()
        {
            var images = await _imageForHomeRepository.GetAsync();
            return _mapper.Map<List<ImageForHome>>(images);
        }
    }
}
