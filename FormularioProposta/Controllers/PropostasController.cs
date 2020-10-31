using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using FormularioProposta.Data;
using FormularioProposta.Models;
using FormularioProposta.Services.Filters;

namespace FormularioProposta.Controllers
{
    [Login]
    public class PropostasController : Controller
    {
        private readonly FormularioPropostaContext _context;

        public PropostasController(FormularioPropostaContext context)
        {
            _context = context;
        }

    
        // GET: Propostas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Proposta.ToListAsync());
        }

       
        // GET: Propostas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
            {
                return NotFound();
            }

            return View(proposta);
        }

    
        // GET: Propostas/Create
        public IActionResult Create()
        {
            return View();
        }

        

        // GET: Propostas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta.FindAsync(id);
            if (proposta == null)
            {
                return NotFound();
            }
            return View(proposta);
        }

        // POST: Propostas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCliente,Telefone,EmailCliente,ValorRenda,Mensagem,DataProposta")] Proposta proposta)
        {
            if (id != proposta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropostaExists(proposta.Id))
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
            return View(proposta);
        }

        // GET: Propostas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
            {
                return NotFound();
            }

            return View(proposta);
        }

        // POST: Propostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proposta = await _context.Proposta.FindAsync(id);
            _context.Proposta.Remove(proposta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropostaExists(int id)
        {
            return _context.Proposta.Any(e => e.Id == id);
        }
    }
}
