﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.report.model02.Service
{
    public interface ITransaccion <T>
    {
        // definir la firma
        int Registrar(T t);
    }

}
