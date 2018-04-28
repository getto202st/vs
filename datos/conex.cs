using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is a fuking comment
namespace datos
{
    class conex
    {
        public string servidor { set; get; }
        public string usuario { set; get; }
        public string bd { set; get; }
        public string pwd { set; get; }

        public string conectar()
        {
            string cadena;
            cadena = "server='" + this.servidor + "'; Integrated Security=false; '" + this.bd + "'; uid='" + this.usuario + "'; pwd='" + this.pwd + "`";
            return cadena;

        }

    }
}
