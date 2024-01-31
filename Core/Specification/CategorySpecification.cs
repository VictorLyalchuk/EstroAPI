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
    public static class CategorySpecification
    {
        public class GetAllAsync : Specification<Category>
        {
            public GetAllAsync()
            {
                Query
                    .Include(c => c.SubCategory)
                    .ThenInclude(c => c.MainCategory);
                    //.OrderBy(c => c.Name)
                    //.Include(c => c.Products);
            }
        }
        public class GetAllAsyncByID : Specification<Category>
        {
            public GetAllAsyncByID()
            {
                Query
                    .Include(c => c.Products)
                    //.ThenInclude(c => c.Images)
                    .OrderBy(c => c.Id);
            }
        }
        public class ByID : Specification<Category>
        {
            public ByID(int ID)
            {
                Query
                    .Include(c => c.Products)
                    //.ThenInclude(c => c.Images)
                    .Where(c => c.Id == ID);
            }
        }
        public class GetBySubNameAsync : Specification<Category>
        {
            public GetBySubNameAsync(string subName)
            {
                Query
                    //.ThenInclude(c => c.Images)
                    .Where(c => c.SubCategory.URLName == subName);
            }
        }

    }
}
