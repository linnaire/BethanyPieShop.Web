using System.Collections.Generic;

namespace BethanyPieShop.Web
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
