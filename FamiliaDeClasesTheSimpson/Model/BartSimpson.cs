
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BartSimpson : HomeroSimpson,Estudian {

    public BartSimpson() {
    }

    public bool rebelde;

    public bool usaSkateBoard;

    public bool picardia;

    public bool definirRebelde(bool Estudian) 
    {
        Console.WriteLine("Si estudia");
        return false;
    }

    public void definirUsaSkateBoard() {
        // TODO implement here
    }

    public void definirPicardia() {
        // TODO implement here
    }

}