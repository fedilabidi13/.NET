using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }

        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        //public bool CheckProfile(string fistname,string lastname)
        //{
        //    return fistname == FirstName && lastname == LastName;

        //}
        //public bool CheckProfile(string fistname, string lastname,string email)
        //{
        //    return fistname == FirstName && lastname == LastName && email == EmailAddress;
        //}
        public bool CheckProfile(string fistname, string lastname, string email = null)
        {
            if (email != null)
            {

                return fistname == FirstName && lastname == LastName && email == EmailAddress;
            }
            else
            {
                return fistname == FirstName && lastname == LastName;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
   
}
