using CoreLayer.ViewModels.ProductGroupVM;
using CoreLayer.ViewModels.ProductGroupVM.Mapper;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Services.ProductGroupServices
{
    public class ProductGroupServices : IProductGroupServices
    {
        #region constructor
        private readonly ProductTariningContext _context;
        public ProductGroupServices(ProductTariningContext context)
        {
            _context= context;
        }
        #endregion
        public async Task<List<IIndexProductGroupVm>> GetAllGroupsAsync()
        {
            return await _context.productGroups.IndexProductGroup().ToListAsync();
        }
    }
}
