using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authentication_jwt.Models; 

namespace authentication_jwt.Repository
{
    public class UserRepository
    {
        public static User VerifyUserAndPassword(string username, string password)
        {
            //simulando consulta em banco de dados
            var users = new List<User>
            {
                new User("werik", "Gerente", "29099090"),
                new User("ester", "Diretor", "violleta44"),
                new User("isaac", "Especialist Developer", "iloveliving")
            };


            var user = users
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefault();

            return user;
        }
    }
}
