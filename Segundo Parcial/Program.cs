


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Segundo_Parcial
{
    class Metodos {
        /// <summary>
        /// Valida una respuesta de tipo string
        /// </summary>
        /// <returns>Devuelve el string validado</returns>
        public static string ValidarString()
        {
            Console.WriteLine("Escriba respuesta:");
            string a = Console.ReadLine();
            Console.WriteLine("Ha ingresado " + a + ". ¿ Es correcto?\n si/no");
            string respuesta = Console.ReadLine();

            while (respuesta.ToLower().Trim() != "si" && respuesta.ToLower().Trim() != "no")
            {
                Console.WriteLine("Vuelva a ingresar una respuesta válida. Escibra -si-  o escriba -no-");
                respuesta = Console.ReadLine();
            }

            while (respuesta.ToLower().Trim() == "no")
            {
                Console.WriteLine("Ponga un nuevo valor");
                a = Console.ReadLine();
                Console.WriteLine("Ha ingresado " + a + ". ¿ Es correcto?\n si/no");
                respuesta = Console.ReadLine();
                while (respuesta.ToLower().Trim() != "si" && respuesta.ToLower().Trim() != "no")
                {
                    Console.WriteLine("Vuelva a ingresar una respuesta válida. Escibra -si-  o escriba -no-");
                    respuesta = Console.ReadLine();
                }

            }
            return a;


        }
        /// <summary>
        /// Este metodo solo sirve para aquellas funciones en las que necesitas solo 2 respuestas -si- o -no-
        /// </summary>
        /// <returns>la respuesta validada</returns>
        public static string ValidarSiNo()
        {
            Console.WriteLine("Escriba respuesta:");
            string a = Console.ReadLine();
            while (a.ToLower().Trim() != "si" && a.ToLower().Trim() != "no")
            {
                Console.WriteLine("Vuelva a ingresar una respuesta válida. Escibra -si-  o escriba -no-");
                a = Console.ReadLine();
            }

            Console.WriteLine("Ha ingresado que su empleado  " + a.ToUpper() + "  trabaja. ¿ Es correcto?\n si/no");
            string respuesta = Console.ReadLine();

            while (respuesta.ToLower().Trim() != "si" && respuesta.ToLower().Trim() != "no")
            {
                Console.WriteLine("Vuelva a ingresar una respuesta válida. Escibra -si-  o escriba -no-");
                respuesta = Console.ReadLine();
            }

            while (respuesta.ToLower().Trim() == "no")
            {
                Console.WriteLine("Ponga un nuevo valor");
                a = Console.ReadLine();
                Console.WriteLine("Ha ingresado " + a + ". ¿ Es correcto?\n si/no");
                respuesta = Console.ReadLine();
                while (respuesta.ToLower().Trim() != "si" && respuesta.ToLower().Trim() != "no")
                {
                    Console.WriteLine("Vuelva a ingresar una respuesta válida. Escibra -si-  o escriba -no-");
                    respuesta = Console.ReadLine();
                }
            }
            return a;

        }

        /// <summary>
        /// Valida una respuesta de tipo int
        /// </summary>
        /// <returns>Devuelve la respuesta validada</returns>
        public static int ValidarInt()
        {

            int a;
            while (!int.TryParse(Console.ReadLine(), out a) && a < 0)
            {
                if (a < 0)
                {
                    Console.WriteLine("Intente valores mayores a 0(cero).");
                }
                Console.WriteLine("Intente nuevamente.");
            }
            Console.WriteLine("Ha ingresado " + a + ". ¿ Es correcto?\n si/no");
            string respuesta = Console.ReadLine();

            while (respuesta.ToLower().Trim() != "si" && respuesta.ToLower().Trim() != "no")
            {
                Console.WriteLine("Vuelva a ingresar una respuesta válida. Escibra -si-  o escriba -no-");
                respuesta = Console.ReadLine();
            }

            while (respuesta.ToLower().Trim() == "no")
            {
                Console.WriteLine("Ponga un nuevo valor");
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Intente nuevamente");

                }
                Console.WriteLine("Ha ingresado " + a + ". ¿ Es correcto?\n si/no");
                respuesta = Console.ReadLine();
                while (respuesta.ToLower().Trim() != "si" && respuesta.ToLower().Trim() != "no")
                {
                    Console.WriteLine("Vuelva a ingresar una respuesta válida. Escibra -si-  o escriba -no-");
                    respuesta = Console.ReadLine();
                }

            }
            return a;


        }      


        /// <summary>
        /// Este es un método privado que es llamado desde otro método que originalmente sirve para eliminar un registro
        /// </summary>
        /// <param name="CalendarioLaboral"></param>
        public static void BorrarRegistro(string[,]CalendarioLaboral) {

            if (true)
            {
                Console.WriteLine("Ingrese nuevamente el nombre del empleado a eliminar");
                string b = Metodos.ValidarString();

                for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
                {
                    if (CalendarioLaboral[i, 1].ToLower().Trim() == b.ToLower().Trim())
                    {
                        for (int z = 1; z < CalendarioLaboral.GetLength(1); z++)
                        {
                            CalendarioLaboral[i, z] = "";
                        }
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Empleado eliminado");
            }
        
        }            
    }
  
    class Empleado {

        private string nombre;
        private string ID;
        public Empleado(string nombre, string id)
        {
            this.nombre = nombre;
            this.ID = id;
        }
        public string GetNombre()
        { return this.nombre; }
        public string GetID()
        { return this.ID; }      
        public void SetNombre()
        { Console.WriteLine("Ingrese un nombre");
            string n = Metodos.ValidarString();
            this.nombre = n;
        }

    }
    class Cliente
    {
        string Nombre;
        string Apellido;
        string DNI;

        public Cliente(string Nombre, string Apellido, String DNI)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
        }
        public string GetNombre()
        { return this.Nombre;}
        public string SetNombre()
        {
            Console.WriteLine("Ingrese un nombre");
            string n = Console.ReadLine();
            this.Nombre = n;
            return n;
        }
        public string SetApellido()
        {
            Console.WriteLine("Ingrese un Apellido");
            string n = Console.ReadLine();
            this.Apellido = n;
            return n;
        }
        public string SetDNI()
        {
            Console.WriteLine("Ingrese un DNI");
            string n = Console.ReadLine();
            this.DNI = n;
            return n;
        }
    }

    class Program
    {   /// <summary>
     /// Muestra por consola la matriz CalendarioLaboral
     /// </summary>
     /// <param name="CalendarioLaboral"></param>
        public static void ImprimirCalendarioLaboral(string[,] CalendarioLaboral)
        {
            for (int f = 0; f < CalendarioLaboral.GetLength(0); f++)
            {
                for (int c = 0; c < CalendarioLaboral.GetLength(1); c++)
                {
                    Console.Write($"|{CalendarioLaboral[f, c],-15}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Muestra por consola la matriz MatrizAnimales
        /// </summary>
        /// <param name="MatrizAnimales"></param>
        public static void ImprimirMatrizAnimales(string[,] MatrizAnimales)
        {
            for (int f = 0; f < MatrizAnimales.GetLength(0); f++)
            {
                for (int c = 0; c < MatrizAnimales.GetLength(1); c++)
                {
                    Console.Write($"|{MatrizAnimales[f, c],-15}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
       
        /// <summary>
        /// Muestra por consola la matriz MatrizSalario
        /// </summary>
        /// <param name="MatrizAnimales"></param>
        public static void ImprimirMatrizSalario(int[,] MatrizSalario)
        {
            for (int f = 0; f < MatrizSalario.GetLength(0); f++)
            {
                for (int c = 0; c < MatrizSalario.GetLength(1); c++)
                {
                    Console.Write($"|{MatrizSalario[f, c],-15}");
                }
                Console.WriteLine();
            }    Console.ReadKey();
        }

        /// <summary>
        ///Nos muestra por consola el nombre y el ID de empleado que pidamos con un nombre.
        ///Este método se usa para ver por consola nombre y ID para luego ingresarlo en otro método, también por consola
        /// </summary>
        /// <param name="MatrizCalendario"></param>
        public static bool BuscarEmpleado(string[,] CalendarioLaboral)        
        {
            bool c = true;
            Console.Clear();
            Console.WriteLine("A continuación verá una lista completa de los empleados");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            ImprimirCalendarioLaboral(CalendarioLaboral);
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("Ingrese el nombre del empleado a buscar. Recuerde que puede haber más de 1 nombre igual");
            string a = Metodos.ValidarString();
            for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
            {
                if (CalendarioLaboral[i, 1].ToLower().Trim() == a.ToLower().Trim())
                {
                    Console.WriteLine("Se ha encontrado el empleado nombre "
                    + CalendarioLaboral[i, 1] + " con el codigo " + CalendarioLaboral[i, 0]);
                    Console.WriteLine("----------------");
                    Console.ReadKey();
                }
                else
                {
                    c = false;
                }
            }
            if (c == false) { Console.WriteLine("Lo sentimos pero ese empleado no existe");Console.ReadKey(); }
            return c;
        }

        /// <summary>
        /// Recorre la matriz Calendario de parámetro y busca un codigo ID
        /// </summary>
        /// <param name="Calendario"></param>
        /// <returns>Devuelve la cantidad de dias trabajados</returns>
        public static void DiasTrabajados(string[,] Calendario)
        {
            int TotalDias = 0;
            if ( BuscarEmpleado(Calendario))
            {
                Console.WriteLine("Escriba el código del empleado");
                string a = Metodos.ValidarString();

                for (int i = 1; i < Calendario.GetLength(0); i++)
                {
                    if (Calendario[i, 0].ToLower().Trim() == a.ToLower().Trim())
                    {
                        for (int z = 2; z < Calendario.GetLength(1); z++)
                        {
                            if (Calendario[i, z].ToLower().Trim() == "si")
                            {
                                TotalDias++;
                            }
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("El empleado ha trabajado un total de " + TotalDias + " dias");
                DiaNombre(Calendario,a);
                Console.ReadKey();
            }
                Console.ReadKey();
        }


        /// <summary>
        /// Recibe una Matriz Calendario y nos pide un Codigo ID de empleado
        /// </summary>
        /// <param name="Calendario"></param>
        /// <returns>Nos devuelve una lista con todos los días en los que trabaja el empleado código</returns>
        private static void DiaNombre(string[,] Calendario,string IDEmpleado)
        {
            int c = 0;

            string[] dias = new string[7];

            for (int i = 1; i < Calendario.GetLength(0); i++)
            {
                if (Calendario[i, 0].ToLower().Trim() == IDEmpleado.ToLower().Trim())
                {
                    for (int z = 2; z < Calendario.GetLength(1); z++)
                    {
                        if (Calendario[i, z].ToLower().Trim() == "si")
                        {
                            dias[c] = Calendario[0, z];
                            c++;
                        }
                    }
                }
            }

            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i] != null)
                {
                    Console.WriteLine("Los días que trabaja son " + dias[i]);
                }

            }
        }


        /// <summary>
        /// Crea un array con días de la semana
        /// </summary>
        /// <returns>Devuelve un array con los días de la semana</returns>
        public static string[] CrearArraySemanal()
        {
            string[] DiaSemana =
      { "Domingo", "Lunes,", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            return DiaSemana;
        }

        /// <summary>
        /// Crea Matriz con la información de los empleados y los días que trabaja
        /// </summary>
        /// <param name="Empleados"></param>
        /// <param name="DiaSemana"></param>
        /// <returns></returns>
        public static string[,] CrearCalendario(Empleado[] Empleados, string[] DiaSemana)

        {
            string[,] Calendario =
            {
                 { "IDEmpleado","", DiaSemana[0], DiaSemana[1],DiaSemana[2], DiaSemana[3], DiaSemana[4],DiaSemana[5],DiaSemana[6]},
                 {Empleados[0].GetID(),Empleados[0].GetNombre(),    "no", "no", "no", "si", "si", "si",  "si", },
                 {Empleados[1].GetID(),Empleados[1].GetNombre(),      "",   "",   "",   "",   "",   "",    "", },
                 {Empleados[2].GetID(),Empleados[2].GetNombre(),    "si", "no", "si", "no", "no", "si",  "si", },
                 {Empleados[3].GetID(),Empleados[3].GetNombre(),      "",   "",   "",   "",   "",   "",    "", },
                 {Empleados[4].GetID(),Empleados[4].GetNombre(),    "si", "no", "no", "no", "no", "si",  "si", },
                 {Empleados[5].GetID(),Empleados[5].GetNombre(),      "",   "",   "",   "",   "",   "",    "", },
                 {Empleados[6].GetID(),Empleados[6].GetNombre(),    "si", "si", "si", "no", "no", "no",  "no", },
                 {Empleados[7].GetID(),Empleados[7].GetNombre(),      "",   "",   "",   "",   "",   "",    "", },
                 {Empleados[8].GetID(),Empleados[8].GetNombre(),    "no", "no", "si", "si", "no", "no",  "no", },
                 {Empleados[9].GetID(),Empleados[9].GetNombre(),      "",   "",   "",   "",   "",   "",    "", }
            };

            return Calendario;

        }
       
        /// <summary>
        /// Recorre la matriz CalendarioLaboral segun un nombre dado
        /// </summary>
        /// <param name="CalendarioLaboral"></param>
        /// <returns>Nos devuelve la posicion de la fila donde se encuentra el nombre del empleado</returns>     
        private static int ObtenerFilaNombre(string[,] CalendarioLaboral)
        {
            string a;
            int b = 0;
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("A continuación verá una lista completa de los empleados");
            ImprimirCalendarioLaboral(CalendarioLaboral);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ingrese el nombre del empleado a buscar");
            a = Metodos.ValidarString();
            for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
            {
                for (int z = 1; z < CalendarioLaboral.GetLength(1); z++)
                {
                    if (CalendarioLaboral[i, z].ToLower().Trim() == a.ToLower().Trim())
                    {
                        b = i;
                        break;
                    }
                }
            }
            if (b == 0)
            {
                Console.WriteLine("no se ha encontrado el empleado");
            }
            return b;
        }

        /// <summary>
        /// Crea la matriz en donde podemos ver cada animal atendido por 1 veterinario
        /// </summary>
        /// <param name="Empleados"></param>
        /// <param name="Animales"></param>
        /// <returns>Una matriz</returns>
        public static string[,] CraerMatrizAnimales(Empleado[]Empleados,string[,] CalendarioLaboral, string[]Animales)
        {
            string[,] MatrizAnimales =
             {
                {"IdEmpleado","",Animales[0],Animales[1],Animales[2],Animales[3],Animales[4],Animales[5],Animales[6],Animales[7],Animales[8],Animales[9]},
                {Empleados[0].GetID(),Empleados[0].GetNombre(),"si","si","si","si","si","no","no","no","si","si"},
                {Empleados[1].GetID(),Empleados[1].GetNombre(),"","","","","","","","","",""},
                {Empleados[2].GetID(),Empleados[2].GetNombre(),"no","si","no","si","no","si","si","no","no","no"},
                {Empleados[3].GetID(),Empleados[3].GetNombre(),"","","","","","","","","",""},
                {Empleados[4].GetID(),Empleados[4].GetNombre(),"si","si","si","no","no","si","no","si","si","si"},
                {Empleados[5].GetID(),Empleados[5].GetNombre(),"","","","","","","","","",""},
                {Empleados[6].GetID(),Empleados[6].GetNombre(),"si","no","si","no","si","no","si","no","si","no"},
                {Empleados[7].GetID(),Empleados[7].GetNombre(),"","","","","","","","","",""},
                {Empleados[8].GetID(),Empleados[8].GetNombre(),"no","no","si","si","no","no","no","si","no","si"},
                {Empleados[9].GetID(),Empleados[9].GetNombre(),"","","","","","","","","",""}

            };

            return MatrizAnimales;
        }

        /// <summary>
        /// recorre la matriz de animales y veterinarios, y suma la cant de animales que cuida cada empleado
        /// </summary>
        /// <param name="Calendario"></param>
        /// <returns>Devuelve la cant de animales que cada veterinario atiende</returns>
        public static void AtencionDeAnimales(string[,]CalendarioLaboral, string[,] MatrizAnimales)
        {
            int TotalAnimales = 0;
            if (BuscarEmpleado(CalendarioLaboral))
            {
                    Console.WriteLine("Escriba el código del empleado");
                    string a = Metodos.ValidarString();
                    for (int i = 1; i < MatrizAnimales.GetLength(0); i++)
                    {
                        if (MatrizAnimales[i, 0].ToLower().Trim() == a.ToLower().Trim())
                        {
                            for (int z = 2; z < MatrizAnimales.GetLength(1); z++)
                            {
                                if (MatrizAnimales[i, z].ToLower().Trim() == "si")
                                {
                                    TotalAnimales++;
                                }
                            }
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("El empleado trabaja con un total de " + TotalAnimales + " animales");
                    ListaAnimalesVeterinarios(MatrizAnimales,a);
                    Console.ReadKey();
            }        Console.ReadKey();                      
        }

        /// <summary>
        /// Se invoca originariamente dentro de otro método.
        /// Recorre una matriz y nos muestra por consola los animales que cuida un Empleado dado
        /// </summary>
        /// <param name="MatrizAnimales"></param>
        private static void ListaAnimalesVeterinarios(string[,] MatrizAnimales,string IDEmpleado)
        {
            int c = 0;
            string[] animales = new string[10];

            for (int i = 1; i < MatrizAnimales.GetLength(0); i++)
            {
                if (MatrizAnimales[i, 0].ToLower().Trim() == IDEmpleado.ToLower().Trim())
                {
                    for (int z = 2; z < MatrizAnimales.GetLength(1); z++)
                    {
                        if (MatrizAnimales[i, z].ToLower().Trim() == "si")
                        {
                            animales[c] = MatrizAnimales[0, z];
                            c++;
                        }
                    }
                }
            }

            Console.WriteLine("Los animales con los que trabaja son ");
            for (int i = 0; i < animales.Length; i++)
            {
                if (animales[i] != null)
                {
                    Console.WriteLine(animales[i]);
                }

            }
        }

        /// <summary>
        /// Busca si existe el nombre del empleado a buscar, en la matriz dada
        /// </summary>
        /// <param name="CalendarioLaboral"></param>
        /// <returns>Returna True si existe, sino false</returns>
        private static bool ExisteEmpleadoNombre(string[,] CalendarioLaboral)
        {
            Console.WriteLine("ingrese nombre a buscar");
            string a = Metodos.ValidarString();
            bool c = false;

            for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
            {
                if (CalendarioLaboral[i, 1].ToLower().Trim() == a.Trim().ToLower())
                {
                    Console.WriteLine("Se ha encontrado al empleado " + CalendarioLaboral[i, 1]);
                    c = true;
                    break;
                }
            }

            if (c == false)
            {
                Console.WriteLine("No se ha encontrado al empleado que busca");
            }

            return c;
        }


        /// <summary>
        /// Busca un empleado en la matriz dada por un código ID ingresado por consola
        /// </summary>
        /// <param name="CalendarioLaboral"></param>
        /// <returns>false o true si no es encuentra y el mensaje correspondiente</returns>
        private static bool ExisteEmpleadoID(string[,] CalendarioLaboral)
        {
            Console.WriteLine("ingrese código ID a buscar");
            string a = Metodos.ValidarString();
            bool c = false;
            for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
            {
                if (CalendarioLaboral[i, 0].ToLower().Trim() == a.Trim().ToLower())
                {
                    Console.WriteLine("Se ha encontrado al empleado con código ID" +
                        CalendarioLaboral[i, 0] + " su nombre es " + CalendarioLaboral[i, 1]);
                    c = true;
                    break;
                }
            }

            if (c == false)
            {
                Console.WriteLine("No se ha encontrado al empleado que busca");
            }

            return c;
        }

        /// <summary>
        /// Crea un array con los nombres y Código ID de empleados
        /// </summary>
        /// <returns>Nos devuelve dicho array</returns>
        public static Empleado[] CrearArrayEmpleado()
        {
            Empleado a = new Empleado("agustin", "olp12");
            Empleado b = new Empleado("", "sdf12");
            Empleado c = new Empleado("enzo", "asd78");
            Empleado d = new Empleado("", "wer54");
            Empleado e = new Empleado("lucia", "ert64");
            Empleado f = new Empleado("", "hfr34");
            Empleado g = new Empleado("karen", "gfh87");
            Empleado h = new Empleado("", "jkh103");
            Empleado i = new Empleado("camila", " jkj02");
            Empleado j = new Empleado("", "qle60");

            Empleado[] Empleados = { a, b, c, d, e, f, g, h, i, j };

            return Empleados;
        }
        /// <summary>
        /// Crea un array de los animales que existen en la matriz para los veterinarios
        /// </summary>
        /// <returns>Nos devuelve el array</returns>
        public static string[] CrearArrayAnimales()
        {
            string[] animales =
            {  "perros","tortugas","gatos","cabras","pajaros","erizos","vacas","serpientes","urons","peces"};
            return animales;
        }
        
        /// <summary>
        /// Este metodo recibe 2 matrices y busca el salario total de un nombre de empleado dado
        /// </summary>
        /// <param name="MatrizSalario"></param>
        /// <param name="CalendarioLaboral"></param>
        /// <returns>Nos devuelve el total a pagar. Es decir la ultima columna de una fila</returns>
        public static int SalarioTotalPagar(int[,] MatrizSalario, string[,] CalendarioLaboral)
        {
            int a = 0;
            int b = ObtenerFilaNombre(CalendarioLaboral);
            a += MatrizSalario[b, 9];
            Console.WriteLine("El salario total a pagar del empleado es de " + a);
            Console.ReadKey();
            return a;
        }

        public static void MenuEmpleado(string[] Animales, Empleado[] Empleados,string[] ArraySemanal, string[,] CalendarioLaboral, string[,] MatrizAnimales, int[,] MatrizSalario)
        {   
            bool c = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una de las siguientes opciones" +
                    "\n1-Buscar Empleado" +
                    "\n2-Días Trabajados" +
                    "\n3-Volver al menú Principal");
                int d = Metodos.ValidarInt();
                switch (d)
                {
                    case 1:Console.Clear();     BuscarEmpleado(CalendarioLaboral);      break;
                    case 2:Console.Clear();     DiasTrabajados(CalendarioLaboral);      break;
                    case 3:                     c = false;                              break;
                }
            } while (c);
        }

        public static void MenuAnimales(string[] Animales, Empleado[] Empleados, string[] ArraySemanal, string[,] CalendarioLaboral, string[,] MatrizAnimales, int[,] MatrizSalario)
        {
            bool c = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una de las siguientes opciones" +
                    "\n1-Atención de Animales" +
                    "\n2-Volver al menú Principal");
                int d = Metodos.ValidarInt();
                switch (d)
                {
                    case 1: Console.Clear();     AtencionDeAnimales(CalendarioLaboral,MatrizAnimales);          break;
                    case 2:                      c = false;                                   break;
                }
            } while (c);
        }

        public static void FacturacionTotalSemanal(int[,] MatrizSalario)      
        {
            int a = 0;
            for (int i = 1; i < MatrizSalario.GetLength(0); i++)
            {
                a+=MatrizSalario[i, 9];
            }            
            Console.WriteLine("El total a pagar en la próxima semana es de " + a);
            Console.ReadKey();
        }

        public static void MenuImpresion(string[,] MatrizAnimales, string[,] Calendariolaboral, int[,] MatrizSalario)
        {
            bool c = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una de las siguientes opciones" +
                    "\n1- Ver planilla de animales" +
                    "\n2- Ver planilla de empleado" +
                    "\n3- Ver planilla de Facturación" +                    
                    "\n4-Facturación total semanal"+
                    "\n5-Volver al menú Principal" );
                int d = Metodos.ValidarInt();
                switch (d)
                {
                    case 1: Console.Clear(); ImprimirMatrizAnimales(MatrizAnimales);        break;
                    case 2: Console.Clear(); ImprimirCalendarioLaboral(Calendariolaboral);  break;
                    case 3: Console.Clear(); ImprimirMatrizSalario(MatrizSalario);          break;
                    case 4: Console.Clear(); FacturacionTotalSemanal(MatrizSalario);        break;
                    case 5: c = false; break;
                }
            } while (c);
        }

        public static void MenuDuenioAdministrador(string[] Animales, Empleado[] Empleados, string[] ArraySemanal, string[,] CalendarioLaboral, string[,] MatrizAnimales, int[,] MatrizSalario)
        {
            bool c = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una de las siguientes opciones" +
                    "\n1-Salario total a pagar" +
                    "\n2-Agregar Empleado" +
                    "\n3-Eliminar Empleado" +
                    "\n4-Menú Planillas" +
                    "\n5-Volver al menú Principal");
                int d = Metodos.ValidarInt();
                switch (d)
                {
                    case 1: Console.Clear();  SalarioTotalPagar(MatrizSalario, CalendarioLaboral);                             break;
                    case 2: Console.Clear();  AgregarEmpleado  (Empleados, CalendarioLaboral, MatrizSalario, MatrizAnimales);  break;
                    case 3: Console.Clear();  EliminarEmpleado (CalendarioLaboral);                                            break;
                    case 4: Console.Clear(); MenuImpresion(MatrizAnimales,CalendarioLaboral,MatrizSalario);                    break;
                    case 5: c = false; break;
                }
            } while (c);
        }

        public static void MenuPrincipal  (string[] Animales, Empleado[] Empleados,string[] ArraySemanal, string[,] CalendarioLaboral, string[,] MatrizAnimales, int[,] MatrizSalario) {

            bool c = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una de las siguientes opciones" +
                    "\n1-Menú Veterinarios" +
                    "\n2-Menú Animales" +
                    "\n3-Menú Dueño/Administrador" +
                    "\n4-Salir");
                int d = Metodos.ValidarInt();
                switch (d)
                {
                    case 1:
                        Console.Clear();
                        MenuEmpleado(Animales, Empleados, ArraySemanal, CalendarioLaboral, MatrizAnimales, MatrizSalario);
                        break;                   
                   case 2:
                        Console.Clear();
                        MenuAnimales(Animales, Empleados, ArraySemanal, CalendarioLaboral, MatrizAnimales, MatrizSalario);
                        break;
                    case 3:
                        Console.Clear();
                        MenuDuenioAdministrador(Animales, Empleados, ArraySemanal, CalendarioLaboral, MatrizAnimales, MatrizSalario);
                        break;
                    case 4:
                        c = false;
                        break;
                }
            } while (c);
        }

        /// <summary>
        /// Busca espacios disponibles en un array de tipo Empleado
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returna la cant. de empleados disponibles para agregar</returns>
        private static int BuscarEmpleadosDisponibles(Empleado[] array)
        {
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].GetNombre() == "")
                {
                    a++;
                }
            }
            return a;
        }
        
        /// <summary>
        /// Agrega el nombre de un empleado en un código ID disponible
        /// </summary>
        /// <param name="array"></param>
        /// <param name="CalendarioLaboral"></param>
        public static void AgregarEmpleado(Empleado[] array, string[,] CalendarioLaboral, int[,] MatrizSalario,string[,]MatrizAnimales)
        {
            int a = BuscarEmpleadosDisponibles(array);
            if (a == 0)
            {
                Console.WriteLine("No puedes agregar a ningun empleado más");
            }

            ///así como tenemos el metodo 
            ///cargarsalario,podríamos tener 
            ///metodos para hacer las funciones de los for

            if (a > 1)
            {
                Console.WriteLine("Puedes agregar un total de " + a + " nuevo/s empleado/s");

                for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
                {
                    if (CalendarioLaboral[i, 1] == "")
                    {
                        Console.WriteLine("ingrese nombre para el nuevo empleado");
                        CalendarioLaboral[i, 1] = Metodos.ValidarString();
                        Console.WriteLine("Vamos a ingresar los días laborales");
                        for (int z = 2; z < CalendarioLaboral.GetLength(1); z++)
                        {
                            Console.Clear();
                            Console.WriteLine("¿Trabaja su empleado los días " + CalendarioLaboral[0, z] + "?");
                            CalendarioLaboral[i, z] = Metodos.ValidarSiNo();                            
                        }
                        Console.WriteLine("ingrese los animales que atiende");
                        for (int z = 2; z < MatrizAnimales.GetLength(1); z++)
                        {
                            Console.Clear();
                            Console.WriteLine("Su empleado atiende " + MatrizAnimales[0, z]+" ?");
                            MatrizAnimales[i, z] = Metodos.ValidarSiNo();
                        }
                        Console.WriteLine("Datos agregados con éxito");
                        break;
                    }
                }
            }
            CargarSalario(MatrizSalario, CalendarioLaboral);
        }

        /// <summary>
        /// Busca un empleado por código o por nombre y lo elimina
        /// </summary>
        /// <param name="CalendarioLaboral"></param>
        public static void EliminarEmpleado(string[,] CalendarioLaboral)
        {
            bool c = true;
            int a;
            string b;
            do
            {
                Console.WriteLine("1- Buscar por nombre\n2-Buscar por código ID\n3-Salir");
                a = Metodos.ValidarInt();
                switch (a)
                {
                    case 1:
                        if (ExisteEmpleadoNombre(CalendarioLaboral))
                        {
                            Metodos.BorrarRegistro(CalendarioLaboral);
                        }
                        break;
                    case 2:
                        if (ExisteEmpleadoID(CalendarioLaboral))
                        {
                            Metodos.BorrarRegistro(CalendarioLaboral);
                        }
                        break;
                    case 3:
                        c = false;
                        break;
                }
            } while (c);           
        }

        /// <summary>
        /// Crea una matriz con el salario por día de cada empleado inicial
        /// </summary>
        /// <param name="CalendarioLaboral"></param>
        /// <returns>Devuelve la matriz creada</returns>
        public static int[,] CrearMatrizSalario(string[,] CalendarioLaboral)
        {
            int[,] Matriz = new int[11, 10];
            int SalarioNormal = 790;
            int SalarioFinde = 1185;

            for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
            {
                for (int z = 2; z < CalendarioLaboral.GetLength(1); z++)
                {
                    if (CalendarioLaboral[i, z].ToLower().Trim() == "si")
                    {
                        if (z == 2 || z == 8)
                        {
                            Matriz[i, z] = SalarioFinde;
                        }
                        else
                        {
                            Matriz[i, z] = SalarioNormal;
                        }
                    }
                    if (CalendarioLaboral[i, z].ToLower().Trim() == "no")
                    {
                        Matriz[i, z] = 0;
                    }
                }

            }

            for (int i = 1; i < Matriz.GetLength(0); i++)
            { int a = 0;

                for (int z = 2; z < Matriz.GetLength(1); z++)
                {
                    a += Matriz[i, z];
                    if (z == 9)
                    {
                        Matriz[i, z] = a;
                    }
                }
            }
            return Matriz;
        }

        /// <summary>
        /// Carga en la matriz salario, el salario correspondiente según si trabaja o no en CalendarioLaboral
        /// </summary>
        /// <param name="MatrizSalario"></param>
        /// <param name="CalendarioLaboral"></param>
        private static void CargarSalario(int[,] MatrizSalario, string[,] CalendarioLaboral)
        {
            int SalarioNormal = 790;
            int SalarioFinde = 1185;

            for (int i = 1; i < CalendarioLaboral.GetLength(0); i++)
            {
                for (int z = 2; z < CalendarioLaboral.GetLength(1); z++)
                {
                    if (CalendarioLaboral[i, z].ToLower().Trim() == "si")
                    {
                        if (z == 2 || z == 8)
                        {
                            MatrizSalario[i, z] = SalarioFinde;
                        }
                        else
                        {
                            MatrizSalario[i, z] = SalarioNormal;
                        }
                    }
                    if (CalendarioLaboral[i, z].ToLower().Trim() == "no")
                    {
                        MatrizSalario[i, z] = 0;
                    }
                }

            }

            for (int i = 1; i < MatrizSalario.GetLength(0); i++)
            {
                int a = 0;

                for (int z = 2; z < MatrizSalario.GetLength(1); z++)
                {
                    a += MatrizSalario[i, z];
                    if (z == 9)
                    {
                        MatrizSalario[i, z] = a;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            string[] Animales = CrearArrayAnimales();
            Empleado[] Empleados = CrearArrayEmpleado();
            string[] ArraySemanal = CrearArraySemanal();
            string[,] CalendarioLaboral = CrearCalendario(Empleados, ArraySemanal);
            string[,] MatrizAnimales = CraerMatrizAnimales(Empleados,CalendarioLaboral,Animales);
            int[,] MatrizSalario = CrearMatrizSalario(CalendarioLaboral);          
            
          
            MenuPrincipal(Animales,Empleados,ArraySemanal,CalendarioLaboral,MatrizAnimales, MatrizSalario);
          
            Console.ReadKey();
        }
    } 

}



