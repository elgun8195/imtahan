using Imtahan_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Backend.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Team> Team { get; set; }
    }
}
