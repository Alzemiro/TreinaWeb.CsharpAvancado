using System;
using System.Collections.Generic;
using System.Text;

namespace CovarianciaContravaiancia
{
    interface IRecuperador<out T>
    {
       public T Recuperar(int codigo);
    }
}
