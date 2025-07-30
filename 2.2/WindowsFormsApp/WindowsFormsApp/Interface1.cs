using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public interface IcalculoIds<T> //para calcular id de un nuevo objeto, pude ser un usario,movil,producto,paquete,etc
    {
       int calcularID(string ruta);
    }
}
