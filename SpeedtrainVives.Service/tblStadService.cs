﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using speedtrainVives.Models;
using speedtrainVives.DAO;


namespace speedtrainVives.Service
{
    public class tblStadService
    {
        private tblStadDAO stadDAO = new tblStadDAO();
        //Zoek een lijst van alle steden
        public IEnumerable<string> getSteden()
        {
            return stadDAO.getSteden();
        }
        //Zoek een stad 
        public tblStad getStad(int ID)
        {
            return stadDAO.getStad(ID);
              
        }
    }
}
