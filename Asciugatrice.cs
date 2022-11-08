// See https://aka.ms/new-console-template for more information


public class Asciugatrice : Macchinario
{

    public Asciugatrice (int gettoni, int tempo)
    {
        Gettoni = gettoni;
        Tempo = tempo;
        InUso = false;
    }

    ProgrammaAsciugatura rapido = new ProgrammaAsciugatura(2, 30, true);
    ProgrammaAsciugatura intenso = new ProgrammaAsciugatura(4, 60, true);

    public ProgrammaAsciugatura Rapido()
    {
        return rapido;
    }

    public ProgrammaAsciugatura Intenso()
    {
        return intenso;

    }

}
