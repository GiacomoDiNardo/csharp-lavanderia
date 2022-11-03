// See https://aka.ms/new-console-template for more information


//5 Lavatrici e 5 Asciugatrici.

using System.Security.Cryptography.X509Certificates;

string[] lavatrici = { "lavatrice1", "lavatrice2", "lavatrice3", "lavatrice4", "lavatrice5" };
string[] asciugatrici = { "asciugatrice1", "asciugatrice2", "asciugatrice3", "asciugatrice4", "asciugatrice5" };

Lavatrice lavatrice1 = new Lavatrice();
Lavatrice lavatrice2 = new Lavatrice();
lavatrice1.Rinnovante();
lavatrice2.Sgrassante();
lavatrice1.Rinfrescante();
public class Lavatrice
{
    private int ammorbidente = 1000;
    private int detersivo = 500;
    private bool inUso;
    private int gettoni;
    private int tempo;

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
            int tPass = new Random().Next(0, value);
            tempo = value - tPass;
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

    public void Rapido ()
    {
        this.Gettoni = 2;
        this.Tempo = 30;
    }

    public void Intenso()
    {
        this.Gettoni = 4;
        this.Tempo = 60;
    }
}