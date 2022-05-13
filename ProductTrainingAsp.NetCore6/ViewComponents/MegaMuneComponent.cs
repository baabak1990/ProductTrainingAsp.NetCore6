using CoreLayer.Services.ProductGroupServices;
using Microsoft.AspNetCore.Mvc;

namespace ProductTrainingAsp.NetCore6.ViewComponents
{
    public class MegaMuneComponent:ViewComponent
    {
        #region Model Injection
        private readonly IProductGroupServices _service;
        public MegaMuneComponent(IProductGroupServices service)
        {
            _service = service;
        }

        #endregion
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("~/Views/Shared/Components/MegaMuneComponent/MegaMenu.cshtml", await _service.GetAllGroupsAsync()));
        }
    }
}
