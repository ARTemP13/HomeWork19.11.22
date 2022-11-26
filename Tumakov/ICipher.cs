using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal interface ICipher
    {
        string encode(string str);
        string decode(string str);
    }
}
