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
    public class SubCategorySpecification
    {
        public class All : Specification<SubCategory>
        {
            public All()
            {
                Query
                    .Include(c => c.MainCategory)
                    .Include(c => c.Categories);
            }
        }
    }
}
