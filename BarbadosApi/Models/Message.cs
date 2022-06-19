using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarbadosApi.Models
{
    public class Message
    {
        [Key]
        public string Id { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
    }
}
