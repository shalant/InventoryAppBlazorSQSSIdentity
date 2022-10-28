using IMS.CoreBusiness;
using IMS.UseCases.PluginDependencies;

namespace IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        public Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}