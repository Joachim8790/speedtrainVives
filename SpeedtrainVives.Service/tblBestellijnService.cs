using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using speedtrainVives.DAO;
using speedtrainVives.Models;


namespace speedtrainVives.Service
{
    public class tblBestellijnService
    {
        private tblBestellijnDAO bestellijnDAO = new tblBestellijnDAO();
        //krijg het aantal personen voor hotel of trein van de bestellijn
        public int countPersonen(tblBestellijn bestellijn)
        {
            return bestellijnDAO.countPersonen(bestellijn);
        }
        //krijg een lijst van de personen van de bestellijn
        public IEnumerable<tblTreinplaats> getPersonen(tblBestellijn bestellijn)
        {
            return bestellijnDAO.getPersonen(bestellijn);
        }
        //Schrijf bestellijnen weg
        public int addBestellijn(tblBestellijn bestellijn)
        {
            return bestellijnDAO.addBestellijn(bestellijn);
        }
    }
}
