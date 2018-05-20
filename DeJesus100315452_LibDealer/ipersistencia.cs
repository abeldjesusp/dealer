using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeJesus100315452_LibDealer
{
    public interface iPersistencia
    {
        bool Grabar();
        bool Leer();
        string getMensaje();
    }
}
