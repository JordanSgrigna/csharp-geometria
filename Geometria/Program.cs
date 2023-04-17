using Geometria;

int baseRettangolo;
int altezzaRettangolo;



Console.Write("Scrivi l'altezza del rettangolo: ");
baseRettangolo = int.Parse(Console.ReadLine());

Console.Write("Scrivi la lunghezza del rettangolo: ");
altezzaRettangolo = int.Parse((Console.ReadLine()));

while ((baseRettangolo == altezzaRettangolo) || ((baseRettangolo <= 0) || (altezzaRettangolo <= 0)))
{
	Console.Write("Riscrivi l'altezza del rettangolo diversa dalla lunghezza o da 0: ");
	baseRettangolo = int.Parse(Console.ReadLine());

	Console.Write("Scrivi la lunghezza del rettangolo diversa dalla lunghezza o da 0: ");
	altezzaRettangolo = int.Parse((Console.ReadLine()));
}

Rettangolo rettangoloUno = new Rettangolo(baseRettangolo, altezzaRettangolo);

int perimetroRettangolo = rettangoloUno.calcolaPerimetro();
Console.WriteLine(perimetroRettangolo);

int areaRettangolo = rettangoloUno.calcolaArea();
Console.WriteLine(areaRettangolo);

string stampaRettangolo = rettangoloUno.stampaRettangolo();
Console.WriteLine(stampaRettangolo);


for (int i = 0; i < altezzaRettangolo; i++)
{
	for (int j = 0; j < baseRettangolo; j++)
	{
		if(i == 0 || i < (altezzaRettangolo - 1))
		{
			Console.Write("--");
		} 
		else if(j == 0 || j < (baseRettangolo - 1))
		{
			Console.Write("|");
		}


		

	}

}


