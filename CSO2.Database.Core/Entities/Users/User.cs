using CSO2.Database.Core.Entities.Base;
using CSO2.Database.Core.Entities.Currencies;
using CSO2.Database.Core.Entities.Interfaces;

namespace CSO2.Database.Core.Entities.Users
{
    public class User : Entity, IUser
    {
        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public virtual Nickname? Nickname { get; set; }

        public virtual Currency? Currency { get; set; }

        public string? IPAddress { get; set; }

        public int LoginFailedCount { get; set; } = 0;

        public DateTime? LastLoggedIn { get; set; } = null;

    }
}
