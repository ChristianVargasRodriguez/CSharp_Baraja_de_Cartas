// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("-----------------------------");
Carta cartaEjemplo = new Carta("As", "Tréboles", 1);
cartaEjemplo.Print();
Console.WriteLine("-----------------------------");

Mazo mazo1 = new Mazo();
mazo1.Barajar();
Console.WriteLine("-----------------------------");
mazo1.Cartas.ForEach(carta => carta.Print());
Console.WriteLine("-----------------------------");
mazo1.Repartir();


Console.WriteLine("-----------------------------");
Console.WriteLine("-----------------------------");

Jugador chiri = new Jugador("Chiri");

// Imprimir el nombre del jugador
Console.WriteLine($"Nombre del jugador: {chiri.Nombre}");

// Imprimir las cartas en la mano del jugador
Console.WriteLine("Cartas en la mano del jugador:");
foreach (Carta carta in chiri.Mano)
{
    Console.WriteLine($"{carta.Nombre} de {carta.Pinta}");
}
Console.WriteLine("-----------------------------");
chiri.Robar(mazo1);
chiri.Robar(mazo1);
chiri.Robar(mazo1);
