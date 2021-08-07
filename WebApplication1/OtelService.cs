using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public interface IOtelService
    {
        public string Ad { get; set; }
        public string OtelGetir();
    }

    public class OtelService:IOtelService
    {
        public OtelService()
        {
            Ad = Guid.NewGuid().ToString();
        }

        public string Ad { get; set; }

        public string OtelGetir()
        {
            return Ad;
        }
    }
}
