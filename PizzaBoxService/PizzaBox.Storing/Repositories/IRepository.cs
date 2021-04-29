using System.Collections.Generic;

namespace PizzaBox.Storing.Repositories
{
  public interface IRepository<T>
  {
    void Add(T t);
    void Remove(int t);
    List<T> GetList();
    T GetById(int id);
    void Update(T t);
  }
}