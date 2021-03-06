﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsraVisor_server.Models
{
    public class Guide_Expertise
    {
        public int guidegCode { get; set; }
        public int ExpertiseCode { get; set; }

        //מוחקת התמחויות של מדריך ספציפי
        public void DeleteExpertisesGuide(int id)
        {
            DBservices db = new DBservices();
            db.DeleteAllGuideExpertiseFromSQL(id);
        }
        
        //מקבלת רשימת התמחויות של מדריך ספציפי
        public List<Expertise> GetGuideExpertises(int id)
        {
            DBservices db = new DBservices();
            return db.GetGuideExpertisesFromSQL(id);
        }

        //מכניסה התמחויות של מדריך ספציפי
        public List<Expertise> PostAllGuideExpertises(List<Guide_Expertise> ex)
        {
            DBservices db = new DBservices();
            db.DeleteAllGuideExpertiseFromSQL(ex[0].guidegCode);
            for (int i = 0; i < ex.Count; i++)
            {
                db.PostGuideExpertiseToSQL(ex[i]);
            }
            return db.GetGuideExpertisesFromSQL(ex[0].guidegCode);
        }
    }
}