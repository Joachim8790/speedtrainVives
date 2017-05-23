﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using speedtrainVives.Models;

namespace speedtrainVives.DAO
{
    public class tblStadDAO
    {
        //krijg alle namen van alle steden
        public IEnumerable<string> getSteden()
        {
            using (var db = new scriptEntities())
            {
                return db.tblStad.Select(a =>a.Naam).ToList();
            }
        }
        //Zoek een stad 
        public tblStad getStad(int ID)
        {
            using (var db = new scriptEntities())
            {
                return db.tblStad.Where(a => a.StadID == ID).FirstOrDefault();
            }
        }
    }
}
