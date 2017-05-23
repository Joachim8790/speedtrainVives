﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using speedtrainVives.Models;
using System.Data.Entity;

namespace speedtrainVives.DAO
{
    public class tblBestellingDAO
    {
        //Zoek alle bestellingen van gebruiker
        public IEnumerable<tblBestelling> getBestellingenBytblGebruiker(string ID)
        {
            using (var db = new scriptEntities())
            {
                return db.tblBestelling.Where(a => a.GebruikersID == ID).ToList();
            }
        }
        //Zoek bestelling op ID
        public tblBestelling getBestellingByID(int ID)
        {
            using (var db = new scriptEntities())
            {
                return db.tblBestelling.Where(a => a.BestellingID == ID).FirstOrDefault();
            }
        }

        //Lijst van bestellijnen per bestelling
        public IEnumerable<tblBestellijn> getBestellijnenByBestelling(tblBestelling bestelling)
        {
            using (var db = new scriptEntities())
            {
                return db.tblBestellijn.Where(a => a.BestellingID == bestelling.BestellingID).ToList();
            }
        }
        //Schrijf nieuwe bestelling weg
        public int addBestelling(tblBestelling bestelling)
        {
            using (var db = new scriptEntities())
            {
                db.tblBestelling.Add(bestelling);
                db.SaveChanges();
                return bestelling.BestellingID;

            }
        }
        public void bestellingAnnuleren(int id)
        {
            using (var db = new scriptEntities())
            {
                tblBestelling bestelling = getBestellingByID(id);
                bestelling.Geannuleerd = 1;
                db.Entry(bestelling).State = EntityState.Modified;
                db.SaveChanges();


            }
        }


    }
}
