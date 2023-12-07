
using Booksweb.Data;
using Booksweb.Models;
using Microsoft.AspNetCore.Mvc;


namespace Booksweb.Controllers;

public class CategoryController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    //http://localhost:5259/category/index
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db=db;
    }
    public IActionResult Index()
    {
        List<Category> obj =_db.Categories.ToList();
        return View(obj);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Category obj)
    {
        if(obj.Name==obj.DisplayOrder.ToString())
        {
            ModelState.AddModelError("name","cant be same");
        }
        if(ModelState.IsValid)
        {
        _db.Categories.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
        return View();
        
    }
    public IActionResult Edit(int? id)
    {
        if(id==null || id==0)
        {
            return NotFound();
        }
        Category? fromDb=_db.Categories.Find(id);
        if(fromDb==null)
        {
            return NotFound();
        }
        return View(fromDb);
    }
    [HttpPost]
    public IActionResult Edit(Category obj)
    {
        if(obj.Name==obj.DisplayOrder.ToString())
        {
            ModelState.AddModelError("name","cant be same");
        }
        if(ModelState.IsValid)
        {
        _db.Categories.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
        return View();
        
    }
}