using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imtahan_Backend.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instargarm { get; set; }
        public string Linkedin { get; set; }
        public string Skype { get; set; }

    }
}
