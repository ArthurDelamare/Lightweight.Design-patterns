using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight.DesignPatterns.GenericFactory
{
    public class BasicFactory : IGenericFactory
    {
        public TProduct Create<TProduct>() where TProduct : new()
        {
            return new TProduct();
        }
    }
}
