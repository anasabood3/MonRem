using System;
using System.Data.SQLite;
using System.Drawing;
using System.Collections.Generic;

namespace MonremSys
{
    class Transfer
    {
        private int id;
        protected DateTime createdAt;
        protected int amount=5;
        protected string description;
        private Currency transfercurrency;
        protected float comission;

        //Meta data
        public Dictionary<string, PointF> meta = new Dictionary<string, PointF>
        {
            {"id_location",new PointF(90,230)},
            {"date_location",new PointF(90,1030)},
            { "receiver_location",new PointF(280, 380)},
            { "amount_location",new PointF(280, 400)},
            { "description_location",new PointF(280, 540)},

        };

        public DateTime CreatedAt    // Date Property
        { get; set; } = DateTime.Now;

        public string Description   // Decription Property
        { get; set; } = "";

        public int Amount        // Amount Property
        {
            get { return amount; }
            set
            {
                amount = value;
            }
        }

        public float Comission           // Comission Property
        {
            get { return comission; }
            set
            {
                comission = value;
            }
        }



        internal Currency Transfercurrency { get => transfercurrency; set => transfercurrency = value; }
        public int Id { get => id; set => id = value; }




        // virtual database management functions

        public virtual void AddintoDb()
        {

        }
        public virtual void EditinDb()
        {

        }
        public virtual void DeletefromDb()
        {

        }
        // get item  data from database
        public virtual Transfer RetrievefromDb(int id)
        {
            return null;
        }
        //Genearet a Recipt for the customer
        public virtual Bitmap GenReceipt(string template_path)
        {
            return null;
        }
    }



}
