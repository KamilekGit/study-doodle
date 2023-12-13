
using Clock.Data.Models;

namespace Clock.Data.interfaces
    
{
    public interface ICarsCategory
    {
        IEnumerable<Category>AllCategories { get; }
    }
}
