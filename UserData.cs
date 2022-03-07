using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class UserData
    {
        public static List<User> GetUsers()
        {
            List<User> lUser = new List<User>();

            User user1 = new User();
            user1.username = "iris";
            user1.password = "123";
            user1.rubro = "ProgramasTV";

            lUser.Add(user1);

            User user2 = new User();
            user2.username = "astrid";
            user2.password = "123";
            user2.rubro = "Libros";

            lUser.Add(user2);

            User user3 = new User();
            user3.username = "rocio";
            user3.password = "555";
            user3.rubro = "LenguajesProg";

            lUser.Add(user3);

            User user4 = new User();
            user4.username = "abrego";
            user4.password = "123";
            user4.rubro = "LenguajesProg";

            lUser.Add(user4);

            User user5 = new User();
            user5.username = "hernandez";
            user5.password = "123";
            user5.rubro = "Libros";

            lUser.Add(user5);
            return lUser;
        }
        public class User
        {
            public string username { get; set; }
            public string password { get; set; }
            public string rubro { get; set; }
        }        
    }
}
