using CropWIKImvc.Models;
using CropWIKImvc.Models.ModelServices;
using Microsoft.AspNetCore.Mvc;

namespace CropWIKImvc.Controllers.Crop
{
    public class CropController : Controller
    {
        private readonly CropServices _cropService;

        public CropController(CropServices cropService)
        {
            _cropService = cropService;
        }

        // GET: CropController
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("test ");
            // Retrieve all crops using CropService
            List<Models.Crop> crops = _cropService.GetAllCrops();

            // Pass the list of crops to the view
            return View("Views/Home/Index.cshtml", crops);
        }

        // GET: CropController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CropController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CropController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CropController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CropController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CropController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CropController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
