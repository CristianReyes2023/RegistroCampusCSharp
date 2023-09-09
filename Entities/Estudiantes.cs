using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroEstudiantesC_.Entities
{
    public class Estudiantes
    {
        //ATTRIBUTES
        //defined attributes for each student class
        private string id;//Long max 15 characters
        private string nombre;//Long max 40 characters
        private string email;//Long max 40 characters
        private int edad;
        private string  direccion;//Long max 35 characters

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