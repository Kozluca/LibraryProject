using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace MvcProje.Controllers
{
    public class AuthorController : Controller
    {

        public IActionResult Index()            // Yazarlar bölümünün AnaSayfasını(Index) göstrir
        {
            var Authors = AuthorData.Authors;  // AthorsData.Authors daki verileri aldık


            return View();
        }

        public IActionResult Create()               //Create sayfası için oluşturduk 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AuthorViewModel author) //Create sayfası için oluşturduk AuthorViewModel den author tanımladık(override)
        {
            if (ModelState.IsValid)    //if ile eğer bilgiler geçerli ise komutu oluştruduk
            {
                Author newAuthor = new Author()    //newAuthor adında Liste oluştuduk 
                {
                    Name = author.Name,                                 //oluşan listeye eklenecek verileri tanımladık
                    Id = AuthorData.Authors.Max(a => a.Id) + 1,         //Id için AuthordData.Authors da ki en yüksek Id nin 1 fazlı olacak veriyi tanımladık
                    SurName = author.SurName,
                    DateOfBorn = author.DateOfBorn,
                };
                AuthorData.Authors.Add(newAuthor);                          // AuthorData.Authors'a newAuthor u ekledik
                TempData["Mesaj"] = "Yazar başarıyla eklendi.";             //TempData ile Mesaj Tanımladık
                return RedirectToAction("List");                            // işlem bittikten sonra List e döndürdük.
            }
            return View();
        }

        public IActionResult List()   //List sayfası için  oluşturduk
        {

            ViewBag.AuthorCount = AuthorData.Authors.Count;  // yazar listesindeki yazar sayısını mesaj olarak göndermek için viewbag.AuthorCount oluşturduk
            return View(AuthorData.Authors);    // AuthorData.Authors daki bilgileri döndürdük
        }
      
        public IActionResult DeleteConfirm(int id)  //Delete sayfası için oluşturduk int Id değeri tanımladık
        {
            Author? author = AuthorData.Authors.FirstOrDefault(a => a.Id == id); // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar
            if (author == null)     //author null ise 
            {
                return NotFound();      // notfound döndürdük
            }
            return View(author);        // author döndürdük
        }

        [HttpPost]
        public IActionResult Delete(int id)         //Delete sayfası için  oluşturduk int Id değeri tanımladık
        {
            Author? author = AuthorData.Authors.FirstOrDefault(a => a.Id == id);    // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar
            if (author == null)                      //author null ise 
            {
                return NotFound();                   // notfound döndürdük
            }
            AuthorData.Authors.Remove(author);      // AuthorData.Authors dan author u sildik
            TempData["Mesaj"] = "Yazar başarıyla silindi.";
            return RedirectToAction("List");   // Index e git
        }

        public IActionResult AuthorDetail(int id)    //AuthorDetail sayfası için  oluşturduk int Id değeri tanımladık (override)
        {
            Author? author = AuthorData.Authors.FirstOrDefault(a => a.Id == id);    // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar

            if (author == null)         //author null ise 
                return NotFound();       // notfound döndürdük

            AuthorViewModel vm = new AuthorViewModel() // AuthorViewModel den vm adında yeni liste oluşturduk
            {
                Name = author.Name,                 //değerleri atadık
                SurName = author.SurName,
                DateOfBorn = author.DateOfBorn,
                Id = author.Id
            };
            return View(vm); // vm döndürdük
        }
        public IActionResult Edit(int id)    //Edit sayfası için  oluşturduk int Id değeri tanımladık (override)
        {
            Author? author = AuthorData.Authors.FirstOrDefault(a => a.Id == id);    // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar

            if (author == null)
                return NotFound();

            AuthorViewModel vm = new AuthorViewModel() // AuthorViewModel den vm adında yeni liste oluşturduk
            {
                Name = author.Name,
                SurName = author.SurName,                //değerleri atadık
                DateOfBorn = author.DateOfBorn,
                Id = author.Id
            };
            TempData["Mesaj"] = " Yazar başarıyla Düzenlendi.";
            return View(vm);                             // vm döndürdük     
        }

        [HttpPost]
        public IActionResult Edit(AuthorViewModel vm)   //Edit sayfası için  oluşturduk AuthorViewModel den vm tanımladık (override)
        {
            Author? author = AuthorData.Authors.FirstOrDefault(a => a.Id == vm.Id); // Id için  eğer sonuç var ise döndürür yoksa defaul değeri atar

            if (author == null) return NotFound();   //author null ise  notfound döndürdük

            if (ModelState.IsValid)
            {
                author.Name = vm.Name;
                author.DateOfBorn = vm.DateOfBorn;               //değerleri atadık
                author.SurName = vm.SurName;
                TempData["Mesaj"] = "Değişiklikler başarıyla kaydedildi.";
                return RedirectToAction("List");                  //Liste döndürdük
            }

            return View(vm);    //vm döndürdük
        }

    }
}
