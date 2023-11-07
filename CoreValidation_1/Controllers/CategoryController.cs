using CoreValidation_1.Models.Categories.PageVMs.Creation;
using CoreValidation_1.Models.Categories.PageVMs.ListOperation;
using CoreValidation_1.Models.Categories.RequestModels;
using CoreValidation_1.Models.Categories.ResponseModels;
using CoreValidation_1.Models.ContextClasses;
using CoreValidation_1.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreValidation_1.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;
        public CategoryController(MyContext db)
        {
            _db = db;
        }
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel category)
        {
            if (ModelState.IsValid) //Model durumu Validation'dan gecmişse
            {

                Category c = new()
                {
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };

                _db.Categories.Add(c);
                _db.SaveChanges();
                return RedirectToAction("GetCategories");
            }
            CategoryCreationPureVM crpVM = new()
            {
                Category = category
            };
            return View(crpVM); //Eger Validation'da takılmıssak dikkat ederseniz tekrar aynı View'i döndürüyoruz...DÖndürürken de View'a model yolluyoruz(Validatin'da takıldıgımız modeli yolluyoruz ki kullanıcı hatalarını gözlemleyebilsin)

          
        }


        public IActionResult GetCategories()
        {
            List<CategoryResponseModel> categories = _db.Categories.Select(x => new CategoryResponseModel
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();

            ListCategoryResponsePageVM cpvm = new()
            {
                Categories = categories
            };
            return View(cpvm);
        }

    }
}
