using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejderhåndteringssystem
{

    public class User
    {

        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string Email { get; set; }

        public int TelefonNummer { get; set; }

        public int Alder { get; set; }

        public User (string fornavn, string efternavn, string email, int nummer, int alder)
        {

            Fornavn = fornavn;
            Efternavn = efternavn;
            Email = email;
            TelefonNummer = nummer;
            Alder = alder;

        }
        public User ()
        {

        }
        public string CreateQueryString()
        {
            return $"INSERT INTO Users VALUES('{Fornavn}', '{Efternavn}', '{Alder}', '{Email}', '{TelefonNummer}');";
        }
        public string DeleteQueryString()
        {
            return $"DELETE FROM Users WHERE UserPhoneNumber='{TelefonNummer}';";
        }


        
    }
}

