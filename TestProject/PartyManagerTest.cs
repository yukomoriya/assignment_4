using NUnit.Framework;
using partyOrganizer;
using System;

namespace TestProject
{
    public class PartyManagerTest
    {
        private const string GivenName = "Addams";

        [Test]
        public void TestAddGuest() {
            const int MaxNumberOfGuests = 3;
            var partyManager = new PartyManager(MaxNumberOfGuests);
            var result = partyManager.AddNewGuests(GivenName, "Birgitt");
            Assert.AreEqual(true, result);
            Assert.AreEqual(GivenName, partyManager.Guests[0].GivenName);
        }

        [Test]
        public void TestTooManyGuests()
        {
            const int MaxNumberOfGuests = 1;
            var partyManager = new PartyManager(MaxNumberOfGuests);

            _ = partyManager.AddNewGuests(GivenName, "Birgitt");
            var result = partyManager.AddNewGuests(GivenName, "Hans");

            Assert.AreEqual(false, result);
            Assert.AreEqual(GivenName, partyManager.Guests[0].GivenName);
        }

        [Test]
        [TestCase(4,1, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(6,5, 5)]
        [TestCase(10,10, 10)]
        [TestCase(10, 11, 10)]
        public void TestHasCorrectGuestCount(int maxNumber, int number, int expected)
        {
            var partyManager = new PartyManager(maxNumber);

            var random = new Random();
            for (int i = 0; i < number; i++)
            {
                _ = partyManager.AddNewGuests(GivenName, random.Next(0, 100).ToString());
            }

            Assert.AreEqual(expected, partyManager.GetGuestCount());
        }
    }
}
