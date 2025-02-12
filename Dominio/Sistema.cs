﻿using Dominio.Entidades;

namespace Dominio
{
    public class Sistema : IValidar
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();
        private List<Articulo> _articulos = new List<Articulo>();

        public IEnumerable<Usuario> Usuarios
        {
            get { return _usuarios; }
        }
        public IEnumerable<Publicacion> Publicaciones
        {
            get { return _publicaciones; }
        }
        public IEnumerable<Articulo> Articulos
        {
            get { return _articulos; }
        }

        private static Sistema _instancia;
        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new Sistema();
                return _instancia;
            }
        }

        private void PrecargarDatos()
        {
            PrecargarAdministradores();
            PrecargarClientes();
            PrecargarPublicaciones();
        }

        public void Validar()
        {
        }

        public Sistema()
        {
            PrecargarDatos();
        }

        /*-------------- Precarga de datos --------------*/
        private void PrecargarAdministradores()
        {
            string rol = "Administrador";

            Usuario admin;

            admin = new Administrador("Admin", "Admin", "admin", "Admin#123", rol);
            AgregarUsuario(admin);

            admin = new Administrador("Carlos", "Gomez", "carlos.gomez@gmail.com", "passCarlos9@", rol);
            AgregarUsuario(admin);

            admin = new Administrador("Lucia", "Fernandez", "lucia.fernandez@gmail.com", "#luciaFernandez123", rol);
            AgregarUsuario(admin);

            //admin = new Administrador("Pedro", "Diaz", "pedro.diaz@gmail", null, rol); // Contrasenia vacia/null
            //AgregarUsuario(admin);

            //admin = new Administrador("Ana", "Martinez", null, "ana12", rol); // Email vacia/null
            //AgregarUsuario(admin);

            //admin = new Administrador(null, "Sanchez", "sanchez.admin@outlook.com", "sanchezAdmin789", rol); // Nombre vacia/null
            //AgregarUsuario(admin);

            //admin = new Administrador("Laura", null, "laura.admin@gmail.com", "lauraAdmin101", rol); // Apellido vacio/null
            //AgregarUsuario(admin);

            /* 
                (inicio) Datos nuevos! 
            */

            // admin = new Administrador("Javier", "Martinez", "javier.martinez@gmail.com", "JAVIERadmin@", rol); // No tiene numeros
            // AgregarUsuario(admin);

            // admin = new Administrador("Elena", "Ruiz", "elena.ruiz@gmail.com", "ELENARUIZ123@", rol); // No contiene letras minusculas
            // AgregarUsuario(admin);

            // admin = new Administrador("Ricardo", "Pérez", "ricardo.perez@gmail.com", "R123@", rol); // No cumple con minimo de caracteres
            // AgregarUsuario(admin);

            // admin = new Administrador("Marta", "Lopez", "marta.lopez@gmail.com", "MARTAlopez123", rol); // No contiene simbolos
            // AgregarUsuario(admin);

            // admin = new Administrador("Tomás", "Hernandez", "tomas.hernandez@gmail.com", "123456789@", rol); // No contiene letras
            // AgregarUsuario(admin);

            /* 
                (fin) Datos nuevos! 
            */
        }

        private void PrecargarClientes()
        {
            string rol = "Cliente";

            Usuario user;

            user = new Cliente("Carlos", "Garcia", "carlos.garcia@gmail.com", "passCarlos1@", 1000, rol);
            AgregarUsuario(user);

            user = new Cliente("María", "Lopez", "maria.lopez@gmail.com", "mariaLopez22$", 2000, rol);
            AgregarUsuario(user);

            user = new Cliente("Juan", "Martinez", "juan.martinez@hotmail.com", "juanMartinez33#", 1500, rol);
            AgregarUsuario(user);

            user = new Cliente("Ana", "Sanchez", "ana.sanchez@outlook.com", "anaSanchez44%", 1800, rol);
            AgregarUsuario(user);

            user = new Cliente("Miguel", "Perez", "miguel.perez@gmail.com", "miguelPerez55!", 1200, rol);
            AgregarUsuario(user);

            user = new Cliente("Laura", "Fernandez", "laura.fernandez@gmail.com", "lauraFernandez66@", 1700, rol);
            AgregarUsuario(user);

            user = new Cliente("Pedro", "Diaz", "pedro.diaz@gmail.com", "pedroDiaz77$", 1300, rol);
            AgregarUsuario(user);

            user = new Cliente("Sofia", "Gomez", "lucia.gomez@gmail.com", "luciaGomez88#", 2200, rol);
            AgregarUsuario(user);

            user = new Cliente("Sofia", "Rodriguez", "sofia.rodriguez@gmail.com", "sofiaRodriguez99%", 1400, rol);
            AgregarUsuario(user);

            user = new Cliente("Diego", "Molina", "diego.molina@gmail.com", "diegoMolina1010!", 1600, rol);
            AgregarUsuario(user);

            // user = new Cliente(null, "Vega", "vega@hotmail.com", "vegaPassword123", 1000); // Nombre null
            // AgregarUsuario(cliente11);

            // user = new Cliente("Ramiro", "Santos", "ramiro.santos@gmail.com", "ramiroSantos123", -500); // Saldo negativo
            // AgregarUsuario(cliente12);

            // user = new Cliente("Gabriel", null, "gabriel@outlook.com", "gabrielOut123", 1700); // Apellido null
            // AgregarUsuario(cliente13);

            /* 
                Datos Nuevos!
            */

            // user = new Cliente("Laura", "Martinez", "laura.martinez@gmail.com", "LAURAmartinez@", 1500, rol); // No contiene numeros
            // AgregarUsuario(user);

            // user = new Cliente("Carlos", "Diaz", "carlos.diaz@gmail.com", "CARLOSDIAZ123@", 1800, rol); // No contiene minusculas
            // AgregarUsuario(user);

            // user = new Cliente("Sofia", "Rodriguez", "bruno.rodriguez@gmail.com", "Sof123@", 1700, rol); // No contiene minimo de caracteres
            // AgregarUsuario(user);

            // user = new Cliente("Miguel", "Perez", "hernan.perez@gmail.com", "hernanPerez123", 1600, rol); // No contiene simbolos
            // AgregarUsuario(user);

            // user = new Cliente("Pedro", "Lopez", "pedro.lopez@gmail.com", "123456789@", 1400, rol); // No contiene letras
            // AgregarUsuario(user);

            /* 
                Datos Nuevos!
            */
        }

        private void PrecargarPublicaciones()
        {
            Articulo articulo1 = new Articulo("Sombrero", "Playa", 1000);
            AgregarArticulo(articulo1);

            Articulo articulo2 = new Articulo("Gafas de sol", "Accesorios", 500);
            AgregarArticulo(articulo2);

            Articulo articulo3 = new Articulo("Camiseta", "Ropa", 1200);
            AgregarArticulo(articulo3);

            Articulo articulo4 = new Articulo("Pantalón", "Ropa", 2000);
            AgregarArticulo(articulo4);

            Articulo articulo5 = new Articulo("Bolso", "Accesorios", 1500);
            AgregarArticulo(articulo5);

            Articulo articulo6 = new Articulo("Zapatos", "Calzado", 2500);
            AgregarArticulo(articulo6);

            Articulo articulo7 = new Articulo("Reloj", "Accesorios", 4000);
            AgregarArticulo(articulo7);

            Articulo articulo8 = new Articulo("Gorra", "Accesorios", 800);
            AgregarArticulo(articulo8);

            Articulo articulo9 = new Articulo("Abrigo", "Ropa", 3500);
            AgregarArticulo(articulo9);

            Articulo articulo10 = new Articulo("Bufanda", "Accesorios", 600);
            AgregarArticulo(articulo10);

            Articulo articulo11 = new Articulo("Cinturón", "Accesorios", 700);
            AgregarArticulo(articulo11);

            Articulo articulo12 = new Articulo("Chaqueta", "Ropa", 3000);
            AgregarArticulo(articulo12);

            Articulo articulo13 = new Articulo("Vestido", "Ropa", 2800);
            AgregarArticulo(articulo13);

            Articulo articulo14 = new Articulo("Traje de baño", "Playa", 1100);
            AgregarArticulo(articulo14);

            Articulo articulo15 = new Articulo("Chanclas", "Playa", 900);
            AgregarArticulo(articulo15);

            Articulo articulo16 = new Articulo("Sombrilla", "Playa", 2000);
            AgregarArticulo(articulo16);

            Articulo articulo17 = new Articulo("Mochila", "Accesorios", 1700);
            AgregarArticulo(articulo17);

            Articulo articulo18 = new Articulo("Bañador", "Playa", 1300);
            AgregarArticulo(articulo18);

            Articulo articulo19 = new Articulo("Pulsera", "Accesorios", 400);
            AgregarArticulo(articulo19);

            Articulo articulo20 = new Articulo("Anillo", "Accesorios", 1200);
            AgregarArticulo(articulo20);

            Articulo articulo21 = new Articulo("Lentes de natación", "Playa", 500);
            AgregarArticulo(articulo21);

            Articulo articulo22 = new Articulo("Chaleco", "Ropa", 2500);
            AgregarArticulo(articulo22);

            Articulo articulo23 = new Articulo("Guantes", "Accesorios", 600);
            AgregarArticulo(articulo23);

            Articulo articulo24 = new Articulo("Cartera", "Accesorios", 1600);
            AgregarArticulo(articulo24);

            Articulo articulo25 = new Articulo("Falda", "Ropa", 1400);
            AgregarArticulo(articulo25);

            Articulo articulo26 = new Articulo("Pareo", "Playa", 850);
            AgregarArticulo(articulo26);

            Articulo articulo27 = new Articulo("Sandalias", "Calzado", 1800);
            AgregarArticulo(articulo27);

            Articulo articulo28 = new Articulo("Botas", "Calzado", 3200);
            AgregarArticulo(articulo28);

            Articulo articulo29 = new Articulo("Chalina", "Accesorios", 450);
            AgregarArticulo(articulo29);

            Articulo articulo30 = new Articulo("Corbata", "Accesorios", 750);
            AgregarArticulo(articulo30);

            Articulo articulo31 = new Articulo("Camisa", "Ropa", 1900);
            AgregarArticulo(articulo31);

            Articulo articulo32 = new Articulo("Short", "Ropa", 1350);
            AgregarArticulo(articulo32);

            Articulo articulo33 = new Articulo("Capa", "Ropa", 2600);
            AgregarArticulo(articulo33);

            Articulo articulo34 = new Articulo("Pantaloneta", "Playa", 1150);
            AgregarArticulo(articulo34);

            Articulo articulo35 = new Articulo("Sombrero de paja", "Playa", 1250);
            AgregarArticulo(articulo35);

            Articulo articulo36 = new Articulo("Tirantes", "Accesorios", 700);
            AgregarArticulo(articulo36);

            Articulo articulo37 = new Articulo("Medias", "Accesorios", 400);
            AgregarArticulo(articulo37);

            Articulo articulo38 = new Articulo("Pantuflas", "Calzado", 2200);
            AgregarArticulo(articulo38);

            Articulo articulo39 = new Articulo("Calzoncillos", "Ropa", 950);
            AgregarArticulo(articulo39);

            Articulo articulo40 = new Articulo("Gorro", "Accesorios", 650);
            AgregarArticulo(articulo40);

            Articulo articulo41 = new Articulo("Bikini", "Playa", 1600);
            AgregarArticulo(articulo41);

            Articulo articulo42 = new Articulo("Top", "Ropa", 1100);
            AgregarArticulo(articulo42);

            Articulo articulo43 = new Articulo("Traje formal", "Ropa", 5000);
            AgregarArticulo(articulo43);

            Articulo articulo44 = new Articulo("Botines", "Calzado", 2700);
            AgregarArticulo(articulo44);

            Articulo articulo45 = new Articulo("Camiseta sin mangas", "Ropa", 1000);
            AgregarArticulo(articulo45);

            Articulo articulo46 = new Articulo("Zapatillas deportivas", "Calzado", 3500);
            AgregarArticulo(articulo46);

            Articulo articulo47 = new Articulo("Riñonera", "Accesorios", 900);
            AgregarArticulo(articulo47);

            Articulo articulo48 = new Articulo("Bandolera", "Accesorios", 1300);
            AgregarArticulo(articulo48);

            Articulo articulo49 = new Articulo("Jersey", "Ropa", 2800);
            AgregarArticulo(articulo49);

            Articulo articulo50 = new Articulo("Gorro de lana", "Accesorios", 550);
            AgregarArticulo(articulo50);

            // Articulo articulo51 = new Articulo(null, "Ropa", 1000); //Nombre null
            // AgregarArticulo(articulo51);

            // Articulo articulo52 = new Articulo("Camisa", null, 1800); // Categoria null
            // AgregarArticulo(articulo52);

            // Articulo articulo53 = new Articulo("Zapatos de vestir", "Calzado", -1500); // Precio negativo
            // AgregarArticulo(articulo53);

            // Articulo articulo54 = new Articulo("Cinturón de cuero", "Accesorios", 0); // Precio no puede ser 0
            // AgregarArticulo(articulo54);

            // Articulo articulo55 = new Articulo("", "Playa", 700); //Nombre vacio
            // AgregarArticulo(articulo55);

            /* ---------------- Precarga de ventas ---------------- */
            Publicacion venta1 = new Venta("Descuento Playero!", new DateTime(2024, 5, 12), false);
            AgregarPublicacion(venta1);
            venta1.AgregarArticulo(articulo1);
            venta1.AgregarArticulo(articulo2);
            venta1.AgregarArticulo(articulo3);

            Publicacion venta2 = new Venta("Oferta de Verano", new DateTime(2024, 6, 20), true);
            AgregarPublicacion(venta2);
            venta2.AgregarArticulo(articulo1);
            venta2.AgregarArticulo(articulo2);
            venta2.AgregarArticulo(articulo3);

            Publicacion venta3 = new Venta("Liquidación de Invierno", new DateTime(2024, 12, 1), false);
            AgregarPublicacion(venta3);
            venta3.AgregarArticulo(articulo1);
            venta3.AgregarArticulo(articulo2);
            venta3.AgregarArticulo(articulo3);

            Publicacion venta4 = new Venta("Descuento Primavera", new DateTime(2024, 4, 15), true);
            AgregarPublicacion(venta4);
            venta4.AgregarArticulo(articulo1);
            venta4.AgregarArticulo(articulo2);
            venta4.AgregarArticulo(articulo3);

            Publicacion venta5 = new Venta("Promoción Otoñal", new DateTime(2024, 10, 10), false);
            AgregarPublicacion(venta5);
            venta5.AgregarArticulo(articulo4);
            venta5.AgregarArticulo(articulo5);
            venta5.AgregarArticulo(articulo6);

            Publicacion venta6 = new Venta("Oferta Relámpago Accesorios", new DateTime(2024, 3, 5), true);
            AgregarPublicacion(venta6);
            venta6.AgregarArticulo(articulo7);
            venta6.AgregarArticulo(articulo8);
            venta6.AgregarArticulo(articulo9);

            Publicacion venta7 = new Venta("Descuento en Electrónica", new DateTime(2024, 7, 25), false);
            AgregarPublicacion(venta7);
            venta7.AgregarArticulo(articulo10);
            venta7.AgregarArticulo(articulo11);
            venta7.AgregarArticulo(articulo12);

            Publicacion venta8 = new Venta("Black Friday 2024", new DateTime(2024, 11, 29), true);
            AgregarPublicacion(venta8);
            venta8.AgregarArticulo(articulo13);
            venta8.AgregarArticulo(articulo14);
            venta8.AgregarArticulo(articulo15);

            Publicacion venta9 = new Venta("Oferta en Moda", new DateTime(2024, 8, 18), false);
            AgregarPublicacion(venta9);
            venta9.AgregarArticulo(articulo16);
            venta9.AgregarArticulo(articulo17);
            venta9.AgregarArticulo(articulo18);

            Publicacion venta10 = new Venta("Promoción Especial Festiva", new DateTime(2024, 12, 20), true);
            AgregarPublicacion(venta10);
            venta10.AgregarArticulo(articulo19);
            venta10.AgregarArticulo(articulo20);
            venta10.AgregarArticulo(articulo21);

            // Publicacion venta11 = new Venta("Promocion Especial Verano", new DateTime(2024, 11, 20), false, 0); // Precio final no puede ser 0
            // AgregarPublicacion(venta11);

            // Publicacion venta12 = new Venta("", new DateTime(2024, 4, 10), true, 5000); // Nombre vacio
            // AgregarPublicacion(venta12);

            // Publicacion venta13 = new Venta(null, new DateTime(2024, 4, 10), true, 5000); // Nombre null
            // AgregarPublicacion(venta13);

            // Publicacion venta14 = new Venta("Ultrapromocion", new DateTime(2024, 6, 11), true, -3000); // Precio negativo
            // AgregarPublicacion(venta14);

            /* ---------------- Precarga de ofertas ---------------- */

            Usuario cliente;

            cliente = new Cliente("Bruno", "Gomez", "brunogomez2312@gmail.com", "123", 1000, "cliente");
            Oferta oferta1 = new Oferta(cliente, 1000, new DateTime(2024, 10, 3));
            Oferta oferta2 = new Oferta(cliente, 1000, new DateTime(2024, 12, 3)); // Error, no puede haber otra oferta con el mismo monto que el mismo cliente ha publicado previamente.
            Oferta oferta3 = new Oferta(cliente, 2000, new DateTime(2024, 11, 25));

            cliente = new Cliente("Hernan", "Hernandez", "hernanhernandez@gmail.com", "123", 2000, "cliente");
            Oferta oferta6 = new Oferta(cliente, 1800, new DateTime(2024, 10, 3));
            Oferta oferta7 = new Oferta(cliente, 2200, new DateTime(2024, 7, 11));
            Oferta oferta8 = new Oferta(cliente, 3000, new DateTime(2024, 9, 7));

            cliente = new Cliente("Juan", "Benitez", "juan@gmail.com", "123", 2000, "cliente");
            Oferta oferta9 = new Oferta(cliente, 2750, new DateTime(2024, 11, 29));
            Oferta oferta10 = new Oferta(cliente, 3200, new DateTime(2024, 8, 19));
            
            cliente = new Cliente("Jorge", "Casuriaga", "jorg@gmail.com", "123", 2000, "cliente");
            Oferta oferta12 = new Oferta(cliente, 2900, new DateTime(2024, 12, 1));
            Oferta oferta13 = new Oferta(cliente, 2400, new DateTime(2024, 3, 25));

            // Oferta oferta4 = new Oferta(cliente1, 0, new DateTime(2024, 10, 3)); // Monto menor o igual a 0
            // Oferta oferta5 = new Oferta(null, 2000, new DateTime(2024, 10, 3)); // Usuario null

            /* ---------------- Precarga de subastas ---------------- */
            Publicacion subasta1 = new Subasta("Subasta de accesorios", new DateTime(2024, 10, 3));
            AgregarPublicacion(subasta1);
            subasta1.AgregarArticulo(articulo22);
            subasta1.AgregarArticulo(articulo23);
            subasta1.AgregarArticulo(articulo24);
            subasta1.AgregarOferta(oferta1);
            // subasta1.AgregarOferta(oferta2); // Oferta debe tener diferente monto si es que el usuario ya ha publicado previamente
            // subasta1.AgregarOferta(oferta3); // Oferta con fecha de publicacion invalida

            Publicacion subasta2 = new Subasta("Subasta de relojes", new DateTime(2024, 11, 5));
            AgregarPublicacion(subasta2);
            subasta2.AgregarArticulo(articulo25);
            subasta2.AgregarArticulo(articulo26);
            subasta2.AgregarArticulo(articulo27);
            // subasta2.AgregarOferta(oferta1); // Error, fecha es menor a la de publicacion
            subasta2.AgregarOferta(oferta2);
            subasta2.AgregarOferta(oferta3);
            // subasta2.AgregarOferta(oferta13); // Mismo error de fecha

            Publicacion subasta3 = new Subasta("Subasta de ropa de verano", new DateTime(2024, 6, 15));
            AgregarPublicacion(subasta3);
            subasta3.AgregarArticulo(articulo28);
            subasta3.AgregarArticulo(articulo29);
            subasta3.AgregarArticulo(articulo30);
            subasta3.AgregarOferta(oferta6);
            // subasta3.AgregarOferta(oferta6); // Misma oferta
            subasta3.AgregarOferta(oferta7);
            subasta3.AgregarOferta(oferta8);
            // subasta3.AgregarOferta(oferta12); // Monto ofrecido no supera al precio final actual (que es el monto con mas valor)

            Publicacion subasta4 = new Subasta("Subasta de tecnología", new DateTime(2024, 7, 20));
            AgregarPublicacion(subasta4);
            subasta4.AgregarArticulo(articulo31);
            subasta4.AgregarArticulo(articulo32);
            subasta4.AgregarArticulo(articulo33);
            subasta4.AgregarOferta(oferta9);
            subasta4.AgregarOferta(oferta10);

            Publicacion subasta5 = new Subasta("Subasta de calzado deportivo", new DateTime(2024, 9, 12));
            AgregarPublicacion(subasta5);
            subasta5.AgregarArticulo(articulo34);
            subasta5.AgregarArticulo(articulo35);
            subasta5.AgregarArticulo(articulo36);

            //Publicacion subasta6 = new Subasta("Subasta de productos de invierno", new DateTime(2024, 12, 1));
            //AgregarPublicacion(subasta6);
            //subasta6.AgregarArticulo(articulo37);
            //subasta6.AgregarArticulo(articulo38);
            //subasta6.AgregarArticulo(articulo39);

            Publicacion subasta7 = new Subasta("Subasta de bolsos y carteras", new DateTime(2024, 5, 10));
            AgregarPublicacion(subasta7);
            subasta7.AgregarArticulo(articulo40);
            subasta7.AgregarArticulo(articulo41);
            subasta7.AgregarArticulo(articulo42);

            Publicacion subasta8 = new Subasta("Subasta de artículos de cocina", new DateTime(2024, 8, 22));
            AgregarPublicacion(subasta8);
            subasta8.AgregarArticulo(articulo43);
            subasta8.AgregarArticulo(articulo44);
            subasta8.AgregarArticulo(articulo45);

            Publicacion subasta9 = new Subasta("Subasta de libros y revistas", new DateTime(2024, 3, 17));
            AgregarPublicacion(subasta9);
            subasta9.AgregarArticulo(articulo46);
            subasta9.AgregarArticulo(articulo47);
            subasta9.AgregarArticulo(articulo48);

            Publicacion subasta10 = new Subasta("Subasta de muebles", new DateTime(2024, 4, 25));
            AgregarPublicacion(subasta10);
            subasta10.AgregarArticulo(articulo49);
            subasta10.AgregarArticulo(articulo50);

            // Publicacion subasta11 = new Subasta(null, new DateTime(2024, 1, 4)); // Nombre no puede ser null
            // subasta11.Validar();

            // Publicacion subasta12 = new Subasta("", new DateTime(2024, 7, 2)); // Nombre no puede ser vacio
            // subasta12.Validar();
        }
        /*-------------- Precarga de datos --------------*/

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("Usuario null");
            }
            if (_usuarios.Contains(usuario))
            {
                throw new Exception($"Usuario ya existente: {usuario}");
            }
            usuario.Validar();
            _usuarios.Add(usuario);
        }

        public void AgregarArticulo(Articulo pArticulo)
        {
            if (pArticulo == null)
            {
                throw new Exception("Articulo null");
            }
            if (_articulos.Contains(pArticulo))
            {
                throw new Exception($"Articulo ya existente: {pArticulo}");
            }
            pArticulo.Validar();
            _articulos.Add(pArticulo);
        }

        public void AgregarPublicacion(Publicacion pPublicacion)
        {
            if (pPublicacion == null)
            {
                throw new Exception("Publicacion null");
            }
            pPublicacion.Validar();
            _publicaciones.Add(pPublicacion);
        }

        public IEnumerable<Usuario> ListadoAdministradores()
        {
            List<Usuario> _auxAdministrador = new List<Usuario>();
            foreach (Usuario item in _usuarios)
            {
                if (item is Administrador)
                {
                    Administrador admininistrador = (Administrador)item;
                    _auxAdministrador.Add(admininistrador);
                }
            }
            return _auxAdministrador;
        }

        public IEnumerable<Usuario> ListadoClientes()
        {
            List<Usuario> _auxCliente = new List<Usuario>();
            foreach (Usuario item in _usuarios)
            {
                if (item is Cliente)
                {
                    Cliente cliente = (Cliente)item;
                    _auxCliente.Add(cliente);
                }
            }
            return _auxCliente;
        }

        public IEnumerable<Usuario> ListadoUsuariosXNombre(string nombre)
        {
            List<Usuario> _auxUsuarios = new List<Usuario>();
            foreach (Usuario item in _usuarios)
            {
                if (nombre == null || item.Nombre.ToLower().Contains(nombre.ToLower()))
                {
                    _auxUsuarios.Add(item);
                }
            }
            return _auxUsuarios;
        }

        public IEnumerable<Usuario> ListadoUsuariosXEmail(string email)
        {
            List<Usuario> _auxUsuarios = new List<Usuario>();
            foreach (Usuario item in _usuarios)
            {
                if (email == null || item.Email.ToLower().Contains(email.ToLower()))
                {
                    _auxUsuarios.Add(item);
                }
            }
            return _auxUsuarios;
        }
    
        public Usuario ObtenerUsuarios(string email, string contrasenia)
        {
            foreach (Usuario item in _usuarios)
            {
                if (item.Email == email && item.Contrasenia == contrasenia)
                {
                    return item;
                }
            }
            return null;
        }

        public Usuario FiltrarUsuarioXId(int id)
        {
            foreach (Usuario item in _usuarios)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void ModificarUsuario(int id, string Nombre, string Apellido, string Email, string Contrasenia, string Password2)
        {
            Usuario usuario = FiltrarUsuarioXId(id); ;
            if (usuario == null)
            {
                throw new Exception("Null");
            }
            if (Contrasenia != Password2)
            {
                throw new Exception("Contraseñas no coinciden");
            }
            if (!usuario.ValidarContrasenia(Contrasenia))
            {
                throw new Exception("Contraseña invalido");
            }

            usuario.Nombre = Nombre;
            usuario.Apellido = Apellido;
            usuario.Email = Email;
            usuario.Contrasenia = Contrasenia;
        }

        public Publicacion FiltrarPublicacionXId(int id)
        {
            foreach (Publicacion item in _publicaciones)
            {
                if (id == null || id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public IEnumerable<Publicacion> ListadoPublicaciones(DateTime pFechaInicio, DateTime pFechaFin)
        {
            List <Publicacion> _auxPublicaciones = new List<Publicacion>();
            foreach (Publicacion item in _publicaciones)
            {
                if (item.FechaPublicacion >= pFechaInicio && item.FechaFinalizacionCompra <= pFechaFin)
                {
                    _auxPublicaciones.Add(item);
                }
            }
            return _auxPublicaciones;
        }

        public IEnumerable<Publicacion> ListadoPublicacionesXNombre(string nombre)
        {
            List<Publicacion> _auxPublicaciones = new List<Publicacion>();
            foreach (Publicacion item in _publicaciones)
            {
                if (nombre == null || item.Nombre == nombre)
                {
                    _auxPublicaciones.Add(item);
                }
            }
            return _auxPublicaciones;
        }

        public IEnumerable<Publicacion> ListadoVentas()
        {
            List<Publicacion> _auxVentas = new List<Publicacion>();
            foreach (Publicacion item in _publicaciones)
            {
                if (item is Venta)
                {
                    Venta venta = (Venta)item;  
                    _auxVentas.Add(venta);
                }
            }
            return _auxVentas;
        }

        public IEnumerable<Publicacion> ListadoSubastas()
        {
            List<Publicacion> _auxSubastas = new List<Publicacion>();
            foreach (Publicacion item in _publicaciones)
            {
                if (item is Subasta)
                {
                    Subasta subasta = (Subasta)item;
                    _auxSubastas.Add(subasta);
                }
            }
            return _auxSubastas;
        }

        public IEnumerable<Articulo> ListadoArticulos(string pCategoria)
        {
            List<Articulo> _auxArticulos = new List<Articulo>();
            foreach (Articulo item in _articulos)
            {
                if (item.Categoria == pCategoria)
                {
                    _auxArticulos.Add(item);
                }
            }
            return _auxArticulos;
        }

        public void RecargarSaldoCliente(int id, int recarga)
        {
            Usuario usuario = FiltrarUsuarioXId(id);
            if (usuario == null)
            {
                throw new Exception("Null");
            }
            usuario.RecargarSaldo(recarga);
        }

        public void FinalizarVenta(int idUser, int idPub, decimal saldo)
        {
            Usuario usuario = FiltrarUsuarioXId(idUser);
            Publicacion publicacion = FiltrarPublicacionXId(idPub);
            if (usuario == null)
            {
                throw new Exception("Null");
            }
            if (usuario is Administrador)
            {
                throw new Exception("Acceso Denegado");
            }
            if (publicacion == null)
            {
                throw new Exception("Null");
            }
            if (publicacion.EstadoPublicacion == Publicacion.Estado.Cerrado ||
                publicacion.EstadoPublicacion == Publicacion.Estado.Cancelado)
            {
                throw new Exception("Compra previamente finalizada");
            }
            if (saldo < publicacion.ObtenerPrecioFinal())
            {
                throw new Exception("Saldo insuficiente");
            }
            publicacion.FinalizarPublicacion(usuario, usuario);
            usuario.DescontarSaldo(publicacion.ObtenerPrecioFinal());
        }

        public void OfertarSubasta(Publicacion subasta, int idSession, int monto)
        {
            if (subasta == null)
            {
                throw new Exception("Null");
            }

            Usuario usuario = FiltrarUsuarioXId(idSession);
            if (usuario == null)
            {
                throw new Exception("Null");
            }
            decimal saldo = usuario.ObtenerSaldo();

            if (saldo < monto)
            {
                throw new Exception("No dispone del saldo suficiente");
            }

            DateTime today = DateTime.Today;
            Oferta oferta = new Oferta(usuario, monto, today);
            subasta.AgregarOferta(oferta);
        }

        public void FinalizarSubasta(int idSession, int idPub)
        {
            Publicacion publicacion = FiltrarPublicacionXId(idPub);
            if (publicacion == null)
            {
                throw new Exception("Null");
            }
            if (publicacion.EstadoPublicacion == Publicacion.Estado.Cerrado)
            {
                throw new Exception("Subasta ya cerrada");
            }

            Usuario admin= FiltrarUsuarioXId(idSession);
            if (admin == null)
            {
                throw new Exception("Null");
            }
            if (publicacion.CantidadOfertas() == 0)
            {
                publicacion.CancelarSubasta(admin);
            }
            else
            {
                Usuario cliente = publicacion.OfertaConMasValor().Usuario;
                publicacion.FinalizarPublicacion(cliente, admin);
            }
        }
    }
}