using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LanchesMac.Data;
using LanchesMac.Models;
using LanchesMac.Repositories.Interface;
using LanchesMac.Repositories.Repository;

namespace LanchesMac.Controllers
{
    public class LanchesController : Controller
    {
        private readonly ILanche _lancheRepository;

        public LanchesController(ILanche lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        // GET: Lanches
        public async Task<IActionResult> Index()
        {
              return View(_lancheRepository.lanches.ToList());
        }

        // GET: Lanches/Details/5
        public IActionResult Details(long? id)
        {
            if (id == null || _lancheRepository == null)
            {
                return NotFound();
            }

            var lanche =  _lancheRepository.lanchesPreferidos
                .FirstOrDefault(m => m.Id == id);
            if (lanche == null)
            {
                return NotFound();
            }

            return View(lanche);
        }

        // GET: Lanches/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Preco,Ativo")] Lanche lanche)
        {
            if (ModelState.IsValid)
            {
                _lancheRepository.Save(lanche);
                
                return RedirectToAction(nameof(Index));
            }
            return View(lanche);
        }

        // GET: Lanches/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _lancheRepository == null)
            {
                return NotFound();
            }
            var lanche = _lancheRepository.GetId(id);
            if (lanche == null)
            {
                return NotFound();
            }
            return View(lanche);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nome,Descricao,Preco,Ativo")] Lanche lanche)
        {
            if (id != lanche.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _lancheRepository.Update(lanche);                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancheExists(lanche.Id))
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
            return View(lanche);
        }

        // GET: Lanches/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _lancheRepository == null)
            {
                return NotFound();
            }

            var lanche = _lancheRepository.GetId(id);
            if (lanche == null)
            {
                return NotFound();
            }

            return View(lanche);
        }

        // POST: Lanches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_lancheRepository == null)
            {
                return Problem("Entity set 'LanchesMacContext.Lanche'  is null.");
            }
            var lanche =  _lancheRepository.GetId(id);
            if (lanche != null)
            {
                _lancheRepository.Remove(lanche);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool LancheExists(long id)
        {
          return _lancheRepository.lanches.Any(x => x.Id == id);
        }
    }
}
