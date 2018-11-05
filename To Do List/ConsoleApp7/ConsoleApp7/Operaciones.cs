using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Operaciones
    {
        //Creo las listas para almacenar las tareas pendientes, en proceso o terminadas
        List<Tarea> Pendientes = new List<Tarea>();
        List<Tarea> Proceso = new List<Tarea>();
        List<Tarea> Terminado = new List<Tarea>();
        public void VerTareas()//Metodo para ver tareas
        {
            Console.WriteLine("Lista Pendientes\n");
            foreach (var item in Pendientes)//Impresion de lista Pendientes
            {               
                Console.Write("Tarea:"+item.Id + "\nNombre: " + item.NombreTarea + "\nDescripcion: " + item.Descripcion + "\nFecha Inicio: " + item.FechaInicio + "\nEstado: " + item.Status + "\n");
            }
            Console.WriteLine("\nLista En Proceso \n");
            foreach (var item in Proceso)//Impresion de lista Proceso
            {
                Console.Write("Tarea:" + item.Id + "\nNombre: " + item.NombreTarea + "\nDescripcion: " + item.Descripcion + "\nFecha Inicio: " + item.FechaInicio + "\nEstado: " + item.Status + "\n");
            }
            Console.WriteLine("\nLista Terminados\n");
            foreach (var item in Terminado)//Impresion de lista Terminado
            {
                Console.Write("Tarea:" + item.Id + "\nNombre: " + item.NombreTarea + "\nDescripcion: " + item.Descripcion + "\nFecha Inicio: " + item.FechaInicio + "\nEstado: " + item.Status + "\nDescripcion Final: "+item.DescripcionFinal+"\n");
            }
            Console.WriteLine("\nPresione enter para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }
        public void AgregarTarea()//Metodo para agregar tareas a la lista pendientes
        {
            Tarea Tareas = new Tarea();
            Console.Write("Ingrese el numero de la tarea: ");
            Tareas.Id =Console.ReadLine();
            Console.Write("Ingrese el nombre de la tarea: ");
            Tareas.NombreTarea =Console.ReadLine();
            Console.Write("Ingrese la descripcion de la tarea: ");
            Tareas.Descripcion =Console.ReadLine();
            Console.Write("Ingrese la fecha en que se deja la tarea: ");
            Tareas.FechaInicio =Console.ReadLine();
            Tareas.Status = "Pendiente";
            Pendientes.Add(Tareas);//Agrega todos lo elementos en la clase tarea
        }
        public void EditarTareas()//Metodo para editar tareas
        {
            Tarea Tareas = new Tarea();
            foreach (var item in Pendientes)//Impresion de lista Pendientes
            {
                Console.Write("Tarea:" + item.Id + "\nNombre: " + item.NombreTarea + "\nDescripcion: " + item.Descripcion + "\nFecha Inicio: " + item.FechaInicio + "\nEstado: " + item.Status + "\n");
            }
            Console.WriteLine("Lista En Proceso");
            foreach (var item in Proceso)//Impresion de lista Proceso
            {
                Console.Write("Tarea:" + item.Id + "\nNombre: " + item.NombreTarea + "\nDescripcion: " + item.Descripcion + "\nFecha Inicio: " + item.FechaInicio + "\nEstado: " + item.Status + "\n");
            }
            Console.WriteLine("Ingrese el numero de la tarea que desea editar");
            int Opcion = int.Parse(Console.ReadLine());
            Console.Write("La tarea esta? \n1.-Terminada \n2.-En proceso: \n");
            int Opcion2 = int.Parse(Console.ReadLine());
            string Cambio = Opcion.ToString();
            foreach (var item in Pendientes)
            {
                if(Cambio==item.Id && Opcion2 == 1)//Si cambio el igual al id de la tarea y la opcion es 1
                {
                    item.Status = "Terminada";//el status se cambia a terminado
                    Console.WriteLine("Ingrese la descripcion final de la tarea");
                    item.DescripcionFinal = Console.ReadLine();
                    Terminado.Add(item);
                }                    
                if (Cambio == item.Id && Opcion2 == 2)//Si cambio el igual al id de la tarea y la opcion es 2
                {
                    item.Status = "En Proceso";//el status se cambia a en proceso
                    Proceso.Add(item);//Se agrega a la lista proceso            
                }
                
            }
            Pendientes.RemoveAll((x) => x.Id == Opcion.ToString()); //Busca el elemento dentro de la lista y borra todo el objeto dentro de esta
        }
        public void Menu()
        {
            Marca://Etiqueta
            Console.WriteLine("Que desea hacer? \n1.-Ver tareas \n2.-Agregar Tareas \n3.-Editar Status \n4.-Salir");
            int Opcion = int.Parse(Console.ReadLine());
            switch(Opcion)
            {
                case 1:
                    VerTareas();//Llamada de Metodo ver tareas
                    break;
                case 2:
                    AgregarTarea();//Llamada de Metodo agregar tareas
                    break;
                case 3:
                    EditarTareas();//Llamada de Metodo editar tareas
                    break;
                case 4:
                    goto Fin;//Ir a la etiqueta fin
                    break;
            }
            goto Marca;//Ir a etiqueta Marca
            Fin:;//Etiqueta Fin
        }
    }
}
