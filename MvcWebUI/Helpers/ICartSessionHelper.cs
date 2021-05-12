using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Helpers
{
    public interface ICartSessionHelper
    {
        Cart cart();
        void SetCart(Cart cart);
        void Clear();
    }
}
