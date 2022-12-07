using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginDependencies
{
    public class IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
    }
}
