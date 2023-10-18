// Crea una clase llamada "Jugador"​



// Nota: este método requerirá una referencia a un objeto mazo.

// Revisa tu trabajo robando tres cartas e imprimiendo la mano del jugador en la consola.​
// Dale al Jugador un método de descarte que descarta la Carta en el índice especificado de la mano del jugador y devuelve esa Carta o null si el índice no existe.​
// Revisa tu trabajo imprimiendo la mano del Jugador después de ejecutar el método de descarte.​


public class Jugador
{
    // Dale a la clase Jugador una propiedad nombre.​
    public string Nombre { get; }
    // Dale al Jugador una propiedad de mano que sea una Lista de tipo Carta.​
    public List<Carta> Mano { get;}

// Crear constructor para instanciar un nuevo jugador con su nombre y una lista vacía de manos.
    public Jugador(string nombre)
    {
        Nombre = nombre;
        Mano = new List<Carta>();
        Console.WriteLine($"Jugador Creado! Nombre: {nombre}");
    }


    // Dale al Jugador un método de robo en el que roba una carta de la baraja, se añada a la mano del jugador, y devuelve la Carta.
    public Carta? Robar(Mazo mazo)
    {
        Carta cartaRobada = mazo.Repartir();
        if (cartaRobada != null)
        {
            Mano.Add(cartaRobada);
            return cartaRobada;
        }
        else
        {
            Console.WriteLine("No quedan cartas en el mazo para robar.");
            return null;
        }
    }

    public Carta? Descartar(int indice)
    {
        if (indice >= 0 && indice < Mano.Count)
        {
            Carta cartaDescartada = Mano[indice];
            Mano.RemoveAt(indice);
            return cartaDescartada;
        }
        else
        {
            Console.WriteLine("Índice de descarte no válido.");
            return null;
        }
    }
}