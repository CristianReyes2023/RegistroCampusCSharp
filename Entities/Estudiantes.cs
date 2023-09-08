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
        
                public Estudiantes()
        {
        }
        public Estudiantes(string id,string nombre, string email, int edad, string direccion){
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.edad = edad;
            this.direccion = direccion;
        }



        public static int Imprimir (int Edad){
            Console.WriteLine("Ingresa la edad: ");
            return Edad = int.Parse(Console.ReadLine());
        }
        
    }
}