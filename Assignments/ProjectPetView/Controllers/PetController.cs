using System.Collections.Generic;
using CoreApiEFProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectPetView.Models;

namespace ProjectPetView.Controllers
{
    public class PetController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<PetAnimal> pets = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5028/api/PetAnimals");
                //HTTP GET
                var responseTask = client.GetAsync("PetAnimals");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList<PetAnimal>>();
                    readTask.Wait();

                    pets = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    pets = Enumerable.Empty<PetAnimal>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(pets);
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetAnimals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("petId, petName, petType, petDob, petIsVeg")] PetAnimal petAnimal)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5028/api/PetAnimals");
                    var postTask = client.PostAsJsonAsync("PetAnimals", petAnimal);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Error creating pet animal.");
                    }
                }
            }
            return View(petAnimal);
        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(int id, [Bind("petId, petName, petType, petDob, petIsVeg")] PetAnimal petAnimal)
        {
            if (id != petAnimal.petId)
            {
                ModelState.AddModelError(string.Empty, "Pet ID mismatch.");
                return View(petAnimal);
            }

            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5028/api/PetAnimals");

                    try
                    {
                        var response = await client.PutAsJsonAsync($"PetAnimals/{id}", petAnimal);

                        if (response.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            var errorMessage = await response.Content.ReadAsStringAsync();
                            ModelState.AddModelError(string.Empty, $"Error updating pet animal: {errorMessage}");
                        }
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError(string.Empty, $"An error occurred while updating the pet: {ex.Message}");
                    }
                }
            }

            return View(petAnimal);
        }

    }
}
