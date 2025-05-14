using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mesdoc.Application.DTOs;

namespace mesdoc.Application.Interfaces
{
    public interface IUserServices
    {   
        public List<User> GetUsers();
    }
}
