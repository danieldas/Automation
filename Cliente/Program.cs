using Core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========");
            IServicio serv = new Servicio();
            Admin admin = new Admin("Daniel", "123", serv);

            List<Alumno> ListaNota = admin.GetNotas();

            foreach (var item in ListaNota)
            {
                Console.WriteLine("CI:{0} - Nombre:{1} - Nota:{2}",
                    item.CI, item.Nombre, item.Nota);
            }

            Console.WriteLine("=========");
            Console.ReadKey();

        }
    }
}
