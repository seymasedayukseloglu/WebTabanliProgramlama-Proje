using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Florals.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

public class AdminController : Controller
{
    private readonly myAppContext _context;

    public AdminController(myAppContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AdminManager()
    {
        ViewBag.Message = "Welcome to the Admin Panel!";
        return View();
    }


    [HttpGet("admin/productmanagement")]
    public IActionResult ProductManagement()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    [HttpPost("admin/productmanagement")]
    public async Task<IActionResult> ProductManagement(Product product, string action, int id, IFormFile ProductImage)
    {
        if (action == "Add" && ModelState.IsValid)
        {

            if (ProductImage != null && ProductImage.Length > 0)
            {

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(ProductImage.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/product", fileName);


                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                var fileExtension = Path.GetExtension(ProductImage.FileName).ToLower();

                if (!allowedExtensions.Contains(fileExtension))
                {
                    ModelState.AddModelError("ProductImage", "Geçersiz dosya tipi. Lütfen bir resim dosyası yükleyin.");
                    return View();
                }

                if (ProductImage.Length > 5 * 1024 * 1024)
                {
                    ModelState.AddModelError("ProductImage", "Dosya boyutu 5 MB'ı geçemez.");
                    return View();
                }

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await ProductImage.CopyToAsync(stream);
                }

                product.ImagePath = "/images/product/" + fileName;
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Ürün başarıyla eklendi!";
        }
        else if (action == "Delete")
        {
            var productToDelete = _context.Products.Find(id);
            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Ürün başarıyla silindi!";
            }
            else
            {
                TempData["ErrorMessage"] = "Ürün bulunamadı!";
            }
        }

        return RedirectToAction("ProductManagement");
    }

    [HttpGet("admin/userslist")]
    public IActionResult UsersList()
    {
        var users = _context.Users.ToList();
        return View(users);
    }
}
