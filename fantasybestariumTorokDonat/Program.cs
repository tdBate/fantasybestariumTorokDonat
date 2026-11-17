namespace fantasybestariumTorokDonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis szDb = new SzornyAdatbazis();
            Szornyelemzo szornyelemzo = new Szornyelemzo(szDb.Feltolt());

            Console.WriteLine("Szörnyek száma: "+ szornyelemzo.OsszesSzornySzama());
            Console.WriteLine();
            Console.WriteLine("Veszelyes szörnyek nevei: "+ String.Join(", ", szornyelemzo.VeszelyesSzornyekNevei()));
            Console.WriteLine();
            Console.WriteLine("Egyedi elohelyek: " + String.Join(", ", szornyelemzo.EgyediElohelyek()));
            Console.WriteLine();
            Console.WriteLine("Átlagos veszélyesség: "+szornyelemzo.AtlagosVeszelyesseg());
            Console.WriteLine();
            Console.WriteLine("Legveszélyesebb szörnyek: " + String.Join(", ", szornyelemzo.LegveszelyesebbSzornyek().Select(item=> item.Nev)));
            Console.WriteLine();
            Console.WriteLine("Mocsári veszélyes szörnyek: " + String.Join(", ", szornyelemzo.MocsariVeszelyesSzornyek().Select(item => item.Nev)));
            Console.WriteLine();
            Console.WriteLine("Van e tűz extrém gyenge szörny: "+ szornyelemzo.VanExtremTuzGyengeSzorny().ToString());
            Console.WriteLine();
            Console.WriteLine("Szörnyek száma élőhelynként: " + String.Join(", ", szornyelemzo.SzornyekSzamaElohelyenkent()));

        }
    }
}
