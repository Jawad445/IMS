using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories;

public class ViewInventoriesByNameUseCase: IViewInventoriesByNameUseCase
{
    private readonly IInventoryRepository _InventoryRepo;
    public ViewInventoriesByNameUseCase(IInventoryRepository repository)
    {
        _InventoryRepo = repository;
    }
    public async Task<IEnumerable<Inventory>> ExecuteAsnc(string name = "")
    {
        return await _InventoryRepo.GetByNameAsync(name);
    }
}
