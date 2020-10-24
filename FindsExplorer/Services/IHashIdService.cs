using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindsExplorer.Services
{
    interface IHashIdService
    {
        int Decrypt(string id);
        string Encrypt(int id);
    }
}
