using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivador<T,U>
    {
        void Guardar(T tipo);
        
    }
}
