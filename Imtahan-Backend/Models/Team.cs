using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Backend.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Desc { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instargarm { get; set; }
        public string Linkedin { get; set; }
    }
}
