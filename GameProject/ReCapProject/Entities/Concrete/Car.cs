using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car
    {
        public int ID { get; set; }
        public string BrandId { get; set; }
        public string ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
