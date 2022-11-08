// See https://aka.ms/new-console-template for more information


public class ProgrammaLavaggio : Programma
{
    public int DetersivoUsato { get; set; }
    public int AmmorbidenteUsato { get; set; }

    public ProgrammaLavaggio(int gettoniRichiesti, int detetersivoUsato, int ammorbidenteUsato, int tempo, bool inUso)
    {
        GettoniRichiesti = gettoniRichiesti;
        DetersivoUsato = detetersivoUsato;
        AmmorbidenteUsato = ammorbidenteUsato;
        Tempo = tempo;
        InUso = inUso;
    }
}