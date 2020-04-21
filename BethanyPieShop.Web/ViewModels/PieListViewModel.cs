using System.Collections.Generic;

namespace BethanyPieShop.Web
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }

        public string CurrentCategory { get; set; }
    }
}
