using InitialSite.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InitialSite.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypeController(IProductTypeRepository productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }

        // GET: ProductType
        [HttpGet]
        public PartialViewResult GetProductLabelDropdown()
        {
            var productLabelList = _productTypeRepository.GetListOfProductLabels().ToList();

            return PartialView("~/Views/Shared/ProductTypeLabelsDropdown.cshtml", productLabelList);
        }
    }
}
