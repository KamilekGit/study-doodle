using Clock.Data.Models;

namespace Clock.Data.interfaces
{
    public interface IAllCars
    {
      IEnumerable<Car>Cars { get;  }
        IEnumerable<Car> GetFavCars {  get; set; }
        Car getobjectCar(int carId);
    }
}
