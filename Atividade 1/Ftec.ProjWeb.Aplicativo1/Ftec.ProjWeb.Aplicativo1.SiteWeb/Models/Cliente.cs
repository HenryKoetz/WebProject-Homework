using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftec.ProjWeb.Aplicativo1.SiteWeb.Models
{
    public class Cliente
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        /*
        public int Codigo
        {
            set
            {
                if (value == 1)
                {
                    this.codigo = 2;
                }
                else
                {
                    this.codigo = value;
                }
                
            }
            get
            {
                return this.codigo;
            }
        }
        */

        /*
            //Get/Set padrao Java
            public void SetCodigo(int codigo)
            {
                this.codigo = codigo;
            }

            public int GetCodigo()
            {
                return this.codigo;
            }
        */

    }
}