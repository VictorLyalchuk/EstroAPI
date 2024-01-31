using Ardalis.Specification;
using Core.Entities.Site;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification
{
    public class StorageSpecification
    {
        public class GetStorageByProductId : Specification<Storage>
        {
            public GetStorageByProductId(int id)
            {
                Query
                    .Where(p => p.ProductId == id);
            }
        }
    }
}
