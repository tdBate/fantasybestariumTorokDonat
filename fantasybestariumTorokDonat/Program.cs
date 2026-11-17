using Microsoft.IdentityModel.Tokens;

namespace fantasybestariumTorokDonat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis szDb = new SzornyAdatbazis();
            Szornyelemzo szornyelemzo = new Szornyelemzo(szDb.Feltolt());
        }
    }
}
