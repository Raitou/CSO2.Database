using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Entities.Interfaces
{
    public interface IUser
    {
        public string Username { get; }

        public string Email { get; }

        public string Password { get; }

        public string? IPAddress { get; }

        public int LoginFailedCount { get; }

        public DateTime? LastLoggedIn { get; }
    }
}
