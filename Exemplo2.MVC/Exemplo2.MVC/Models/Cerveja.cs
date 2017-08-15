using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemplo2.MVC.Models
{
    public class Cerveja
    {
        public string Nome { get; set; }
        public DateTime Validade { get; set; }
        public int Teor { get; set; }
        
    }
}