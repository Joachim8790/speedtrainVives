using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using speedtrainVives.Models;
using System.Data.Entity;

namespace speedtrainVives.DAO
{
    public class WinkelmandlijnDAO
    {
        //krijg alle winkelmandlijnen van een gebruiker
        public IEnumerable<tblWinkelmandlijn> getWinkelmandlijnenByGebruiker(string ID)
        {
            using (var db = new scriptEntities())
            {
                return db.tblWinkelmandlijn.Where(a => a.GebruikersID == ID).ToList();
            }
        }
        //verwijder een winkelmandlijn
        public void deleteWinkelmandlijn(int id)
        {
            using (var db = new scriptEntities())
            {
                tblWinkelmandlijn lijn = getWinkelmandLijn(id);
                db.Entry(lijn).State = EntityState.Deleted;    
                db.SaveChanges();
            }
        }

        //verwijder alle winkelmandlijnen van een gebruiker
        public void clearWinkelmand(string ID)
        {
            using (var db = new scriptEntities())
            {
                db.tblWinkelmandlijn.RemoveRange(db.tblWinkelmandlijn.Where(b => b.GebruikersID == ID).ToList());
                db.SaveChanges();
            }
        }
        //voeg een winkelmandlijn toe
        public void addWinkelmandLijn(tblWinkelmandlijn winkelmandlijn)
        {
            using (var db = new scriptEntities())
            {
                db.tblWinkelmandlijn.Add(winkelmandlijn);
                db.SaveChanges();
            }
        }
        //zoek winkelmandlijn
        public tblWinkelmandlijn getWinkelmandLijn(int ID)
        {
            using (var db = new scriptEntities())
            {
                return db.tblWinkelmandlijn.Where(a => a.WinkelmandlijnID == ID).FirstOrDefault();
            }
        }
    }
}
