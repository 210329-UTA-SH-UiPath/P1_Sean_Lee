using mStore = PizzaBox.Domain.Models.Store;
using eStore = PizzaBox.Storing.Entities.Store;


namespace PizzaBox.Storing.Mappers
{
  public class StoreMapper : IMapper<mStore, eStore>
  {
    public mStore Map(eStore store)
    {
      return new mStore
      {
        Id = store.Id,
        Name = store.Name,
      };
    }
    public eStore Map(mStore store)
    {
      return new eStore
      {
        Id = store.Id,
        Name = store.Name,
      };
    }
  }
}