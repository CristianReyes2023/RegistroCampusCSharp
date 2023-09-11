# Ejercicio Notas C#

Un profesor del área de matemáticas, necesita generar un programa que le permita registrar los estudiantes que se encuentran matriculados, la información que el docente posee de cada estudiante es la siguiente:

Código del estudiante: con una longitud maxima de 15 caracteres

Nombre: longitud max de 40 caracteres

Email: longitud max de 40 caracteres

Edad: 2 caracteres 

Dirección: longitud max de 35

 No se conocen la cantidad de estudiantes que se registraron en la asignatura.

 La universidad tiene como norma que cada estudiante de presentar 4 Quieces, 2 Trabajos y 3 Parciales.Las notas de los quieces equivalen al 25%, los trabajos al 15% y los parciales 60%.

#####  El programa debe permitirle al profesor generar los siguientes reportes:

1) Listado General de notas del grupo, paginado por 10 estudiante 

​    |Codigo|       Nombre      |                  Quices           |    Trabajos |   Parciales      |

   -------------|----------------------|-Q1-|-Q2-|-Q3-|-Q4-|--|-T1-|-T2-|--|-P1-|-P2-|-P3-|

2) Notas Finales 

  |---CODIGO---|---Nombre---|---Def Quices---|---Def Trabajos---|---Def Parciales---|--- Nota Final---|

El programa debe permitirle al docente realizar todo el proceso de registro de notas de Quices, trabajos y Parciales (Debo buscar el estudiante y asignar el Quiz (1,2 o 3 ) debo darle la opción de escoger el Id, trabajos y parciales y cual es ?)

Se plateo el siguiente Menu para el programa.
        MENU

   1. Ingresar estudiante (se ingresa cantidad de N estudiantes)
   2. Agregar y editar notas: 
      2.1 Ingresar Quiz
          2.1.1 Que quiz quiere ingresar Q1,Q2 y Q3
      2.2 Ingresar Trabajos
          2.2.1 Que trabajo quiere ingresar T1 y T2
      2.3 Ingresar Parciales 
          2.3.1 Que parcial quiere ingresar P1,P2 y P3.
   3. Listado General de Notas del Grupo
   4. Listado Notas FINALES.



### DESARROLLO DEL PROGRAMA.

1. Ingresar estudiante (se ingresa cantidad de N estudiantes) ==> Nos permite ingresar todos los datos del estudiante, teniendo en cuenta las condiciones planteadas en el programa.
2. Agregar y editar notas ==> Está opción nos permite ingresar los quices, trabajos y parciales que el profesor desee usando únicamente el CODIGO completo del estudiante, siempre que se haga un ingreso se mostrara al cliente la tabla del estudiante seleccionado para asegurarse que se hizo de manera correcta. En dado caso que se cometa un error en el ingreso de
3. Imprimir Listado General ==> Nos muestra la tabla general del grupo, se mostrara de 10 en 10 hasta finalizar con todos los estudiantes ingresados.
4. Imprimir Listado FINAL ==> Nos muestra la tabla con las notas definitivas de cada estudiante  y se mostrara de 10 en 10 hasta finalizar con todos los estudiantes ingresados.



##### Funcionamiento de las clases

Se creo unicamente una clase llamada Estudiantes.cs, en esta se crean las propiedades, atributos y constructor necesarios para el desarrollo del programa. Es importante resaltar que desde un inicio se le designa valores de 0 para quices,trabajos y parciales, que luego serán editados usando la opción 2 del menú general.

###### Metodos.

Se creo un metodo dentro de la función  estudiantes llamado "SoloLetras"

```c#
        public static bool SoloLetras (string NombreEstudiante){
            foreach (char i in NombreEstudiante){
                if(!Char.IsLetter(i) && i != ' '){
                    return false;
                }
            }
            return true;
        }
```

Este método nos permite verificar que el nombre del estudiante solo estará compuesto por letras y espacios entre los nombres, y no otro tipo de datos .