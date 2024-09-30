using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Image.Models;

public class ImageController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();

    // GET: Image/Upload
    public ActionResult Upload()
    {
        return View();
    }

    // POST: Image/Upload
    [HttpPost]
    public ActionResult Upload(HttpPostedFileBase file)
    {
        if (file != null && file.ContentLength > 0)
        {
            var image = new Table
            {
                ImagePath = Path.GetFileName(file.FileName),
                Data = new byte[file.ContentLength]
            };
            file.InputStream.Read(image.Data, 0, file.ContentLength);
            db.Images.Add(image);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    // GET: Image/Index
    public ActionResult Index()
    {
        var images = db.Images.ToList();
        return View(images);
    }

    // GET: Image/View/5
    public ActionResult View(int id)
    {
        var image = db.Images.Find(id);
        return File(image.Data, "image/jpeg"); // Adjust the MIME type as needed
    }
}
