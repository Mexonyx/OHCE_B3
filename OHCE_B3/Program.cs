using OHCE_B3;
using System.Text;

var ohce = new Ohce(new SystemLangProxy(), new SystemTimePeriodeJourneeAdapter().PériodeJournée);

Console.WriteLine(new SystemTimePeriodeJourneeAdapter().PériodeJournée);

Console.WriteLine(ohce.Saluer());


Console.WriteLine(ohce.palyndrome(Console.ReadLine() ?? String.Empty));

Console.WriteLine(ohce.AuRevoir());



