using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1GUSTAVOP.SIQUIEIRA16.Code.DTO
{
    class LojaDTO
    {
        private int _ID;
        private string _Nome, _Categoria;

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value;}
        public int ID { get => _ID; set => _ID = value; }
    }
}
