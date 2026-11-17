using System;
using System.Collections.Generic;
using System.Text;

namespace fantasybestariumTorokDonat
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek = new List<Szorny>();

        public Szornyelemzo()
        {
            SzornyAdatbazis szDb = new SzornyAdatbazis();
            this.szornyek = szDb.Feltolt();
        }

        public int OsszesSzornySzama() {
            return szornyek.Count();
        }

        public IEnumerable<string> VeszelyesSzornyekNevei()
        {
            return szornyek
                .Where(item => item.VeszelyesE)
                .Select(item => item.Nev);
        }

        public IEnumerable<string> EgyediElohelyek() 
        {
            return szornyek
                .OrderBy(item => item.Nev)
                .Select(item => item.Elohely)
                .Distinct();
        }

        public double AtlagosVeszelyesseg()
        {
            return szornyek
                .Select(item => item.VeszelyessegiSzint)
                .Average();
        }

        public IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            int legMagasabbSzint = szornyek.Select(item => item.VeszelyessegiSzint).Max();

            return szornyek.Where(item => item.VeszelyessegiSzint == legMagasabbSzint);
        }

        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            return szornyek
                .Where(item => item.Elohely.Equals("Fekete Mocsár") && item.VeszelyessegiSzint >= 5)
                .OrderByDescending(item => item.VeszelyessegiSzint);
        }

        public bool VanExtremTuzGyengeSzorny()
        {
            return szornyek.Any(item=>
            item.VeszelyessegiSzint>=9 &&
            item.FoGyengeseg.Equals("Tűz"));
        }

        public IEnumerable<string> SzornyekSzamaElohelyenkent()
        {
            return szornyek
                .GroupBy(item => item.Elohely)
                .Select(item => item.Key + "-" + item.Count());
        }


    }
}
