using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.ViewComponents
{
    public class SaudacaoAlunoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Pegar aluno no BD !!!
            // Pegar o dado (nome) do aluno que esta logado
            Aluno aluno = new Aluno { Nome = "Danilo"};

            return View(aluno);
        }
    }
}
