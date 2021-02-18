using DFCP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Metadata;
using BLL;
using BLL.Helper;
//using Projeto_Entra21_DFCP.Models;


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
        public IActionResult Principal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroAPI(string nome, string email, string senha, int idade, string profissao)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nome; usuario.Email = email; usuario.Senha = senha;
            usuario.Idade = idade; usuario.Profissao = profissao;
            bool validateBool = false;
            CadastrarBLL cadastrar = new CadastrarBLL();
            if(HelpValidate.IsValidName(usuario.Nome) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidName(usuario.Nome)
                return RedirectToAction("/Home/Cadastro");
            }
            if(HelpValidate.IsValidEmail(usuario.Email) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidEmail(email)
                return RedirectToAction("/Home/Cadastro");
            }
            if (HelpValidate.IsValidPasscode(usuario.Senha) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função HelpValidate.IsValidPasscode(senha)
                return RedirectToAction("/Home/Cadastro");
            }
            if(cadastrar.ValidarUsuario(usuario) == "")
            {
                validateBool = true;
            }
            else
            {
                //Não sei como fazer, mas se cair nesse else, retorna um alert com essa função cadastrar.Validarusuario(nome)
                return RedirectToAction("/Home/Cadastro");
            }
            if(validateBool)
            {
                cadastrar.Inserir(usuario);
            }
            return RedirectToAction("/Home/index");
        }
        [HttpPost]
        public IActionResult GanhosAPI(string motivo, double valor, int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            GanhosBLL ganhosBLL = new GanhosBLL();
            ganhosBLL.CadastrarValor(usuario, valor, motivo);
            return RedirectToAction("/Home/");
        }
        [HttpPost]
        public IActionResult ContasAPI(string motivo, double valor, int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            ContasBLL contasBLL = new ContasBLL();
            contasBLL.CadastrarValor(usuario, valor, motivo);
            return RedirectToAction("/Home/");
        }

        public IActionResult LoginAPI(string email, string senha)
        {
            Usuario usuario = new Usuario();
            LoginBLL loginBLL = new LoginBLL();
            usuario.Email = email; usuario.Senha = senha;
            loginBLL.ValidarUsuario(usuario);
            if (loginBLL.ValidaLogin(usuario) != "")
            {
                return RedirectToAction("/Home/Login");
            }
            return RedirectToAction("/Home/");
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult SaldoAPI(string motivo, double valor, int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            SaldoBLL saldoBLL = new SaldoBLL();
            saldoBLL.CadastrarValor(usuario, valor, motivo);
            return RedirectToAction("/Homes/");
        }

        public IActionResult GastosAPI(string motivo, double valor, int id)
        {
            Usuario usuario = new Usuario();
            usuario.Id = id;
            GastosBLL gastosBLL = new GastosBLL();
            gastosBLL.CadastrarValor(usuario, valor, motivo);
            return RedirectToAction("/Home/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
