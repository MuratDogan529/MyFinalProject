
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Çıplak Class kalmasın.--interface almıyorsa böyle deriz.İnterface ile implente edeceğiz
    //Concrete klasöründeki her veritabanı tablosunu IEntity interface clası ile inheritance(miras) yapmalıyız.

    public class Category:IEntity 
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
