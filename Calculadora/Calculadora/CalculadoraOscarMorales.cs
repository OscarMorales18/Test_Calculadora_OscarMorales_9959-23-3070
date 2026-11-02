using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Calculadora
    {

        public static int Suma(int item1, int item2)
        {
            return item1 + item2;
        }

        public static int Resta(int item1, int item2)
        {
            return item1 - item2;
        }

        public static int Division(int item1, int item2)
        {
            return item1 / item2;
        }

        public static int Multiplicacion(int item1, int item2)
        {
            return item1 * item2;
        }
    }
}
