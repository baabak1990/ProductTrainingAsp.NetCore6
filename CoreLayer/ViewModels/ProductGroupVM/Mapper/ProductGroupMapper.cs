using DomainLayer.Entities.ProductGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.ViewModels.ProductGroupVM.Mapper
{
    public static class ProductGroupMapper
    {
        public static IIndexProductGroupVm IndexProductGroup(this ProductGroup productGroup)
        {
            return new IIndexProductGroupVm
            {
                PartentId = productGroup.PartentId,
                Title = productGroup.Title,
                Id=productGroup.Id,
            };
        }
        public static IQueryable<IIndexProductGroupVm> IndexProductGroup(this IQueryable<ProductGroup> productGroups)
        {
            return productGroups.Select(p => p.IndexProductGroup());
        }

        public static IEnumerable<IIndexProductGroupVm> IndexProductGroup(this IEnumerable<ProductGroup> productGroups)
        {
            return productGroups.Select(p => p.IndexProductGroup());
        }
    }
}
