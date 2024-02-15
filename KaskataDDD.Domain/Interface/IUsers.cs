using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Domain.Interface
{
    internal interface IUsers
    {
        Task<bool> CreateUser(string email, string password, int idade, string phone);
    }
}
