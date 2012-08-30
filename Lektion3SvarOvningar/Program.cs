using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion3SvarOvningar.ExtensionMethods;
using Lektion3SvarOvningar.Model.Repository;
using Lektion3SvarOvningar.Model;

namespace Lektion3SvarOvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(@"
Det krävs eg. ingenting.

T representerar en generisk typ - dvs. den kan ersättas av vilken typ som helst

Vad gäller .Contains(..) som används i funktionen så kräver den att typen som 
används skall implementera interfacet IEquatable. 

Dock så ärver alla objekt från System.Object, som implementerar IEquatable.
Dvs. ifall inte typen som används implementerar IEquatable så kommer den
falla tillbaka på Objects Equals()-metod. 

Detta innebär att för att true skall returneras så måste exakt samma objekt
finnas med i listan (eller rättare sagt en referens till samma objekt). T.ex,
för User-objekt, så räcker det inte ifall en User med samma username finns med 
i listan.

            ");

            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
