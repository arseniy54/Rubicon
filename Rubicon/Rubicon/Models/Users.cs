using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubicon.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string isBoy { get; set; }

        public DateTime Birthday { get; set; }

        public Blob Avatar { get; set; }

    }
}
