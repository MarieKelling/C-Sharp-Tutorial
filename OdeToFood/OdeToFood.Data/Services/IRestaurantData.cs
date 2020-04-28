using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        /* Different operations we want to perform on the data source. CRUD */

        IEnumerable<Restaurant> GetAll();
    }
}
