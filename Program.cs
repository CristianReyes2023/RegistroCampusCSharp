﻿using System.Diagnostics.Contracts;
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
        2. Agregar y editar notas: (
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
        while (AddMenu)
        {

            Console.WriteLine("=============MENU==============");
            Console.WriteLine("1. Ingresar Estudiante");
            Console.WriteLine("2. Agregar y editar notas: ");
            Console.WriteLine("3. Imprimir Listado General");
            Console.WriteLine("4. Imprimir Listado FINAL");
            Console.WriteLine("5. Finalizar registro.");
            Console.WriteLine("Ingresa opción: ");
            string option = Console.ReadLine();
            Console.Clear();
            if (option == "1")
            {
                Console.WriteLine("Ingresa los siguientes datos del estudiante.");
                string agregar;
                do
                {
                    bool AddId = true;
                    bool AddNombre = true;
                    bool AddEmail = true;
                    bool AddEdad = true;
                    bool AddDireccion = true;
                    Estudiantes estudiantes = new Estudiantes();
                    Console.WriteLine("Ingresa el codigo del estudiante: ");
                    while (AddId)
                    {
                        // if ( ListaEstudiante.Count == 0){
                        //     continue;
                        bool AddIdCheck = true;
                        while (AddIdCheck)
                        {
                            estudiantes.Id = Console.ReadLine();
                            if (ListaEstudiante.Count != 0)
                            {
                                int contador = 0;
                                for (int i = 0; i < ListaEstudiante.Count; i++)
                                {
                                    if (ListaEstudiante[i].Id == estudiantes.Id)
                                    {
                                        Console.WriteLine("Ese codigo ya está registrado.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("Ingresa el codigo del estudiante: ");
                                        contador++;
                                    }
                                    else if (i == ListaEstudiante.Count - 1 && contador == 0)
                                    {
                                        AddIdCheck = false;
                                    }
                                }
                            }
                            else
                            {
                                AddIdCheck = false;
                            }
                        }
                        if (estudiantes.Id.Length >= 15)
                        {
                            Console.WriteLine("Excede el numero de caracteres de max 15.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingresa nuevamente el codigo del estudiante: ");
                        }
                        else if (!double.TryParse(estudiantes.Id, out double numero))
                        {
                            Console.WriteLine("Agregar solo numeros y no otro tipo de datos.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingresa nuevamente el codigo del estudiante: ");
                        }
                        else
                        {
                            AddId = false;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Ingresa el nombre del estudiante: ");
                    while (AddNombre)
                    {
                        estudiantes.Nombre = Console.ReadLine();
                        if (estudiantes.Nombre.Length >= 40)
                        {
                            Console.WriteLine("Excede el numero de caracteres de max 40.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingresa nuevamente el nombre del estudiante: ");
                        }
                        else if (!Estudiantes.SoloLetras(estudiantes.Nombre))
                        {
                            Console.WriteLine("Agregar solo letras y no otro tipo de datos.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingresa nuevamente el nombre del estudiante: ");
                        }
                        else
                        {
                            AddNombre = false;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Ingrese Email: ");
                    while (AddEmail)
                    {
                        estudiantes.Email = Console.ReadLine();
                        if (estudiantes.Email.Length >= 40)
                        {
                            Console.WriteLine("Excede el numero de caracteres de max 40.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingresa nuevamente el Email del estudiante: ");
                        }
                        else
                        {
                            AddEmail = false;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Ingrese Edad: ");
                    while (AddEdad)
                    {
                        string edadString = Console.ReadLine();
                        if (!int.TryParse(edadString, out int numero))
                        {
                            Console.WriteLine("Agregar solo numeros y no otro tiepo de datos.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingresa nuevamente el Edad del estudiante: ");
                        }
                        else
                        {
                            estudiantes.Edad = Convert.ToInt32(edadString);
                            AddEdad = false;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Ingrese Direccion: ");
                    while (AddDireccion)
                    {
                        estudiantes.Direccion = Console.ReadLine();
                        if (estudiantes.Direccion.Length >= 35)
                        {
                            Console.WriteLine("Excede el numero de caracteres de max 35.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Ingresa nuevamente el Direccion del estudiante: ");
                        }
                        else
                        {
                            AddDireccion = false;
                        }
                    }
                    Console.Clear();
                    estudiantes.Quices = new List<float> { 0, 0, 0, 0 };
                    estudiantes.Trabajos = new List<float> { 0, 0 };
                    estudiantes.Parciales = new List<float> { 0, 0, 0 };
                    ListaEstudiante.Add(estudiantes);
                    Console.WriteLine("Desea agregar otro estudiante:");
                    Console.WriteLine("1. Para agregar otro");
                    Console.WriteLine("2. Para salir.");
                    agregar = Console.ReadLine();
                    if (agregar == "1")
                    {
                        AddInfo = true;
                    }
                    else
                    {
                        AddInfo = false;
                    }
                    Console.Clear();
                } while (AddInfo);
            }
            if (option == "2")
            {
                Console.WriteLine("Agregar o editar notas: ");
                Console.WriteLine("1. Quices: ");
                Console.WriteLine("2. Trabajos: ");
                Console.WriteLine("3. Parciales: ");
                string option2 = Console.ReadLine();
                Console.Clear();
                if (option2 == "1")
                {
                    Console.WriteLine("Ingresa codigo completo: ");
                    string codigoBusqueda = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(("").PadRight(190, '-'));
                    Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                    Console.WriteLine(("").PadRight(190, '-'));
                    for (int i = 0; i < ListaEstudiante.Count; i++)
                    {
                        bool AddQuiz = true;
                        if (ListaEstudiante[i].Id == codigoBusqueda)
                        {
                            Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-4}|{6,-4}|{7,-4}|{8,-4}|{9,-4}|{10,-4}|{11,-4}|{12,-4}|{13,-5}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, ListaEstudiante[i].Quices[0], ListaEstudiante[i].Quices[1], ListaEstudiante[i].Quices[2], ListaEstudiante[i].Quices[3], ListaEstudiante[i].Trabajos[0], ListaEstudiante[i].Trabajos[1], ListaEstudiante[i].Parciales[0], ListaEstudiante[i].Parciales[1], ListaEstudiante[i].Parciales[2]);
                            Console.WriteLine(("").PadRight(190, '-'));
                            Console.WriteLine("Enter para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            while (AddQuiz)
                            {
                                Console.WriteLine("Quiz que desea cambiar: ");
                                Console.WriteLine("1. Quiz 1: ");
                                Console.WriteLine("2. Quiz 2: ");
                                Console.WriteLine("3. Quiz 3: ");
                                Console.WriteLine("4. Quiz 4: ");
                                string quizCambio = Console.ReadLine();
                                if (quizCambio == "1")
                                {
                                    Console.WriteLine("Agrega nota para Quiz 1: ");
                                    bool quizCheck = true;
                                    while (quizCheck)
                                    {
                                        string valorQuiz = Console.ReadLine();
                                        if (!float.TryParse(valorQuiz, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Quices[0] = Convert.ToSingle(valorQuiz);
                                            quizCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                if (quizCambio == "2")
                                {
                                    Console.WriteLine("Agrega nota para Quiz 2: ");
                                    bool quizCheck = true;
                                    while (quizCheck)
                                    {
                                        string valorQuiz = Console.ReadLine();
                                        if (!float.TryParse(valorQuiz, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Quices[1] = Convert.ToSingle(valorQuiz);
                                            quizCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                if (quizCambio == "3")
                                {
                                    Console.WriteLine("Agrega nota para Quiz 3: ");
                                    bool quizCheck = true;
                                    while (quizCheck)
                                    {
                                        string valorQuiz = Console.ReadLine();
                                        if (!float.TryParse(valorQuiz, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Quices[2] = Convert.ToSingle(valorQuiz);
                                            quizCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                if (quizCambio == "4")
                                {
                                    Console.WriteLine("Agrega nota para Quiz 4: ");
                                    bool quizCheck = true;
                                    while (quizCheck)
                                    {
                                        string valorQuiz = Console.ReadLine();
                                        if (!float.TryParse(valorQuiz, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Quices[3] = Convert.ToSingle(valorQuiz);
                                            quizCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-4}|{6,-4}|{7,-4}|{8,-4}|{9,-4}|{10,-4}|{11,-4}|{12,-4}|{13,-5}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, ListaEstudiante[i].Quices[0], ListaEstudiante[i].Quices[1], ListaEstudiante[i].Quices[2], ListaEstudiante[i].Quices[3], ListaEstudiante[i].Trabajos[0], ListaEstudiante[i].Trabajos[1], ListaEstudiante[i].Parciales[0], ListaEstudiante[i].Parciales[1], ListaEstudiante[i].Parciales[2]);
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("Continuar agregando notas de quices: ");
                                Console.WriteLine("1. Si.");
                                Console.WriteLine("2. Salir al menu principal");
                                string notaQuices = Console.ReadLine();
                                if (notaQuices == "1")
                                {
                                    AddQuiz = true;
                                }
                                else
                                {
                                    AddQuiz = false;
                                }
                                Console.Clear();
                            }
                            break;
                        }
                        if (i == ListaEstudiante.Count - 1)
                        {
                            Console.WriteLine("No se encontro estudiante");
                        }
                    }
                }
                if (option2 == "2")
                {
                    Console.WriteLine("Ingresa codigo completo: ");
                    string codigoBusqueda = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(("").PadRight(190, '-'));
                    Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                    Console.WriteLine(("").PadRight(190, '-'));
                    for (int i = 0; i < ListaEstudiante.Count; i++)
                    {
                        bool AddTrabajo = true;
                        if (ListaEstudiante[i].Id == codigoBusqueda)
                        {
                            Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-4}|{6,-4}|{7,-4}|{8,-4}|{9,-4}|{10,-4}|{11,-4}|{12,-4}|{13,-5}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, ListaEstudiante[i].Quices[0], ListaEstudiante[i].Quices[1], ListaEstudiante[i].Quices[2], ListaEstudiante[i].Quices[3], ListaEstudiante[i].Trabajos[0], ListaEstudiante[i].Trabajos[1], ListaEstudiante[i].Parciales[0], ListaEstudiante[i].Parciales[1], ListaEstudiante[i].Parciales[2]);
                            Console.WriteLine(("").PadRight(190, '-'));
                            Console.WriteLine("Enter para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            while (AddTrabajo)
                            {
                                Console.WriteLine("Trabajo que desea cambiar: ");
                                Console.WriteLine("1. Trabajo 1: ");
                                Console.WriteLine("2. Trabajo 2: ");
                                string trabajoCambio = Console.ReadLine();
                                bool trabajoCheck = true;
                                if (trabajoCambio == "1")
                                {
                                    Console.WriteLine("Agrega nota para Trabajo 1: ");
                                    while (trabajoCheck)
                                    {
                                        string valorTrabajo = Console.ReadLine();
                                        if (!float.TryParse(valorTrabajo, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Trabajos[0] = Convert.ToSingle(valorTrabajo);
                                            trabajoCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                if (trabajoCambio == "2")
                                {
                                    Console.WriteLine("Agrega nota para Trabajo 2: ");
                                    while (trabajoCheck)
                                    {
                                        string valorTrabajo = Console.ReadLine();
                                        if (!float.TryParse(valorTrabajo, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Trabajos[1] = Convert.ToSingle(valorTrabajo);
                                            trabajoCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-4}|{6,-4}|{7,-4}|{8,-4}|{9,-4}|{10,-4}|{11,-4}|{12,-4}|{13,-5}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, ListaEstudiante[i].Quices[0], ListaEstudiante[i].Quices[1], ListaEstudiante[i].Quices[2], ListaEstudiante[i].Quices[3], ListaEstudiante[i].Trabajos[0], ListaEstudiante[i].Trabajos[1], ListaEstudiante[i].Parciales[0], ListaEstudiante[i].Parciales[1], ListaEstudiante[i].Parciales[2]);
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("Continuar agregando notas de trabajos: ");
                                Console.WriteLine("1. Si.");
                                Console.WriteLine("2. Salir al menu principal");
                                string notaTrabajo = Console.ReadLine();
                                if (notaTrabajo == "1")
                                {
                                    AddTrabajo = true;
                                }
                                else
                                {
                                    AddTrabajo = false;
                                }
                                Console.Clear();
                            }
                            break;
                        }
                        if (i == ListaEstudiante.Count - 1)
                        {
                            Console.WriteLine("No se encontro estudiante.");
                        }
                    }
                }
                if (option2 == "3")
                {
                    Console.WriteLine("Ingresa codigo completo: ");
                    string codigoBusqueda = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(("").PadRight(190, '-'));
                    Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                    Console.WriteLine(("").PadRight(190, '-'));
                    for (int i = 0; i < ListaEstudiante.Count; i++)
                    {
                        bool AddParciales = true;
                        if (ListaEstudiante[i].Id == codigoBusqueda)
                        {
                            Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-4}|{6,-4}|{7,-4}|{8,-4}|{9,-4}|{10,-4}|{11,-4}|{12,-4}|{13,-5}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, ListaEstudiante[i].Quices[0], ListaEstudiante[i].Quices[1], ListaEstudiante[i].Quices[2], ListaEstudiante[i].Quices[3], ListaEstudiante[i].Trabajos[0], ListaEstudiante[i].Trabajos[1], ListaEstudiante[i].Parciales[0], ListaEstudiante[i].Parciales[1], ListaEstudiante[i].Parciales[2]);
                            Console.WriteLine(("").PadRight(190, '-'));
                            Console.WriteLine("Enter para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            while (AddParciales)
                            {
                                Console.WriteLine("Parciales que desea cambiar: ");
                                Console.WriteLine("1. Parciales 1: ");
                                Console.WriteLine("2. Parciales 2: ");
                                Console.WriteLine("3. Parciales 3: ");
                                string parcialCambio = Console.ReadLine();
                                bool parcialCheck = true;
                                if (parcialCambio == "1")
                                {
                                    Console.WriteLine("Agrega nota para Parcial 1: ");
                                    while (parcialCheck)
                                    {
                                        string valorParcial = Console.ReadLine();
                                        if (!float.TryParse(valorParcial, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Parciales[0] = Convert.ToSingle(valorParcial);
                                            parcialCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                if (parcialCambio == "2")
                                {
                                    Console.WriteLine("Agrega nota para Parcial 2: ");
                                    while (parcialCheck)
                                    {
                                        string valorParcial = Console.ReadLine();
                                        if (!float.TryParse(valorParcial, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Parciales[1] = Convert.ToSingle(valorParcial);
                                            parcialCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                if (parcialCambio == "3")
                                {
                                    Console.WriteLine("Agrega nota para Parcial 3: ");
                                    while (parcialCheck)
                                    {
                                        string valorParcial = Console.ReadLine();
                                        if (!float.TryParse(valorParcial, out float numero))
                                        {
                                            Console.WriteLine("Ingrese solo valores numeros.");
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine("Ingresa nota: ");
                                        }
                                        else
                                        {
                                            ListaEstudiante[i].Parciales[2] = Convert.ToSingle(valorParcial);
                                            parcialCheck = false;
                                            Console.Clear();
                                        }
                                    }
                                }
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-4}|{6,-4}|{7,-4}|{8,-4}|{9,-4}|{10,-4}|{11,-4}|{12,-4}|{13,-5}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, ListaEstudiante[i].Quices[0], ListaEstudiante[i].Quices[1], ListaEstudiante[i].Quices[2], ListaEstudiante[i].Quices[3], ListaEstudiante[i].Trabajos[0], ListaEstudiante[i].Trabajos[1], ListaEstudiante[i].Parciales[0], ListaEstudiante[i].Parciales[1], ListaEstudiante[i].Parciales[2]);
                                Console.WriteLine(("").PadRight(190, '-'));
                                Console.WriteLine("Continuar agregando notas de parciales: ");
                                Console.WriteLine("1. Si.");
                                Console.WriteLine("2. Salir al menu principal");
                                string notaParciales = Console.ReadLine();
                                if (notaParciales == "1")
                                {
                                    AddParciales = true;
                                }
                                else
                                {
                                    AddParciales = false;
                                }
                                Console.Clear();
                            }
                            break;
                        }
                        if (i == ListaEstudiante.Count - 1)
                        {
                            Console.WriteLine("No se encontro estudiante.");
                        }
                    }
                }
            }
            if (option == "3")
            {
                Console.WriteLine("Listado General de Estudiantes.");
                int numeroPaginas = 1;
                int contadorEstudiantes = 0;
                Console.WriteLine(("").PadRight(190, '-'));
                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                for (int i = 0; i < ListaEstudiante.Count; i++)
                {
                    Console.WriteLine(("").PadRight(190, '-'));
                    Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-4}|{6,-4}|{7,-4}|{8,-4}|{9,-4}|{10,-4}|{11,-4}|{12,-4}|{13,-5}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, ListaEstudiante[i].Quices[0], ListaEstudiante[i].Quices[1], ListaEstudiante[i].Quices[2], ListaEstudiante[i].Quices[3], ListaEstudiante[i].Trabajos[0], ListaEstudiante[i].Trabajos[1], ListaEstudiante[i].Parciales[0], ListaEstudiante[i].Parciales[1], ListaEstudiante[i].Parciales[2]);
                    contadorEstudiantes++;
                    if (contadorEstudiantes == 10)
                    {
                        numeroPaginas++;
                        contadorEstudiantes = 0;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(("").PadRight(190, '-'));
                        Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-9}|{7,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Quices", "Trabajos", "Parciales");
                    }
                }
                Console.WriteLine(("").PadRight(190, '-'));
                Console.WriteLine("Enter para salir al menu general.");
                Console.ReadKey();
                Console.Clear();
            }
            if (option == "4")
            {
                Console.WriteLine("Listado General de Estudiantes.");
                int numeroPaginas = 1;
                int contadorEstudiantes = 0;
                Console.WriteLine(("").PadRight(208, '-'));
                Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-15}|{6,-15}|{7,-15}|{8,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Def. Quices", "Def. Trabajos", "Def. Parciales", "Nota Final");
                for (int i = 0; i < ListaEstudiante.Count; i++)
                {
                    float defQuices = (ListaEstudiante[i].Quices[0] + ListaEstudiante[i].Quices[1] + ListaEstudiante[i].Quices[2] + ListaEstudiante[i].Quices[3]) / 4;
                    float defTrabajos = (ListaEstudiante[i].Trabajos[0] + ListaEstudiante[i].Trabajos[1]) / 2;
                    float defParciales = (ListaEstudiante[i].Parciales[0] + ListaEstudiante[i].Parciales[1] + ListaEstudiante[i].Parciales[2]) / 3;
                    double notaFinal = (defQuices * 0.25) + (defTrabajos * 0.15) + (defParciales * 0.6);
                    string notaFinalFormato = notaFinal.ToString("N2");
                    Console.WriteLine(("").PadRight(208, '-'));
                    Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-15}|{6,-15}|{7,-15}|{8,-15}|", ListaEstudiante[i].Id, ListaEstudiante[i].Nombre, ListaEstudiante[i].Email, ListaEstudiante[i].Edad, ListaEstudiante[i].Direccion, defQuices, defTrabajos, defParciales, notaFinalFormato);
                    contadorEstudiantes++;
                    if (contadorEstudiantes == 10)
                    {
                        numeroPaginas++;
                        contadorEstudiantes = 0;
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("|{0,-18}|{1,-40}|{2,-40}|{3,-5}|{4,-35}|{5,-19}|{6,-15}|{7,-15}|{8,-15}|", "Codigo estudiante", "Nombre estudiante", "Email Estudiante", "Edad", "Dirección estudiante", "Def. Quices", "Def. Trabajos", "Def. Parciales", "Nota Final");
                    }
                }
                Console.WriteLine(("").PadRight(208, '-'));
                Console.WriteLine("Enter para salir al menu general.");
                Console.ReadKey();
                Console.Clear();
            }
            if (option == "5")
            {
                AddMenu = false;
            }
        }
    }
}