using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Hayvan hayvan = null;
string value = Console.ReadLine();

if (value == "C")
{
   hayvan = new Kedi();
}
else if (value == "D")
{
    hayvan = new Kopek();
}

hayvan.Konus();
hayvan.Isir();
