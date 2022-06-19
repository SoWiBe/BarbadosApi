using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarbadosApi.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Image { get; set; }
        public string Grade { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Experiance { get; set; }
        public int CountQuestions { get; set; }
    }
}
