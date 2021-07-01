using Microsoft.AspNetCore.Mvc;
using SistemaOS.Data;
using SistemaOS.Models;
using SistemaOS.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaOS.Controllers
{
    public class OrdemServicoController : Controller
    {
        private readonly OrdemServicoRepositorio _ordemServicoRepositorio;
        private readonly SistemaOsContext _context;


        public OrdemServicoController()
        {
            _context = new SistemaOsContext();
            _ordemServicoRepositorio = new OrdemServicoRepositorio(_context);
       }

        public IActionResult Index()
        {
            var ordem = _ordemServicoRepositorio.GetAll();
            return View(ordem);
        }
  

        [HttpPost]
        public IActionResult ConsultarAnimal(Pesquisa pesquisa)
        {

            var ordem = _ordemServicoRepositorio.GetByOs(pesquisa.numeroOs);
            if (ordem == null)
            {
                return NotFound();
            }

            return View("Consultar", ordem);
        }

        public class Pesquisa
        {
            public int numeroOs { get; set; }
        }

        public IActionResult Cadastrar()
        {
      
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmaCadastro(OrdemServico _ordem)
        {
            try
            {
                var ordem = new OrdemServico
                {
                    NumeroOS = _ordem.NumeroOS,
                    TituloServico = _ordem.TituloServico,
                    NomeCliente = _ordem.NomeCliente,
                    CNPJCliente = _ordem.CNPJCliente,
                    NomePrestador = _ordem.NomePrestador,
                    CPFPrestador = _ordem.CPFPrestador,
                    DataExecucao = _ordem.DataExecucao,
                    Valor = _ordem.Valor
                };


                _ordemServicoRepositorio.Create(ordem);

                return RedirectToAction(nameof(ConsultarAnimal));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
