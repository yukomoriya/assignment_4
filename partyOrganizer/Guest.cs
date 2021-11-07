namespace partyOrganizer
{
    public class Guest
    {
        public string FamilyName { get; private set; }
        public string GivenName { get; private set; }

        public Guest(string familyName, string givenName)
        {
            FamilyName = familyName;
            GivenName = givenName;
        } 

        public override string ToString()
        {
            return FamilyName.ToUpper() + ", " + GivenName; 
        }
    }
}