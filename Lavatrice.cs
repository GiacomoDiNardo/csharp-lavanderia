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

    public void Rinfrescante()
    {
        Ammorbidente -= rinfrescante.AmmorbidenteUsato;
        Detersivo -= rinfrescante.DetersivoUsato;
        Gettoni += rinfrescante.GettoniRichiesti;
        Tempo = rinfrescante.Tempo;
        InUso = rinfrescante.InUso;
    }

    public void Rinnovante()
    {
        Ammorbidente -= rinnovante.AmmorbidenteUsato;
        Detersivo -= rinnovante.DetersivoUsato;
        Gettoni += rinnovante.GettoniRichiesti;
        Tempo = rinnovante.Tempo;
        InUso = rinnovante.InUso;

    }

    public void Sgrassante()
    {
        Ammorbidente -= sgrassante.AmmorbidenteUsato;
        Detersivo -= sgrassante.DetersivoUsato;
        Gettoni += sgrassante.GettoniRichiesti;
        Tempo = sgrassante.Tempo;
        InUso = sgrassante.InUso;
    }
}


//TempoRimanente = new Random().Next(0, ProgrammaInEsecuzione.Durata + 1);
//public void SimulaAvanzamento()
//{
//    TempoRimanente = new Random().Next(0, TempoRimanente);
//}
