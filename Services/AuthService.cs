using System.Linq;
using Database;

namespace Services
{
    public class AuthService
    {
        public static bool Login(string login, string password)
        {
            using (var appDbContext = new AppDbContext())
            {
                var user = appDbContext.Users.FirstOrDefault(u => u.Login == login);

                if (user == null)
                    return false;

                return user.Password == password;
            }
        }
    }
}