using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugin.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;
        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory { Id = 1, Name = "Bike Seat", Quantity = 10, Price = 10 },
                new Inventory { Id = 2, Name = "Bike Body", Quantity = 10, Price = 15 },
                new Inventory { Id = 3, Name = "Bike Wheels", Quantity = 20, Price =  8 },
                new Inventory { Id = 4, Name = "Bike Padels", Quantity = 20, Price =  3 }
            };
        }


        public async Task<IEnumerable<Inventory>> GetByNameAsync(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.Name.Contains(Name, StringComparison.OrdinalIgnoreCase));

            throw new NotImplementedException();
        }
    }
}
