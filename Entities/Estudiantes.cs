using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroEstudiantesC_.Entities
{
    /// <summary>
    /// Crea una clase que está compuesta por información personal del estudiante y de y adicionalmente se crean las listas para agregar notas de Quices, Trabajos y Parciales.
    /// </summary>
    public class Estudiantes
    {
        //ATRIBUTOS
        //Definición de especificaciones y tamaños
        private string id;//Longitud maximo 15 caracteres
        private string nombre;//Longitud maximo 40 caracteres
        private string email;//Longitud maximo 40 caracteres
        private int edad;
        private string  direccion;//Longitud maximo 35 caracteres

        private List<float> quices;
        private List<float> trabajos;
        private List<float> parciales;
        //Properties GET y SET
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public List<float> Quices
        {
            get { return quices; }
            set { quices = value; }
        }
        public List<float> Trabajos
        {
            get { return trabajos; }
            set { trabajos = value; }
        }
        public List<float> Parciales
        {
            get { return parciales; }
            set { parciales = value; }
        }
        public Estudiantes()
        {
        }
        public Estudiantes(string id,string nombre, string email, int edad, string direccion,List<float> quices,List<float> trabajos,List<float> parciales ){
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.edad = edad;
            this.direccion = direccion;
            this.quices = quices;
            this.trabajos = trabajos;
            this.parciales = parciales;

        }
        /// <summary>
        /// Este metodo permite verificar que los nombre de los estudiantes no contenga ningún numero y acepta los espacios en blanco
        /// </summary>
        /// <param name="NombreEstudiante">Nombre de estudiante</param>
        /// <returns>Un booleano para después verificación</returns>
        public static bool SoloLetras (string NombreEstudiante){
            foreach (char i in NombreEstudiante){
                if(!Char.IsLetter(i) && i != ' '){
                    return false;
                }
            }
            return true;
        }
        
    }
}