using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSEP.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string tipo { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string pais { get; set; }
        public string apelido { get; set; }
        public DateTime cadastro { get; set; }
        public bool ativo { get; set; }
    }
}