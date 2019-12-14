using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.API.Dtos
{
    public class UserForLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
