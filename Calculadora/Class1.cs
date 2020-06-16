using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
        private float num1;
        private float num2;

        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }

        public float Suma()
        {
            return Num1 + Num2;
        }

        public float Resta()
        {
            return Num1 - Num2;
        }

        public float Multiplicacion()
        {
            return Num1 * Num2;
        }

        public float Division()
        {
            if(Num2 != 0)
            {
                return Num1 / Num2;
            }else
            {
                return -9999;
            }
        }
    }
}
