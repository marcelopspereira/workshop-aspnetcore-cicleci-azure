using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkshopAspnetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace WorkshopAspnetCore.Controllers
{
    [Route("api/pessoas")]
    public class PessoasControler : Controller
    {
        private readonly DataContext _dataContext;
        public PessoasControler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> ObterPessoas()
        {
            var pessoas = await _dataContext.Pessoas.ToListAsync();
            return Json(pessoas);
        }

         [HttpPost]
        public async Task<IActionResult> CriaPessoa([FromBody]Pessoa modelo)
        {
            await _dataContext.Pessoas.AddAsync(modelo);
            await _dataContext.SaveChangesAsync();
            return Json(modelo);
        }
    }
}