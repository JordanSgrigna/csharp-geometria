using Geometria;

Console.Write("Scrivi l'altezza del rettangolo: ");
int baseRettangolo = int.Parse(Console.ReadLine());

Console.Write("Scrivi la lunghezza del rettangolo: ");
int altezzaRettangolo = int.Parse((Console.ReadLine()));

while((baseRettangolo == altezzaRettangolo) || ((baseRettangolo == 0) || (altezzaRettangolo == 0)))
{
	Console.Write("Riscrivi l'altezza del rettangolo diversa dalla lunghezza o da 0: ");
	baseRettangolo = int.Parse(Console.ReadLine());

	Console.Write("Scrivi la lunghezza del rettangolo diversa dalla lunghezza o da 0: ");
	altezzaRettangolo = int.Parse((Console.ReadLine()));
}

Rettangolo rettangoloUno = new Rettangolo(baseRettangolo, altezzaRettangolo);