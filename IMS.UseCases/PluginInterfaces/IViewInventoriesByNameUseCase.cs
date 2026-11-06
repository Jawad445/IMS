using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsnc(string name = "");
    }
}