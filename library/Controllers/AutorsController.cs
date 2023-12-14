using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using library.Data;
using library.Models;
using Microsoft.AspNetCore.Hosting;

namespace library.Controllers
{
    public class AutorsController : Controller
    {
        private readonly libraryContext _context;
        private readonly IWebHostEnvironment webEnv;

        public AutorsController(libraryContext context, IWebHostEnvironment webEnv)
        {
            this.webEnv = webEnv;
            _context = context;
        }

        // GET: Autors
        [Route("/Autors")]
        public async Task<IActionResult> Index()
        {
              return _context.Autor != null ? 
                          View(await _context.Autor.ToListAsync()) :
                          Problem("Entity set 'libraryContext.Autor'  is null.");
        }

        // GET: Autors/Details/5

        [Route("/Autors/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Autor == null)
            {
                return NotFound();
            }

            var autor = await _context.Autor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autor == null)
            {
                return NotFound();
            }

            return View(autor);
        }

        // GET:
        [Route("/Autors/Add")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Autors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Autors/Add")]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,birth,Upload,ImageFile")] Autor autor)
        {
            autor.Created = DateTime.Now;
            autor.ImageFile = "default.jpg";

            if (autor.Upload is not null)
            {
                autor.ImageFile = autor.Upload.FileName;
                var img = Path.Combine(webEnv.ContentRootPath, "wwwroot/images/", autor.Id+autor.ImageFile);

                using (var stream = new FileStream(img, FileMode.Create)){
                    autor.Upload.CopyTo(stream);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(autor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autor);
        }

        // GET: Autors/Edit/5
        [Route("/Autors/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Autor == null)
            {
                return NotFound();
            }

            var autor = await _context.Autor.FindAsync(id);
            if (autor == null)
            {
                return NotFound();
            }
            return View(autor);
        }

        // POST: Autors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Autors/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("FirstName,LastName,birth,Upload,Created,ImageFile,Id")] Autor autor)
        {
            if (id != autor.Id)
                return NotFound();

            if (autor.Upload is not null)
            {
                autor.ImageFile = autor.Upload.Name;
                var img = Path.Combine(webEnv.ContentRootPath, "wwwroot/images/", autor.ImageFile);

                using (var stream = new FileStream(img, FileMode.Create))
                {
                    autor.Upload.CopyTo(stream);
                }
            }


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutorExists(autor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            var errors = ModelState.Values.SelectMany(v => v.Errors);
            Console.WriteLine(errors);
            return View(autor);
        }

        // GET: Autors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Autor == null)
            {
                return NotFound();
            }

            var autor = await _context.Autor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autor == null)
            {
                return NotFound();
            }

            return View(autor);
        }

        // POST: Autors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Autor == null)
            {
                return Problem("Entity set 'libraryContext.Autor'  is null.");
            }
            var autor = await _context.Autor.FindAsync(id);
            if (autor != null)
            {
                _context.Autor.Remove(autor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutorExists(int id)
        {
          return (_context.Autor?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
