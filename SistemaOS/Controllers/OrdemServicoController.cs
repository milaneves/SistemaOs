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
        public IActionResult ConsultarOrdem(Pesquisa pesquisa)
        {

            var ordem = _ordemServicoRepositorio.GetByOs(pesquisa.numeroOs);
            if (ordem == null)
            {
                return NotFound();
            }

            return View("Index", ordem);
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

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IActionResult Editar(int id)
        {
            OrdemServico ordem = _ordemServicoRepositorio.GetById(id);
            return View(ordem);
        }
   

        [HttpPost]
        public IActionResult ConfirmarEdicao(OrdemServico _ordem, int id)
        {
            OrdemServico ordemSelecionada = _ordemServicoRepositorio.GetById(id);

            if (_ordem == null)
            {
                return NotFound();
            }

            try
            {
                ordemSelecionada.NumeroOS = _ordem.NumeroOS;
                ordemSelecionada.TituloServico = _ordem.TituloServico;
                ordemSelecionada.NomeCliente = _ordem.NomeCliente;
                ordemSelecionada.CNPJCliente = _ordem.CNPJCliente;
                ordemSelecionada.CPFPrestador = _ordem.CPFPrestador;
                ordemSelecionada.NomePrestador = _ordem.NomePrestador;
                ordemSelecionada.Valor = _ordem.Valor;
                ordemSelecionada.DataExecucao = _ordem.DataExecucao;


                _ordemServicoRepositorio.Update(ordemSelecionada);



                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IActionResult Deletar(int id)
        {
            try
            {

                var ordem = _context.OrdemServico.FirstOrDefault(m => m.Id == id);

                if (ordem == null)
                {
                    return NotFound();
                }

                return View(ordem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult ConfirmarDelete(int id)
        {
            var ordem = _ordemServicoRepositorio.GetById(id);
            if (ordem == null)
            {
                return NotFound();
            }

            try
            {
                _ordemServicoRepositorio.Delete(ordem);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IActionResult Detalhes(int id)
        {
            OrdemServico ordem = _ordemServicoRepositorio.GetById(id);
            return View(ordem);
        }


    }
}
