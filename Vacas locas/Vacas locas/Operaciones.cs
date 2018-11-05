using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas_locas
{
    class Operaciones
    {
        List<string> LadoInicial = new List<string>();//Lista LadoInicial
        List<string> LadoFinal = new List<string>();//Lista LadoFinal
        public void Impresion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;//Cambia el color de las letras
            Console.WriteLine("Lado Inicial");
            foreach (var item in LadoInicial)//Imprimo Lista LadoInicial
            {    
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;//Cambia el color de las letras
            Console.WriteLine("\nLado Final");
            foreach (var item in LadoFinal)//Imprimo Lista LadoFinal
            {
                Console.WriteLine(item);
            }
        }
        public void Llenado()//Lleno la Lista lado inicial con elementos string
        {
            LadoInicial.Add("Mazie=2");//Añado a las 4 vacas
            LadoInicial.Add("Daisy=4");
            LadoInicial.Add("Crazy=10");
            LadoInicial.Add("Lazy=20");
        }
        public void Proceso()
        {
            Vaca vaca = new Vaca();//Instancio objeto de la clase vaca
            vaca.Musica();//Llamo Metodo Musica
            vaca.Historia();//Llamo MetodoHistoria
            int Tiempo = 0;
            Llenado();//Llamo metodo llenado
            Console.WriteLine("El tiempo actual es: {0} minutos", Tiempo);//Imprimo el tiempo actual 
            Impresion();//LLamo metodo Impresion
            LadoInicial.Remove("Mazie=2");//Remuevo elemento especificos de la lista lado inicial
            LadoInicial.Remove("Daisy=4");
            LadoFinal.Add("Mazie=2");//Agrego elementos a la clase lado Final
            LadoFinal.Add("Daisy=4");
            Console.ReadKey(true);
            Console.Clear();
            Tiempo += 4;//Tiempo +4
            Console.WriteLine("El tiempo actual es: {0} minutos", Tiempo);//Imprimo el tiempo actual
            Impresion();
            LadoInicial.Add("Mazie=2");
            LadoFinal.Remove("Mazie=2");//Remuevo elemento especificos de la lista lado final
            Console.ReadKey(true);//Pauso Pantalla
            Console.Clear();//LImpio Pantalla
            Tiempo += 2;//Tiempo + 2
            Console.WriteLine("El tiempo actual es: {0} minutos", Tiempo);//Imprimo el tiempo actual
            Impresion();
            Console.ReadKey();//Paudo Pantalla
            Console.Clear();//Limpio consola
            LadoFinal.Add("Crazy=10");
            LadoFinal.Add("Lazy=20");
            LadoInicial.Remove("Crazy=10");//Remuevo elemento especifico de la lista lado inicial
            LadoInicial.Remove("Lazy=20");//Remuevo elemento especifico de la lista lado inicial
            Tiempo += 20;//Tiempo + 20
            Console.WriteLine("El tiempo actual es: {0} minutos", Tiempo);//Imprimo el tiempo actual
            Impresion();
            Console.ReadKey(true);
            Console.Clear();
            LadoFinal.Remove("Daisy=4");//Remuevo elemento especifico de la lista lado final
            LadoInicial.Add("Daisy=4");//Agrego elemento especifico de la lista lado inicial
            Tiempo += 4;
            Console.WriteLine("El tiempo actual es: {0} minutos", Tiempo);//Imprimo el tiempo actual
            Impresion();
            Console.ReadKey(true);
            Console.Clear();
            LadoInicial.Remove("Mazie=2");//Remuevo elemento especifico de la lista lado inicial
            LadoInicial.Remove("Daisy=4");//Remuevo elemento especifico de la lista lado inicial
            LadoFinal.Add("Mazie=2");
            LadoFinal.Add("Daisy=4");
            Tiempo += 4;
            Console.WriteLine("El tiempo actual es: {0} minutos", Tiempo);//Imprimo el tiempo actual
            Impresion();
            Console.ReadKey(true);
        }

    }
}
