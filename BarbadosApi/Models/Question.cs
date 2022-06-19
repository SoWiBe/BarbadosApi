using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarbadosApi.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int IdManager { get; set; }
        public int IdClient { get; set; }
        public int IdDirection { get; set; }
        public int IdStatus { get; set; }
        public string Info { get; set; }
    }
}
