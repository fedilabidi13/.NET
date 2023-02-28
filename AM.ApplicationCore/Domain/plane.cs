using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain

{
    public enum PlaneType { Boing, Airbus }
    public class plane

    {
        public int Id { get; set; }

        public int Capacity { get; set; }
        public DateTime ManifactureDate { get; set; }
        public int PlaneID { get; set; }
        public PlaneType PlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }
        //public plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    PlaneType = pt;
        //    capacity = capacity;
        //    ManifactureDate = date;
        //}

        //public plane()
        //{
        //}
    }
    

}
