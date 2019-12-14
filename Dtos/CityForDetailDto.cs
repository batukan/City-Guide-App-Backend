using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityGuide.API.Models;

namespace CityGuide.API.Dtos
{
    public class CityForDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Photo> Photos { get; set; }

    }
}
