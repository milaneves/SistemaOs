using Microsoft.EntityFrameworkCore;
using SistemaOS.Data;
using SistemaOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaOS.Repositorio
{
    public class OrdemServicoRepositorio
    {
        private readonly SistemaOsContext _context;


        public OrdemServicoRepositorio(SistemaOsContext context)
        {
            _context = context;
        }
        public List<OrdemServico> GetAll()
        {
            return _context.OrdemServico.ToList();
        }

        public OrdemServico GetById(int id)
        {
            return _context.OrdemServico.Where(f => f.Id == id).FirstOrDefault();
        }

        public List<OrdemServico> GetByOs(int ordem)
        {
            return _context.OrdemServico.Where(f => f.NumeroOS == ordem).ToList();

        }
        public void Create(OrdemServico ordem)
        {
            _context.OrdemServico.Add(ordem);
            _context.SaveChanges();
        }
        public void Update(OrdemServico ordem)
        {
            _context.Entry(ordem).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(OrdemServico ordem)
        {
            _context.OrdemServico.Remove(ordem);
            _context.SaveChanges();
        }
    }
}
