using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Exercicio_Controle_Acesso
{
    class Usuario
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string Email { get; set; }
        
        public string Login { get; set; }
        
        public string Senha { get; set; }
        
        public DateTime DataUltimoAcesso { get; set; }
    
       
    }
}
