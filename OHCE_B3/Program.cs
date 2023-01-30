using OHCE_B3;
using System.Text;

var ohce = new Ohce(new SystemLangProxy(), new SystemTimePeriodeJourneeAdapter().PeriodeJournee);

Console.WriteLine(new SystemTimePeriodeJourneeAdapter().PeriodeJournee);

Console.WriteLine(ohce.Saluer());


Console.WriteLine(ohce.palyndrome(Console.ReadLine() ?? String.Empty));

Console.WriteLine(ohce.AuRevoir());



