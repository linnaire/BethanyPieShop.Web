using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Web
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this._pieRepository = pieRepository;
            this._categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PieListViewModel vm = new PieListViewModel();

            vm.Pies = _pieRepository.GetAll();

            return View(vm);
        }
    }
}