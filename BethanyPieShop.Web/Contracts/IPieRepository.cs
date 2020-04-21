using System.Collections.Generic;

namespace BethanyPieShop.Web
{
    public interface IPieRepository : IBaseRepository<Pie> 
    {
        IEnumerable<Pie> GetPiesOfTheWeek();
    }
}
