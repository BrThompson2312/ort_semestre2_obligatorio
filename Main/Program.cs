﻿using Dominio;
using Dominio.Entidades;

namespace Main
{
    internal class Program
    {
        static Sistema _sistema = Sistema.Instancia;
        static void Main(string[] args)
        {
            int salida;
            Console.WriteLine("Bienvenido al programa, que desea?");
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(
                    "\n------------------------------------\n" +
                    "0- Salir\n" +
                    "1- Precargar Datos\n" +
                    "2- Listado de clientes \n" +
                    "3- Filtrar articulos por categoría \n" +
                    "4- Crear artículo \n" +
                    "5- Listar publicaciones entre dos fechas \n" +
                    "------------------------------------\n"
                );

                int.TryParse(Console.ReadLine(), out salida);
                switch (salida)
                {
                    case 0:
                        return;
                    case 1: 
                        PrecargarDatos(); 
                        break;
                    case 2: 
                        ListadoUsuarios(0); 
                        break;
                    case 3: 
                        ListadoArticulos(); 
                        break;
                    case 4: 
                        CrearArticulo(); 
                        break;
                    case 5: 
                        ListadoPublicaciones(); 
                        break;

                    // Menu oculto:
                    case 6:
                        ListadoArticulosSinFiltro();
                        break;
                    case 7:
                        ListadoUsuarios(1);
                        break;
                    case 8:
                        ListadoPublicacionesSinFiltro();
                        break;
                }                
            } while (salida != 0);
        }

        private static void Error(Exception e)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static void PrecargarDatos()
        {
            try {
               // _sistema.PrecargarDatos();
                Console.WriteLine("Precarga de datos completa!");
                Console.ReadKey();
            } catch (Exception e) {
                Error(e);
            }
        }

        private static void ListadoUsuarios(int tipoUsuario)
        {
            string tipo = "clientes";
            if (tipoUsuario == 1) tipo = "administradores";

            List<Usuario> _clientes = _sistema.Usuarios;
            if (_clientes.Count == 0) {
                Console.WriteLine("**** No hay Clientes ****");
                Console.ReadKey();
            } else {
                Console.WriteLine($"------------- Listado de {tipo} -------------");

                List<Usuario> _auxUsuarios;
                if (tipoUsuario == 0) _auxUsuarios = _sistema.ListadoClientes();
                else { 
                    _auxUsuarios = _sistema.ListadoAdministradores();
                }

                foreach (Usuario item in _auxUsuarios)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void ListadoArticulos()
        {
            try {
                List<Articulo> _sisArticulos = _sistema.Articulos; 
                if (_sisArticulos.Count == 0)
                {
                    Console.WriteLine("**** No hay artículos ****");
                    Console.ReadKey();
                } else 
                {
                    Console.WriteLine("Que categoria desea filtrar?");
                    string categoria = Console.ReadLine();
                    if (string.IsNullOrEmpty(categoria))
                    {
                        throw new Exception("Entrada inválida");
                    }
                    Console.WriteLine("------------- Listado de articulos filtrados -------------");
                    List<Articulo> _articulosFiltrados =_sistema.ListadoArticulos(categoria);
                    foreach (Articulo item in _articulosFiltrados)
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadKey();
                }
            } catch (Exception e) {
                Error(e);
            }
        }

        private static void ListadoArticulosSinFiltro()
        {
            List<Articulo> _sisArticulos = _sistema.Articulos;
            if (_sisArticulos.Count == 0)
            {
                Console.WriteLine("**** No hay articulos ****");
            }
            else
            {
                foreach (Articulo articulo in _sisArticulos)
                {
                    Console.WriteLine(articulo);
                }
                Console.ReadKey();
            }
        }

        private static void CrearArticulo()
        {
            try {
                Console.WriteLine("Agregue articulos: ");
                Console.WriteLine("------------------ ");

                Console.WriteLine("Nombre: ");
                string nombreArticulo = Console.ReadLine();

                Console.WriteLine("Categoria: ");
                string categoriaArticulo = Console.ReadLine();

                Console.WriteLine("Precio: ");
                int precioArticulo;
                int.TryParse(Console.ReadLine(), out precioArticulo);

                Articulo unArticulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo);
                _sistema.AgregarArticulo(unArticulo);
            } catch (Exception e) {
                Error(e);
            }
        }

        private static void ListadoPublicaciones()
        {
            try {
                List<Publicacion> _sisPublicaciones = _sistema.Publicaciones;
                if (_sisPublicaciones.Count == 0)
                {
                    Console.WriteLine("**** No hay publicaciones ****");
                    Console.ReadKey();
                }
                else 
                {
                    int inicioAnio, inicioMes, inicioDia, finAnio, finMes, finDia;

                    Console.WriteLine("Eliga fecha de inicio");
                    Console.WriteLine("---------------------");

                    Console.WriteLine("Año: ");
                    int.TryParse(Console.ReadLine(), out inicioAnio);
                    
                    Console.WriteLine("Mes: ");
                    int.TryParse(Console.ReadLine(), out inicioMes);

                    Console.WriteLine("Dia: ");
                    int.TryParse(Console.ReadLine(), out inicioDia);

                    Console.WriteLine("Eliga fecha de fin");
                    Console.WriteLine("---------------------");

                    Console.WriteLine("Año: ");
                    int.TryParse(Console.ReadLine(), out finAnio);
                    
                    Console.WriteLine("Mes: ");
                    int.TryParse(Console.ReadLine(), out finMes);

                    Console.WriteLine("Dia: ");
                    int.TryParse(Console.ReadLine(), out finDia);

                    DateTime fechaInicio = new DateTime(inicioAnio, inicioMes, inicioDia);
                    DateTime fechaFin = new DateTime(finAnio, finMes, finDia);

                    List<Publicacion> _listadoPublicaciones = _sistema.ListadoPublicaciones( fechaInicio, fechaFin );
                    foreach (Publicacion item in _listadoPublicaciones)
                    {
                        Console.WriteLine(item);
                    }
                }
            } catch (Exception e) {
                Error(e);
            }        
        }

        private static void ListadoPublicacionesSinFiltro()
        {
            List<Publicacion> _sisPublicaciones = _sistema.Publicaciones;
            if (_sisPublicaciones.Count == 0)
            {
                Console.WriteLine("**** No hay publicaciones ****");
                Console.ReadKey();
            }
            else
            {
                foreach (Publicacion item in _sisPublicaciones)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
        }

    }
}