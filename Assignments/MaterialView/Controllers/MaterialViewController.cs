using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMSApi.Model;

namespace MaterialView.Controllers
{
    public class MaterialViewController : Controller
    {
        // GET: MaterialViewController
        public ActionResult Index()
        {
            IEnumerable<Material> material = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5186/api/Material");
                //HTTP GET
                var responseTask = client.GetAsync("Material");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList<Material>>();
                    readTask.Wait();

                    material = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    material = Enumerable.Empty<Material>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(material);
        }

        // GET: MaterialViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MaterialViewController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: PetAnimals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("mId, mName, mType, mQuantity,mRetailer")] Material material)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5186/api/Material");
                    var postTask = client.PostAsJsonAsync("Material", material);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Error creating Material.");
                    }
                }
            }
            return View(material);
        }

        // POST: MaterialViewController/Create
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

        // GET: MaterialViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MaterialViewController/Edit/5
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

        // GET: MaterialViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MaterialViewController/Delete/5
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
