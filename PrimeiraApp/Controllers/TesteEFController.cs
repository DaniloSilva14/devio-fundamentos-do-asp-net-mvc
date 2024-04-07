using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class TesteEFController : Controller
    {
        public AppDbContext Db { get; set; }

        public TesteEFController(AppDbContext db)
        {
            Db = db;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Danilo",
                Email = "hello@danilo.com",
                DataNascimento = new DateTime(2001, 06, 06),
                Avaliacao = 5,
                Ativo = true
            };

            // CRIAR
            Db.Alunos.Add(aluno);
            Db.SaveChanges();

            // ALTERAR
            //var alunoChange = Db.Alunos
            //    .Where(a => a.Nome.Contains("Danilo")).FirstOrDefault();
            //alunoChange.Nome = "Danilo Silva";

            //Db.Alunos.Update(alunoChange);
            //Db.SaveChanges();

            // REMOVER
            //var alunoDelete = Db.Alunos
            //    .Where(a => a.Nome.Contains("danilo")).FirstOrDefault();

            //Db.Alunos.Remove(alunoDelete);
            //Db.SaveChanges();

            return View();
        }
    }
}
