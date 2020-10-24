using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HashidsNet;

namespace FindsExplorer.Services
{
    public class HashIdService : IHashIdService
    {
        private readonly Hashids _hash;
        public HashIdService()
        {
            _hash = new Hashids("FiEx(4-00-83)mn4d6kv5");
        }
        public int Decrypt(string id)
        {
            return _hash.Decode(id).First();
        }

        public string Encrypt(int id)
        {
            return _hash.Encode(id);
        }
    }
}
