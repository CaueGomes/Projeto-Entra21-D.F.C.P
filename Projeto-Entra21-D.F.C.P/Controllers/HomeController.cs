using DFCP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Helper;


namespace Projeto_Entra21_DFCP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Ganhos()
        {
            return View();
        }
        public IActionResult Saldo()
        {
            return View();
        }
        public IActionResult Contas()
        {
            return View();
        }
        public IActionResult Gastos()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult CadastroAPI(string nome, string email, string senha, int idade, string profissao)
        {
            bool validateBool = false;
            Cadastrar cadastrar = new Cadastrar();
            if(HelpValidate.IsValidName(nome) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidName(nome)
                return RedirectToAction("/Home/Cadastro");
            }
            if(HelpValidate.IsValidEmail(email) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidEmail(email)
                return RedirectToAction("/Home/Cadastro");
            }
            if (HelpValidate.IsValidPasscode(senha) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidPasscode(senha)
                return RedirectToAction("/Home/Cadastro");
            }
            if(validateBool)
            {
                cadastrar.Inserir(nome, email, senha, idade, profissao);
            }
            return RedirectToAction("/Home/index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
