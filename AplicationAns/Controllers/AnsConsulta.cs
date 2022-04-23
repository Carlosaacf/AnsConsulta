using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicationAns.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicationAns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnsConsulta : ControllerBase
    {
        private static List<Cpf> Cpfs = new List<Cpf>();
        public void AdicionarCpf(Cpf cpf)
        {
            Cpfs.Add(cpf);
            Console.WriteLine(cpf.NomeTitular);

        }
    }
}
