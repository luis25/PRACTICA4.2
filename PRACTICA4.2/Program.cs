/*
 * Created by SharpDevelop.
 * User: Aula1
 * Date: 01/10/2013
 * Time: 5:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UNODELATABLA
{
using System;
using System.Collections;
namespace HashTable
{
    class Persona
    {
        public string Codigo, Nombre, Telefono, Email, Facebook;

        public void Personal()
        {
            this.Codigo="";
            this.Nombre = "";
            this.Telefono = "";
            this.Email = "";
            this.Facebook = "";
        }

        public void imprimePersona(Persona m){
			Console.WriteLine("Código: " + m.Codigo);
			Console.WriteLine("Nombre: " + m.Nombre);
			Console.WriteLine("Telefono: " + m.Telefono);
			Console.WriteLine("Correo: " + m.Email);
			Console.WriteLine("Facebook: " + m.Facebook);
            Console.WriteLine("");
		}
        
        static void Main(string[] args)
        {
            Hashtable Personas = new Hashtable();
            for (int i = 0; i < 4; i++)
            {
                    Persona persona = new Persona();
                    Console.Clear();
                    Console.WriteLine("REGISTRO ");
                    Console.WriteLine("Ingresa Codigo");
                    persona.Codigo = Console.ReadLine();
                    Console.WriteLine("Ingresa Nombre");
                    persona.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa Telefono");
                    persona.Telefono = Console.ReadLine();
                    Console.WriteLine("Ingresa Email");
                    persona.Email = Console.ReadLine();
                    Console.WriteLine("Ingresa Facebook");
                    persona.Facebook = Console.ReadLine();
                    try
                    {
                        Personas.Add(persona.Codigo, persona);
                        persona.imprimePersona(persona);
                    }
                    catch
                    {
                        Console.WriteLine("La llave >" + persona.Codigo + "< ya existe");
                    }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine("INGRESA UN CODIGO PARA BUSCAR\n");
                string x = Console.ReadLine();
                try
                {
                    if (Personas.ContainsKey(x))
                    {
                        Persona a = (Persona) Personas[x];
                     //   a.Codigo = x;
                        a.imprimePersona(a);
                        Personas.Remove(x);
                        Console.WriteLine("Ingresa Nombre");
                        a.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa Telefono");
                        a.Telefono = Console.ReadLine();
                        Console.WriteLine("Ingresa Email");
                        a.Email = Console.ReadLine();
                        Console.WriteLine("Ingresa Facebook");
                        a.Facebook = Console.ReadLine();
                        Personas.Add(a.Codigo, a);
                    }

                }
                catch
                {
                    Console.WriteLine("El codigo >" + x + " no existe");
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine("INGRESA UN CODIGO PARA BORRAR\n");
                string x = Console.ReadLine();
                try
                {
                    if (Personas.ContainsKey(x))
                    {
                        Console.WriteLine("Seguro de Borrar a la persona con codigo " + x + "?\n1.- SI \n2.- NO");
                        int r = int.Parse(Console.ReadLine());
                        if (r == 1)
                            Personas.Remove(x);
                        else
                        {
                            Console.Clear();
                        }    
                    }

                }
                catch
                {
                    Console.WriteLine("El codigo >" + x + " no existe");
                }
            }

            Console.Clear();
            Console.WriteLine("LOS QUE FALTAN");
            ICollection pers = Personas.Values;
	        Console.WriteLine();
	        foreach( object objeto in pers )
	        {
	            Persona persona = (Persona) objeto;
				persona.imprimePersona(persona);
	        }
            Console.ReadKey(true);
        }
    }
}
}
