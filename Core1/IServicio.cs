using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1
{
    public interface IServicio
    {
        void Validar(string token);
        List<Alumno> GetAlumnos();
        int GetNota(int CI);

        string GetEstado(int nota);
    }
}
