using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        // Administrador - 3
        // Desarrollador - 2
        // Usuario Final - 1
        static void Main(string[] args)
        {
            Rol tipoUsuario = Rol.Administrador;
            bool isAdmin = ValidarUsuario(tipoUsuario);
            if (isAdmin)
            {
                Console.WriteLine(Rol.Administrador);
            }

            Console.ReadLine();
        }

        public static bool ValidarUsuario(Rol rol)
        {
            switch (rol)
            {
                case Rol.Administrador:
                    Console.WriteLine("Administrador");
                    return true;
                case Rol.Desarrollador:
                    Console.WriteLine("Desarrollador");
                    return false;
                case Rol.UsuairoFinal:
                    Console.WriteLine("Usuario Final");
                    return false;
                default:
                    return false; ;
            }
        }
    }
}
