// See https://aka.ms/new-console-template for more information


public class ProgrammaAsciugatura : Programma
{
    public ProgrammaAsciugatura (int gettoniRichiesti, int tempo, bool inUso)
    {
        GettoniRichiesti = gettoniRichiesti;
        Tempo = tempo;
        InUso = inUso;
    }
}