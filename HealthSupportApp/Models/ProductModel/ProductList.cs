using HealthSupportApp.Models.ProductModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace HealthSupportApp.Models.ProductModel
{
    public class ProductList
    {
        public List<Product> Products { get; set; }
    }
}