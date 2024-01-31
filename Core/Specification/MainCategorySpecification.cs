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
    public class MainCategorySpecification
    {
        public class All : Specification<MainCategory>
        {
            public All()
            {
                Query
                    .Include(c => c.SubCategories)
                    .ThenInclude(c => c.Categories);
            }
        }
    }
}
