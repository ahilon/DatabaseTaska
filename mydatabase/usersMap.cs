using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Runtime.CompilerServices;

namespace mydatabase
{
    public sealed class UsersMap : ClassMap<Users>
    {
        public UsersMap()
        {  
            Map(m => m.imie).Name(nameof(Users.imie));
            Map(m => m.nazwisko).Name(nameof(Users.nazwisko));
            Map(m => m.email).Name(nameof(Users.email));
            Map(m => m.ulica).Name(nameof(Users.ulica));
            Map(m => m.miasto).Name(nameof(Users.miasto));
            Map(m => m.kodPocztowy).Name("kod-pocztowy");
            Map(m => m.telefon).Name(nameof(Users.telefon));

        }

    }
}
