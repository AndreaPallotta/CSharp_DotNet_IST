using Microsoft.AspNetCore.Mvc;
using RITFacultyV1.Services;
using RITFacultyV1.ViewModels;
using System.Threading.Tasks;

namespace RITFacultyV1.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var getabout = new GetAbout();
            var About = await getabout.GetAllAbout();
            var HomeViewModel = new HomeViewModel()
            {
                about = About,
                Title = "About IST"
            };
            return View(HomeViewModel);
        }

        public async Task<IActionResult> Degrees()
        {
            var getAllUndergrad = new GetUndergrad();
            var under = await getAllUndergrad.GetDegrees();
            var getGraduate = new GetGrad();
            var grad = await getGraduate.GetGradDegrees();
            var DegreesViewModel = new DegreesViewModel()
            {
                undergrad = under,
                graduate = grad,
                Title = "Undergraduate Programs"
            };
            return View(DegreesViewModel);
        }

        public async Task<IActionResult> People()
        {
            var getallFaculty = new GetFaculty();
            var allFaculty = await getallFaculty.GetAllFaculty();
            var PeopleViewModel = new PeopleViewModel()
            {
                Faculty = allFaculty,
                Title = "This is your Faculty"
            };
            return View(PeopleViewModel);
        }

        public async Task<IActionResult> Minors()
        {
            var getMinors = new GetMinors();
            var Minors = await getMinors.GetMinorsDegree();
            var MinorsViewModel = new MinorsViewModel()
            {
                minors = Minors,
                Title = "Minors"
            };
            return View(MinorsViewModel);
        }

        public async Task<IActionResult> Tables()
        {
            var getCoop = new GetTables();
            var coop = await getCoop.GetCoop();
            var emp = await getCoop.GetEmployer();
            var TablesViewModel = new TablesViewModel()
            {
                coopTable = coop,
                empTable = emp,
                Title = "Co-op Table Title"
            };
            return View(TablesViewModel);
        }
    }
}
