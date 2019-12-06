using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core1
{
    public class Servicio : IServicio
    {
        Random rnd = new Random();
        public List<Alumno> GetAlumnos()
        {
            List<Alumno> result = new List<Alumno>();
            result.Add(new Alumno() { CI = 7262318, Nombre = "Daniel Ojalvo" });
            result.Add(new Alumno() { CI = 7654321, Nombre = "Juan Perez" });
            result.Add(new Alumno() { CI = 1234567, Nombre = "Maria Lopez" });
            return result;
        }

        public int GetNota(int CI)
        {
            //
            int nota;
            if (CI == 500)
            {
                nota = 0;
            }
            else
            {
                nota = rnd.Next(1, 100);
            }
            return nota;
        }

        public void Validar(string token)
        {
            if (String.IsNullOrEmpty(token))
            {
                throw new Exception("token invalido");
            }
        }

        public string GetEstado(int nota)
        {
            string estado;
            if (nota >= 50)
            {
                estado = "Aprobado";
            }
            else
            {
                estado = "Reprobado";
            }
            return estado;
        }
    }
}
