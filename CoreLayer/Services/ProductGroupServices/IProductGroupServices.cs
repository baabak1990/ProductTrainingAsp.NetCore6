using CoreLayer.ViewModels.ProductGroupVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Services.ProductGroupServices
{
    public interface IProductGroupServices
    {
        Task<List<IIndexProductGroupVm>> GetAllGroupsAsync();
    }
}
