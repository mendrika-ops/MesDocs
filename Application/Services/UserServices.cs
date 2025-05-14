using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mesdoc.Application.DTOs;
using mesdoc.Application.Interfaces;

namespace mesdoc.Application.Services
{
    public class UserServices: IUserServices
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Name = "John", FirstName = "Doe", Age = 30 });
            return users;
        }
    }
}
