using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormularioProposta.Data;
using FormularioProposta.Library.Mail;
using FormularioProposta.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormularioProposta.Controllers
{
    public class HomeController : Controller
    {
        private readonly FormularioPropostaContext _context;

        public HomeController(FormularioPropostaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                if (usuario.Email == "antonio@marant.com.br" && usuario.Senha == "Antonio@1994" || usuario.Email == "marluce@marant.com.br" && usuario.Senha == "Marluce@1988")
                {

                    HttpContext.Session.SetString("Login", "true");
                   

                    return Redirect("/Propostas/Index");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos";
                    return View();
                    
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        // GET: Propostas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCliente,Telefone,EmailCliente,ValorRenda,Mensagem,DataProposta")] Proposta proposta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proposta);
                await _context.SaveChangesAsync();

                TempData["Mensagem"] = "Mensagem Enviada, aguarde nosso contato";

                SendMail.EnviarMensagemContato(proposta);

                return RedirectToAction(nameof(Index));
            }
            return View(proposta);
        }


    }
}