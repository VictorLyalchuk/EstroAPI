using Core.Entities.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs.Filter
{
    public class OptionsDTO
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public int? Info { get; set; }
        public Info? InfoId { get; set; }
    }
}
