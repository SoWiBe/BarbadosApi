using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarbadosApi.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string fio { get; set; }
        public string image { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
