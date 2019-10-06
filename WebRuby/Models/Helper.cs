using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;

namespace WebRuby.Models
{
    public class Helper
    {
        public static Guid GetCurrentUserId()
        {
            var user = Thread.CurrentPrincipal as ClaimsPrincipal;
            if (user != null)
            {
                var claim = user.Claims.Where(c => String.Compare(c.Type, ClaimTypes.NameIdentifier, true) == 0).FirstOrDefault();
                return Guid.Parse(claim.Value);
            }
            return default(Guid);
        }
    }
}