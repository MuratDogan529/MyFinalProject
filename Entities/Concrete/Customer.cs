using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string MusteriID{ get; set; }
        public string Telefon { get; set; }
        public string SirketAdi { get; set; }
        public string Sehir { get; set; }

    }
}
