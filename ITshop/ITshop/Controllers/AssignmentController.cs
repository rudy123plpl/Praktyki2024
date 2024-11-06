using ITshop.Data;
using ITshop.Models;
using Microsoft.AspNetCore.Mvc;


namespace ITshop.Controllers
{
    public class AssignmentController : Controller
    {
        private Repository<Assignment> assignments;

        public AssignmentController(ApplicationDbContext context)
        {
            assignments = new Repository<Assignment>(context);
        }
        public async Task<IActionResult> Index()
        {
            return View(await assignments.GetAllAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await assignments.GetByIdAsync(id, new QueryOptions<Assignment>() { Includes = "DeviceAssignments.Device" }));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssignmentId, Name")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                await assignments.AddAsync(assignment);
                return RedirectToAction("Index");
            }
            return View(assignment);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await assignments.GetByIdAsync(id, new QueryOptions<Assignment> { Includes = "DeviceAssignments.Device"}));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Assignment assignment)
        {
            

            await assignments.DeleteAsync(assignment.AssignmentId);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await assignments.GetByIdAsync(id, new QueryOptions<Assignment> { Includes = "DeviceAssignments.Device" }));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                await assignments.UpdateAsync(assignment);
                return RedirectToAction("Index");
            }
            return View(assignment);
        }
    }
}
