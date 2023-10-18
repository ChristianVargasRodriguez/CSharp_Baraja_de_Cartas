// Crea una clase llamada "Mazo"​
public class Mazo
{
    // Dale a la clase Mazo una propiedad llamada "cartas" que es una lista de objetos de Carta.​
    public List<Carta> Cartas {get; set;}

    // Al inicializar la baraja, asegúrate de que tenga una lista de 52 cartas únicas como propiedad "cartas", 
    // aunque también se puede escribir .Add e instanciar cada tarjeta por separado. 
    // ¡Existe una forma más eficiente para hacer esto! Piensa en el patrón del mazo.​ 
    // Hay 4 pintas y 13 valores para cada una. ​No te preocupes todavía por el nombre de la carta (por ejemplo: As, Sota, Reina). 
    // ​Puedes añadir el nombre después de elaborar el patrón.​ Empieza por calcular cómo harías 4 cartas de cada pinta.​ 
    // Luego piensa cómo harías 13 cartas para cada uno de esas 4 pintas, cada una con su propio valor único del 1 al 13.​ 
    // Estamos haciendo un conjunto de acciones repetidamente. ¿Cómo hacemos algo repetidamente en código?​

    public Mazo()
    {
        Cartas = new List<Carta>();
        InicializarMazo();
    }

    private void InicializarMazo()
    {
        string[] pintas = { "Tréboles", "Picas", "Corazones", "Diamantes" };

        foreach (string pinta in pintas)
        {
            for (int valor = 1; valor <= 13; valor++)
            {
                Cartas.Add(new Carta(ObtenerNombreCarta(valor), pinta, valor));
            }
        }
        
    }

    private string ObtenerNombreCarta(int valor)
    {
        return valor switch
        {
            1 => "A",
            11 => "J",
            12 => "Q",
            13 => "K",
            _ => valor.ToString(),
        };
    }


    // Crea métodos en "Mazo"​


    // Dale al mazo un método de barajado que reordene aleatoriamente las cartas del mazo. ​
    public void Barajar()
    {
        Random rng = new Random();
        Cartas = Cartas.OrderBy(card => rng.Next()).ToList();
        Console.WriteLine("Mazo barajado!.");
    }

    // Dale al Mazo un método de reparto que seleccione la carta "más alta", la elimine de la lista, y la devuelva.​
    public Carta Repartir()
    {
        Carta cartaRepartida = Cartas.Last();
        Cartas.Remove(cartaRepartida);
        Console.WriteLine($"Carta repartida: {cartaRepartida.Nombre} de {cartaRepartida.Pinta}");
        if (Cartas.Count == 0)
        {
            Console.WriteLine("Ya no quedan cartas. Reinicia el mazo");
            // return cartaRepartida;
        }

        return cartaRepartida;
    }

    // Dale al Mazo un método de reinicio que restablezca la propiedad Cartas para que contenga las 52 cartas originales.​
    public void Reiniciar()
    {
        InicializarMazo();
    }

}