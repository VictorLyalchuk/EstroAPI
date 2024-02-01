using Core.DTOs.Site;
using Core.Entities.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IInfoService
    {
        Task<List<Info>>? GetInfoAsync(string subName);
    }
}
