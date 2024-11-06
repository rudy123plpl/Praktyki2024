using ITshop.Data;
using ITshop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ITshop.Data;
using ITshop.Models;

namespace ITshop.Controllers
{
    public class DeviceController : Controller
    {
        private Repository<Device> devices;
        private Repository<Assignment> assignments;
        private Repository<Category> categories;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DeviceController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            devices = new Repository<Device>(context);
            assignments = new Repository<Assignment>(context);
            categories = new Repository<Category>(context);
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await devices.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(int id)
        {
            ViewBag.Assignments = await assignments.GetAllAsync();
            ViewBag.Categories = await categories.GetAllAsync();
            if (id == 0)
            {
                ViewBag.Operation = "Add";
                return View(new Device());
            }
            else
            {
                Device device = await devices.GetByIdAsync(id, new QueryOptions<Device>
                {
                    Includes = "DeviceAssignments.Assignment, Category"
                });
                ViewBag.Operation = "Edit";
                return View(device);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(Device device, int[] assignmentIds, int catId)
        {
            ViewBag.Assignments = await assignments.GetAllAsync();
            ViewBag.Categories = await categories.GetAllAsync();
            if (ModelState.IsValid)
            {

                if (device.ImageFile != null)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + device.ImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await device.ImageFile.CopyToAsync(fileStream);
                    }
                    device.ImageUrl = uniqueFileName;
                }

                if (device.DeviceId == 0)
                {

                    device.CategoryId = catId;

                    //add ingredients
                    foreach (int id in assignmentIds)
                    {
                        device.DeviceAssignments?.Add(new DeviceAssignment { AssignmentId = id, DeviceId = device.DeviceId });
                    }

                    await devices.AddAsync(device);
                    return RedirectToAction("Index", "Device");
                }
                else
                {
                    var existingDevice = await devices.GetByIdAsync(device.DeviceId, new QueryOptions<Device> { Includes = "DeviceAssignments" });

                    if (existingDevice == null)
                    {
                        ModelState.AddModelError("", "Device not found.");
                        ViewBag.Assignments = await assignments.GetAllAsync();
                        ViewBag.Categories = await categories.GetAllAsync();
                        return View(device);
                    }

                    existingDevice.Name = device.Name;
                    existingDevice.Description = device.Description;
                    existingDevice.Price = device.Price;
                    existingDevice.Stock = device.Stock;
                    existingDevice.CategoryId = catId;

                    // Update product ingredients
                    existingDevice.DeviceAssignments?.Clear();
                    foreach (int id in assignmentIds)
                    {
                        existingDevice.DeviceAssignments?.Add(new DeviceAssignment { AssignmentId = id, DeviceId = device.DeviceId });
                    }

                    try
                    {
                        await devices.UpdateAsync(existingDevice);
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", $"Error: {ex.GetBaseException().Message}");
                        ViewBag.Assignments = await assignments.GetAllAsync();
                        ViewBag.Categories = await categories.GetAllAsync();
                        return View(device);
                    }
                }
            }
            return RedirectToAction("Index", "Device");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await devices.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Device not found.");
                return RedirectToAction("Index");
            }
        }
    }
}