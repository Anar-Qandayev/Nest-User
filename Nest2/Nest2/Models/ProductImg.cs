using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest2.Models
{
    public class ProductImg
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsFront { get; set; }
        public bool IsBack { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
