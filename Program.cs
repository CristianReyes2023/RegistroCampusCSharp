using RegistroEstudiantesC_.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        //Un profesor del area de matematicas, necesita generar un programa que le permita registrar los estudiantes que se encuentran matriculados, la información que el docente posee de cada estudiante es la siguiente:
        //Codigo del estudiante: con una logitud maxima de 15 caracteres
        //Nombre: logitud max de 40 caracteres
        //Email: logitud max de 40 caracteres
        //Edad: 2 caracteres 
        //Dirección: longitud max de 35
        //No se conocen la cantidad de estudiantes que se registraron en la asignatura.
        //La universidad tiene como norma que cada estudiante de presentar 4 quieces, 2 trabajos y 3 parciales.Las notas de los quieces equivalen al 25%, los trabajos al 15% y los parciales 60%.
        //El programa debe permitirle al profesor generar los siguientes reportes: 
        //1) Listado General de notas del grupo, paginado por 10 estudiante 
        //Codigo                 Nombre               Quices           Trabajos       Parciales
        //-------------|----------------------|-Q1-|-Q2-|-Q3-|-Q4-|--|-T1-|-T2-|--|-P1-|-P2-|-P3-|
        //
        //
        //

        //2) Notas Finales 
        //---CODIGO---|---Nombre---|---Def Quices---|---Def Trabajos---|---Def Parciales---|--- Nota Final---|

        //El programa debe permitirle al docente realizar todo el proceso de registro de notas de Quices, trabajos y Parciales (Debo buscar el estudiante y asignar el Quiz (1,2 o 3 ) debo darle la opción de escoger el Id, trabajos y parciales y cual es ? )

        /*
        MENU
        1. Ingresar estudiante (se ingresa cantidad de N estudiantes)
        2. Buscar estudiante (
            2.1 Ingresar Quiz
                2.1.1 Que quiz quiere ingresar Q1,Q2 y Q3
            2.2 Ingresar Trabajos
                2.2.1 Que trabajo quiere ingresar T1 y T2
            2.3 Ingresar Parciales 
                2.3.1 Que parcial quiere ingresar P1,P2 y P3
        )
        3. Listado General de Notas del Grupo
        4. Listado Notas FINALES
        */


        bool AddMenu = true;
        bool AddInfo = true;
        List<Estudiantes> ListaEstudiante = new List<Estudiantes>();
        while (AddMenu){
            
            Console.WriteLine("=============MENU==============");
            Console.WriteLine("1. Ingresar Estudiante");
            Console.WriteLine("2. Buscar Estudiante");
            Console.WriteLine("3. Imprimir Listado General");
            Console.WriteLine("4. Imprimir Listado FINAL");
            Console.WriteLine("5. Finalizar registro.");
            Console.WriteLine("Ingresa opción: ");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();
            if(option == 1){
                Console.WriteLine("Ingresa los siguientes datos del estudiante: ");
                int option2;
                do{
                    Estudiantes estudiantes = new Estudiantes();
                    Console.WriteLine("Ingresa el codigo del estudiante");
                    estudiantes.Id = Console.ReadLine();
                    if(estudiantes.Id.Length >= 15){
                        Console.WriteLine("Sobre pasa el numero de caracteres (15)");
                        Console.ReadLine();
                        AddInfo = false;
                        break;
                    }
                    Console.WriteLine("Ingreso Nombre: ");
                    estudiantes.Nombre = Console.ReadLine();
                    if(estudiantes.Nombre.Length >= 40){
                        Console.WriteLine("Sobre pasa el numero de caracteres (40)");
                        Console.ReadLine();
                        AddInfo = false;
                        break;
                    }
                    Console.WriteLine("Ingrese Email: ");
                    estudiantes.Email = Console.ReadLine();
                    if(estudiantes.Email.Length >= 40){
                        Console.WriteLine("Sobre pasa el numero de caracteres (40)");
                        Console.ReadLine();
                        AddInfo = false;
                        break;
                    }
                    Console.WriteLine("Ingrese Edad: ");
                    estudiantes.Edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Direccion: ");
                    estudiantes.Direccion = Console.ReadLine();
                    if(estudiantes.Email.Length >= 35){
                        Console.WriteLine("Sobre pasa el numero de caracteres (35)");
                        Console.ReadLine();
                        AddInfo = false;
                        break;
                    }
                    ListaEstudiante.Add(estudiantes);
                    Console.WriteLine("Desea agregar otro estudiante:");
                    Console.WriteLine("1. Para agregar otro");
                    Console.WriteLine("2. Para salir.");
                    option2 = int.Parse(Console.ReadLine());
                    if ( option2 == 1){
                        AddInfo = true;
                    }else{
                        AddInfo = false;
                    }
                    Console.Clear();
                }while(AddInfo);
            }
            if ( option == 2){
                Console.WriteLine("Buscar por: ");
                Console.WriteLine("1. Codigo: ");
                Console.WriteLine("2. Nombre: ");
                option = int.Parse(Console.ReadLine());
                if(option == 1){
                    Console.WriteLine("Ingresa codigo: ");
                    string codigoBusqueda = Console.ReadLine();
                    for ( int i=0;i<=ListaEstudiante.Count; i++){
                        if(ListaEstudiante[i].Id == codigoBusqueda){
                            Console.WriteLine(ListaEstudiante[i]);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}