using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.Entidades
{
    public class Clientes
    {
        int id;
        string nome, sexo;
        DateTime data;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string RepitaSenha { get; set; }
    }
}
