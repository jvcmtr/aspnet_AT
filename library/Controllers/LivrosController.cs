using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using library.Data;
using library.Models;

namespace library.Controllers
{
    public class LivrosController : Controller
    {
        private readonly libraryContext _context;

        public LivrosController(libraryContext context)
        {
            _context = context;
        }

        // GET: Livros
        [Route("/Livros")]
        public async Task<IActionResult> Index()
        {
              return _context.Livro != null ? 
                          View(await _context.Livro.ToListAsync()) :
                          Problem("Entity set 'libraryContext.Livro'  is null.");
        }

        // GET: Livros/Details/5
        [Route("/Livros/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Livro == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livros/Create
        [Route("/Livros/Add")]
        public IActionResult Create()
        {
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "LastName");
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Name");
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Livros/Add")]
        public async Task<IActionResult> Create([Bind("ISBN,Name,AutorId,GeneroId,Sinopse,DataDePublicacao,Id")] Livro livro)
        {
            livro.Created = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        // GET: Livros/Edit/5
        [Route("/Livros/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Livro == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }

            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "LastName");
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Name");
            return View(livro);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Livros/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("ISBN,Name,AutorId,GeneroId,Sinopse,DataDePublicacao,Created,Id")] Livro livro)
        {
            Console.WriteLine(livro.Created.ToString());
            if (id != livro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.Id))
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
            return View(livro);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Livro == null)
            {
                return NotFound();
            }

            var livro = await _context.Livro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Livro == null)
            {
                return Problem("Entity set 'libraryContext.Livro'  is null.");
            }
            var livro = await _context.Livro.FindAsync(id);
            if (livro != null)
            {
                _context.Livro.Remove(livro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
          return (_context.Livro?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
