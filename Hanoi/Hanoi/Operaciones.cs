using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;//Permite reproducir audio durante ejecucion

namespace Hanoi
{
    public class Operaciones
    {
        public void LlamarHanoi()
        {
            Musica();
            Stack<int> Torre1 = new Stack<int>();//Pilas Torre1 , Torre2 , Torre3 las 3 de tipo entero
            Stack<int> Torre2 = new Stack<int>();
            Stack<int> Torre3 = new Stack<int>();
            Console.WriteLine("Ingresa la cantidad de Discos");
            int CantidadDeDiscos = Int32.Parse(Console.ReadLine());
            for (int i = CantidadDeDiscos; i > 0; i--)//La pila se llenara desde el numero mas alto hasta el menor
            {
                Torre1.Push(i);//Agrego elemento a la pila
            }
            MetodoHanoi(CantidadDeDiscos, Torre1, Torre2, Torre3);//Envio parametros a metodoHanoi
            ImprimirTorres(Torre1, Torre2, Torre3);//Envio parametros a imprimir
        }
        static void MetodoHanoi(int Discos, Stack<int> Torre1, Stack<int> Torre2, Stack<int> Torre3)
        {
            ImprimirTorres(Torre1, Torre2, Torre3);//Llmo el metodo imprimir
            if (Discos == 1)//Caso base de la recursividad
            {
                Torre3.Push(Torre1.Pop());//Se eliminara el elemento de la torre 1 y se enviara a la torre 3
            }
            else
            {//Caso recursivo para el metodo hanoi
                MetodoHanoi(Discos - 1, Torre1, Torre3, Torre2);//Se alterna la posicion de la torre3 y la torre2
                ImprimirTorres(Torre1, Torre2, Torre3);//Imprimo
                MetodoHanoi(1, Torre1, Torre2, Torre3);//Llamo metodo Hanoi con parametros normales
                ImprimirTorres(Torre1, Torre2, Torre3);//Imprimo
                MetodoHanoi(Discos - 1, Torre2, Torre1, Torre3);//Se alternan las posiciones de la torre1 y la torre2
            }
            ImprimirTorres(Torre1, Torre2, Torre3);//impresion  de las torres luego de la recursividad
        }
        static void ImprimirTorres(Stack<int> Torre1, Stack<int> Torre2, Stack<int> Torre3)//Metodo para imprimir las torres
        {
            int Contador = 1;//Contador para uso del set cursor position
            Console.ReadKey();//Pauso ejecucion
            Console.Clear();//Limpio pantalla
            Console.WriteLine("Torre 1");
            foreach (int item in Torre1)//Impresion de la pila Torre1
            {
                Console.WriteLine(item);
            }
            Console.SetCursorPosition(15, 0);//Imprime en la posicion segun las coordenadas indicadas
            Console.WriteLine("Torre 2");
            foreach (int item in Torre2)//Impresion de la pila Torre2
            {
                Console.SetCursorPosition(15, Contador);//Imprime en la posicion segun las coordenadas indicadas
                Console.WriteLine(item);
                Contador++;//Contador + 1
            }
            Contador = 1;
            Console.SetCursorPosition(35, 0);//Imprime en la posicion segun las coordenadas indicadas
            Console.WriteLine("Torre 3");
            foreach (int item in Torre3)//Impresion de la pila Torre3
            {
                Console.SetCursorPosition(35, Contador);//Imprime en la posicion segun las coordenadas indicadas
                Console.WriteLine(item);
                Contador++;//Contador + 1
            }

        }
        public void Musica()
        {
            System.Media.SoundPlayer Musica = new System.Media.SoundPlayer();//Permite reproducir musica en consola
            Musica.SoundLocation = "Tetrix.wav";//Selecciono Cancion a reproducir
            Musica.PlayLooping();//Reproduce la cancion sin parar una y otra vez
        }
    }
}
