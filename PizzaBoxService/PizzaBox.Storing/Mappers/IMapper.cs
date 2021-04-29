namespace PizzaBox.Storing.Mappers
{
  public interface IMapper<T, V>
  {
    T Map(V v);
    V Map(T t);
  }
}