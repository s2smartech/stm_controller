using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stm_controller
{
    class GenerateInterceptor
    {
        string packet = "";
        public string Response(string buffer)
        {
            packet = buffer;

            packet += 'L';
            packet += buffer.Substring(1);


            return packet;
        }
    }
}
