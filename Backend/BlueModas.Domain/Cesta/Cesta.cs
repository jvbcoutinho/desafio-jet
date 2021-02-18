using System.Collections.Generic;

namespace BlueModas.Domain.Cesta
{
    public class Cesta : Entity
    {
        public IList<CestaItem> Itens { get; private set; }
    }
}