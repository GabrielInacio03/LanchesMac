using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Models.Utils
{
    public static class LancheUtils
    {
        public static bool IsValidId(long id)
        {
            if (id == null)
                return false;
            else
                return true;
            
        }
    }
}
