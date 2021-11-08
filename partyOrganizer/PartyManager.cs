using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partyOrganizer
{
    public class PartyManager
    {
        private double costPerPerson;
        private double feePerPerson;
        public Guest[] Guests{ get; set; }

        public PartyManager(int maxNumberOfGuests)
        {
            Guests = new Guest[maxNumberOfGuests];

        }

        public bool AddNewGuests(string givenName, string familyName)
        {
            Guest guest = new Guest(familyName, givenName);
            for (int i = 0; i < Guests.Length; i++)
            {
                if (Guests[i] == null)
                {
                    Guests[i] = guest;
                    return true;
                }
            }
            return false;
        }

        public int GetGuestCount()
        {
            int maxNumberOfGuests= Guests.Length;
            int numberOfGuests = 0;

            for (int i = 0; i < maxNumberOfGuests; i++)
            {
                if (Guests[i] != null)
                {
                    numberOfGuests++;
                }
            }

            return numberOfGuests;
        }

        public void DeleteGuest(int i)
        {
            Guests[i] = null;
        }

        public void ChangeGuest(string givenName, string familyName, int i)
        {
            Guest guest = new Guest(familyName, givenName);
            Guests[i] = guest;
        }
    }
}
