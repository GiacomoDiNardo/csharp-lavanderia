// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;
//instazio le lavatrici e asciugatrici
Lavatrice[] lavatrici = new Lavatrice[5];
Asciugatrice[] asciugatrici = new Asciugatrice[5];

for (int i = 0; i < lavatrici.Length; i++)
{
    lavatrici[i] = new Lavatrice(500, 1000, 0, 0);
}

for (int i = 0; i < asciugatrici.Length; i++)
{
    asciugatrici[i] = new Asciugatrice(0, 0);
}



//creo un numero casuale di lavaggi
int lavaggi = new Random().Next(1, 100);


//assegno dei lavaggi casuali a delle lavatrici casuali
for (int i = 0; i < lavaggi; i++)
{
    //seleziono casualmente una lavatrice
    int lavatriceRandom = new Random().Next(0, 5);
    //seleziono casualmente un programma
    int random = new Random().Next(0, 4);

    if (random == 1)
    {
        lavatrici[lavatriceRandom].Rinfrescante();
    }
    else if (random == 2)
    {
        lavatrici[lavatriceRandom].Rinnovante();
    }
    else if (random == 3)
    {
        lavatrici[lavatriceRandom].Sgrassante();
    }
    else
    {
        lavatrici[lavatriceRandom].InUso = false;
        lavatrici[lavatriceRandom].Tempo = 0;
    }
}

//verifico quali lavatrici sono attualmente in uso
for (int i = 0; i < lavatrici.Length; i++)
{
    if (lavatrici[i].InUso == true)
    {
        Console.WriteLine("La lavatrice " + i + " è in funzione");
    }
    else
    {
        Console.WriteLine("La lavatrice " + i + " è ferma");
    }
}

Console.WriteLine();

//assegno dei lavaggi casuali a delle asciugatrici casuali
for (int i = 0; i < lavaggi; i++)
{
    //seleziono casualmente una lavatrice
    int asciugatriceRandom = new Random().Next(0, 5);
    //seleziono casualmente un programma
    int random = new Random().Next(0, 3);

    if (random == 1)
    {
        asciugatrici[asciugatriceRandom].Intenso();
    }
    else if (random == 2)
    {
        asciugatrici[asciugatriceRandom].Rapido();
    }
    else
    {
        asciugatrici[asciugatriceRandom].InUso = false;
        asciugatrici[asciugatriceRandom].Tempo = 0;
    }
}

for (int i = 0; i < asciugatrici.Length; i++)
{
    if (asciugatrici[i].InUso == true)
    {
        Console.WriteLine("La asciugatrice " + i + " è in funzione");
    }
    else
    {
        Console.WriteLine("La asciugatrice " + i + " è ferma");
    }
}

Console.WriteLine();

bool continua = true;

while (continua)
{
    Console.WriteLine("Seleziona la lavatrice/asciugatrice di cui vuoi vedere i dettagli: l/a seguito da 0/1/2/3/4. Scrivi 'esci' per terminare.");
    string risposta = Console.ReadLine();
    Console.WriteLine();

    switch (risposta)
    {
        case "l0":
            StampaDettagliL(0);
            Console.WriteLine();
            break;

        case "l1":
            StampaDettagliL(1);
            Console.WriteLine();
            break;

        case "l2":
            StampaDettagliL(2);
            Console.WriteLine();
            break;

        case "l3":
            StampaDettagliL(3);
            Console.WriteLine();
            break;

        case "l4":
            StampaDettagliL(4);
            Console.WriteLine();
            break;

        case "a0":
            StampaDettagliA(0);
            Console.WriteLine();
            break;

        case "a1":
            StampaDettagliA(1);
            Console.WriteLine();
            break;

        case "a2":
            StampaDettagliA(2);
            Console.WriteLine();
            break;

        case "a3":
            StampaDettagliA(3);
            Console.WriteLine();
            break;

        case "a4":
            StampaDettagliA(4);
            Console.WriteLine();
            break;

        case "esci":
            continua = false;
            break;

        default:
            Console.WriteLine("non è un opzione contemplata");
            break;
    }

}
//visualizzo i dettagli di una lavatrice

void StampaDettagliL(int scelta)
{
    Console.WriteLine(lavatrici[scelta].Detersivo + " ml rimasti");
    Console.WriteLine(lavatrici[scelta].Ammorbidente + " ml rimasti");
    Console.WriteLine(lavatrici[scelta].Gettoni + " gettoni");
    Console.WriteLine(lavatrici[scelta].InUso);
    Console.WriteLine(lavatrici[scelta].Tempo + " min");
}


Console.WriteLine();

//visualizzo i dettagli di una asciugatrice
void StampaDettagliA(int scelta)
{
    Console.WriteLine(asciugatrici[scelta].Gettoni + " gettoni");
    Console.WriteLine(asciugatrici[scelta].InUso);
    Console.WriteLine(asciugatrici[scelta].Tempo + " min");
}


Console.WriteLine();

//calcolo l'incasso del giorno
double incasso = 0;

for (int i = 0; i < lavatrici.Length; i++)
{
    incasso = incasso + (lavatrici[i].Gettoni + asciugatrici[i].Gettoni);
}

Console.WriteLine("L'incasso è: " + incasso * 0.5 + " euro");
