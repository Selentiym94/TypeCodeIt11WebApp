using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeCodeIt11.Logic.Models;


namespace TypeCodeIt11.Logic.Interfaces
{
    public interface ITypeCodeClient
    {
        Task<List<User>> GetUsers(string name);

    }
}
