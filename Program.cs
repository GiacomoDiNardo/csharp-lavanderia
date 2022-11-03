// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;
//instazio le lavatrici e asciugatrici
Lavatrice[] lavatrici = new Lavatrice[5];
Asciugatrice[] asciugatrici = new Asciugatrice[5];

for (int i = 0; i < lavatrici.Length; i++)
{
    lavatrici[i] = new Lavatrice();
}

for (int i = 0; i < asciugatrici.Length; i++)
{
    asciugatrici[i] = new Asciugatrice();
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

    if ( random == 1 )
    {
        lavatrici[lavatriceRandom].Rinfrescante();
    } else if (random == 2 )
    {
        lavatrici[lavatriceRandom].Rinnovante();
    } else if ( random == 3 )
    {
        lavatrici[lavatriceRandom].Sgrassante();
    } else
    {
        lavatrici[lavatriceRandom].InUso = false;
        lavatrici[lavatriceRandom].Tempo = 0;
    }
}

//verifico quali lavatrici sono attualmente in uso
for ( int i = 0; i < lavatrici.Length; i++)
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

//visualizzo i dettagli di una lavatrice
Console.WriteLine("scegli una lavatrice (da 0 a 4)");
int lavatriceScelta = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(lavatrici[lavatriceScelta].Detersivo + " ml rimasti");
Console.WriteLine(lavatrici[lavatriceScelta].Ammorbidente + " ml rimasti");
Console.WriteLine(lavatrici[lavatriceScelta].Gettoni + " gettoni");
Console.WriteLine(lavatrici[lavatriceScelta].inUso);
Console.WriteLine(lavatrici[lavatriceScelta].Tempo + " min");

Console.WriteLine();

//visualizzo i dettagli di una asciugatrice
Console.WriteLine("scegli un'asciugatrice (da 0 a 4)");
int asciugatriceScelta = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(asciugatrici[asciugatriceScelta].Gettoni + " gettoni");
Console.WriteLine(asciugatrici[asciugatriceScelta].inUso);
Console.WriteLine(asciugatrici[asciugatriceScelta].Tempo + " min");

Console.WriteLine();

//calcolo l'incasso del giorno
double incasso = 0;

for (int i = 0; i < lavatrici.Length; i++)
{
    incasso = incasso + (lavatrici[i].Gettoni + asciugatrici[i].Gettoni);
}

Console.WriteLine("L'incasso è: " + incasso * 0.5 + " euro");

public class Lavatrice
{
    private int ammorbidente = 500;
    private int detersivo = 1000;
    public bool inUso = false;
    private int gettoni;
    private int tempo = 0;

    public int Ammorbidente
    {
        get
        {
            return ammorbidente;
        }

        set
        {
            ammorbidente -= value;
        }
    }

    public int Detersivo
    {
        get
        {
            return detersivo;
        }
        set
        {
            detersivo -= value;
        }
    }

    public bool InUso { 
        get
        {
            return inUso;
        }

        set
        {

            inUso = value;
        }
    }

    public int Gettoni
    {
        get
        {
            return gettoni;
        }

        set
        {
            gettoni += value;
        }
    }

    public int Tempo { 
        get
        {
            return tempo;
        }

        set
        {
            tempo = 0;
            if (InUso == true)
            {
                int tPass = new Random().Next(0, value);
                tempo = value - tPass;
            }
        }
    }

    public void Rinfrescante()
    {
        this.Ammorbidente = 5;
        this.Detersivo = 20;
        this.Gettoni = 2;
        this.Tempo = 20;
        this.InUso = true;
    }

    public void Rinnovante()
    {
        this.Ammorbidente = 10;
        this.Detersivo = 40;
        this.Gettoni = 3;
        this.Tempo = 40;
        this.InUso = true;
    }

    public void Sgrassante()
    {
        this.Ammorbidente = 15;
        this.Detersivo = 60;
        this.Gettoni = 4;
        this.Tempo = 60;
        this.InUso = true;
    }
}

public class Asciugatrice
{
    private int gettoni;
    private int tempo;
    public bool inUso;

    public int Gettoni
    {
        get
        {
            return gettoni;
        }

        set
        {
            gettoni += value;
        }
    }

    public int Tempo
    {
        get
        {
            return tempo;
        }

        set
        {
            int tPass = new Random().Next(0, value);
            tempo = value - tPass;
        }
    }

    public bool InUso
    {
        get
        {
            return inUso;
        }

        set
        {
            inUso = value;
        }
    }

    public void Rapido ()
    {
        this.Gettoni = 2;
        this.Tempo = 30;
        this.InUso = true;
    }

    public void Intenso()
    {
        this.Gettoni = 4;
        this.Tempo = 60;
        this.InUso = true;
    }
}