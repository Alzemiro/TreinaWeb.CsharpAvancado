﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CovarianciaContravaiancia
{
    interface IArmazenador<in T>
    {
        public void Armazenar(T item);
    }
}
