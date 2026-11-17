using System;
using System.Collections.Generic;
using System.Text;

namespace fantasybestariumTorokDonat
{
    internal class Szorny
    {
        private int id;
        private string nev;
        private int veszelyessegiSzint;
        private string elohely;
        private string foGyengeseg;
        private string leggyakoribbZsakmany;
        private bool veszelyesE;

        public Szorny(int id, string nev, int veszelyessegiSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool veszelyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegiSzint = veszelyessegiSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            this.leggyakoribbZsakmany = leggyakoribbZsakmany;
            this.veszelyesE = veszelyesE;
        }

        public int Id { get => id;}
        public string Nev { get => nev;}
        public int VeszelyessegiSzint { get => veszelyessegiSzint;}
        public string Elohely { get => elohely;}
        public string FoGyengeseg { get => foGyengeseg;}
        public string LeggyakoribbZsakmany { get => leggyakoribbZsakmany;}
        public bool VeszelyesE { get => veszelyesE;}
    }
}
