using Clock.Data.interfaces;
using Clock.Data.Models;

namespace Clock.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "ElectroCar", Desc = "Современный вид транспорта" },
                    new Category { CategoryName = "Classic  Car", Desc = "Машины с ДВС" },
                };
            }
        }
    }
}
