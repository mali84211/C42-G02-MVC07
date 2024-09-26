using Microsoft.AspNetCore.Mvc;

namespace C42_G02_MVC07.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int? id, Department model)
        {
            try
            {
                if (id != model.id) return BadRequest();
                if (ModelState.IsValid)
                {
                    var Count_departmentRepository.Update(model);
                    if (Count > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                }
            }
            catch (Exception Ex)
            {
                ModelState.AddModelError(string.Empty, Ex.Message);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete([FromRoute] int? id)
        {

            if (id is null) return BadRequest();
            var department = _departmentRepository.Get(id.Value);
            if (department != null) return NotFound();
            return View(department);
        }
    }
}

