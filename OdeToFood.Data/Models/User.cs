using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Meal { get; set; }
        public int Status { get; set; }
    }
}