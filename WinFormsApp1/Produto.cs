using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Produto
    {
        public string Codigo { get ; set; } 
        // Controla os valores que entrem e saem
        public string Descricao { get; set;}
        public double ValorAqui { get; set; }
        public double Lucro { get; set; }

        public double ValordaVenda { get; set; }    

        public Produto()
        {

        }
        public Produto (string codigo, string descricao, double ValorAqui, double Lucro, double ValordaVe)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.ValordaVenda = ValordaVe;
            this.ValorAqui = ValorAqui;
            this.Lucro = Lucro; 
        }
    }
}
