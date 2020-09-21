using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ASP_SampleAPI_NoIdentity.Models
{
    public class RefreshToken
    {
        public string Id { get; set; }

        public string UserAgentSha256 { get; set; }

        public string Ip { get; set; }

        public DateTime Expiration { get; set; }

        public bool Deactivated { get; set; } = false;

        public int UserId { get; set; }

        public User User { get; set; }

        public static string GenerateId()
        {
            byte[] id = new byte[32];
            var provider = new RNGCryptoServiceProvider();
            provider.GetBytes(id);
            return Convert.ToBase64String(id);
        }
    }
}
