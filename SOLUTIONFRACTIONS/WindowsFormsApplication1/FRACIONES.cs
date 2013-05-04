using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class FRACIONES
    {

        public int Numerador { get; set; }

        public int Denominador { get; set; }

        public FRACIONES()
             {

            this.Numerador = 1;
            this.Denominador = 1;
            }
            public FRACIONES(int num, int den)
            {
                this.Numerador = num;
                this.Denominador = den;

            }


            public void Sumar(FRACIONES f1, FRACIONES F2)
            {
                throw new NotImplementedException();
            }
    }
}
