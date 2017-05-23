﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using speedtrainVives.Models;

namespace speedtrainVives.DAO
{
    public class tblBestellijnDAO
    {
        //krijg het aantal personen voor hotel of trein van de bestellijn
        public int countPersonen(tblBestellijn bestellijn)
        {
            using (var db = new scriptEntities())
            {
                return db.tblTreinplaats.Where(a => a.BestellijnID == bestellijn.BestellijnID).Count();
            }
        }
        //krijg een lijst van de personen van de bestellijn
        public IEnumerable<tblTreinplaats> getPersonen(tblBestellijn bestellijn)
        {
            using (var db = new scriptEntities())
            {
                return db.tblTreinplaats.Where(a => a.BestellijnID == bestellijn.BestellijnID).ToList();
            }
        }
        //Schrijf bestellijnen weg
        public int addBestellijn(tblBestellijn bestellijn)
        {
            using (var db = new scriptEntities())
            {
                db.tblBestellijn.Add(bestellijn);
                db.SaveChanges();
                return bestellijn.BestellijnID;

            }
        }
    }
}
