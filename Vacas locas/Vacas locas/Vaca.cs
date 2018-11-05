using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;//Permite agregar musica

namespace Vacas_locas
{
    class Vaca
    {
        public void Historia()//IMprime el problema
        {
            Console.WriteLine("Bob tiene cuatro vacas que quiere cruzar por un puente, pero solo un yugo");
            Console.WriteLine("que puede sostener hasta dos vacas, lado a lado, atadas al yugo.");
            Console.WriteLine("El yugo es demasiado pesado para que lo lleve a través del puente");
            Console.WriteLine("pero puede atar (y desatar) vacas a él en muy poco tiempo. ");
            Console.WriteLine("De sus cuatro vacas, Mazie puede cruzar el puente en 2 minutos,");
            Console.WriteLine("Daisy puede cruzarlo en 4 minutos, Crazy puede cruzarlo en 10 minutos");
            Console.WriteLine("y Lazy puede cruzar en 20 minutos. Por supuesto, cuando dos vacas están");
            Console.WriteLine("atadas al yugo, deben ir a la velocidad de la vaca más lenta.");
            Console.WriteLine("Como Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos.");
        }
        public void Musica()
        {
            System.Media.SoundPlayer Musica = new System.Media.SoundPlayer();//Permite reproducir musica en consola
            Musica.SoundLocation = "Granja.wav";//Selecciono Cancion a reproducir
            Musica.PlayLooping();//Reproduce la cancion sin parar una y otra vez
        }
    }
}
