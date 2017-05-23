﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using speedtrainVives.Models;

namespace speedtrainVives.DAO
{
    public class tblProductDAO
    {
        //kijken als het een hotel is
        public bool isHotel(tblProduct product)
        {
            using (var db = new scriptEntities())
            {
                if (product.HotelID == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        //prijs opvragen
        public double getPrijs(tblProduct product)
        {
            using (var db = new scriptEntities())
            {
                if (isHotel(product))//check hotel of traject
                {
                    return db.tblHotel.Where(a => a.HotelID == product.HotelID).FirstOrDefault().PrijsPerOvernachting;//Prijs per overnachting
                }
                else
                {
                    if (product.Treinklasse ==1)
                    {
                        return db.tblTraject.Where(b => b.TrajectID == product.TrajectID).FirstOrDefault().BusinessPrijs;//businessprijs
                    }
                    else
                    {
                        return db.tblTraject.Where(b => b.TrajectID == product.TrajectID).FirstOrDefault().EconomicPrijs;//economicprijs
                    }
                }
            }

        }
        //zoek product op ID
        public tblProduct getProduct(int ID)
        {
            using (var db = new scriptEntities())
            {
                return db.tblProduct.Where(a => a.ProductID == ID).FirstOrDefault();
            }
        }
        //zoek product op hotelID
        public tblProduct getProductByHotel(int hotelID)
        {
            using (var db = new scriptEntities())
            {
                
                    return db.tblProduct.Where(a => a.HotelID == hotelID).FirstOrDefault();
               
            }
        }
        //zoek product op TrajectID
        public tblProduct getProductByTraject(int trajectID,bool isBusinessklasse)
        {
            using (var db = new scriptEntities())
            {

                if (isBusinessklasse)
                {
                    var product = from p in db.tblProduct
                                  where ((p.TrajectID == trajectID) && (p.Treinklasse == 1))
                                  select p;
                    return product.FirstOrDefault();
                }
                else
                {
                    var product = from p in db.tblProduct
                                  where ((p.TrajectID == trajectID) && (p.Treinklasse == 0))
                                  select p;
                    return product.FirstOrDefault();
                }
               

            }
        }

    }
}
