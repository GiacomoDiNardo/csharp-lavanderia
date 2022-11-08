// See https://aka.ms/new-console-template for more information


public class Lavatrice : Macchinario
{
    public int Ammorbidente { get; set; }

    public int Detersivo { get; set; }

    public Lavatrice (int ammorbidente, int detersivo, int gettoni, int tempo)
    {
        Ammorbidente = ammorbidente;
        Detersivo = detersivo;
        InUso = false;
        Tempo = tempo;
        Gettoni = gettoni;
    }

    ProgrammaLavaggio rinfrescante = new ProgrammaLavaggio(2, 20, 5, 20, true);
    ProgrammaLavaggio rinnovante = new ProgrammaLavaggio(3, 40, 10, 40, true);
    ProgrammaLavaggio sgrassante = new ProgrammaLavaggio(4, 60, 15, 60, true);

    public ProgrammaLavaggio Rinfrescante()
    {
        return rinfrescante;
    }

    public ProgrammaLavaggio Rinnovante()
    {
        return rinnovante;

    }

    public ProgrammaLavaggio Sgrassante()
    {
        return sgrassante;

    }
}
