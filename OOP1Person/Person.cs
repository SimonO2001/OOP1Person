namespace OOP1Person
{
    internal class Person
    {
        // Private fields til at indsætte de selv indtastede værdier.
        private string? name;
        private DateTime? dob;
        private string? email;
        private string? password;

        // Her er en public property som modtager et return og sætter den værdi til de private fields.
        public string? Name
        {
            get { return name; }
            set
            {   // Tjekker om den indtastede værdi er null.
                if (value == "")
                {
                    Console.WriteLine("Dit navn kan ikke være blankt, indtast igen!");
                    name = null;
                }
                else name = value;
            }
        }
        public DateTime? DoB
        {
            get { return dob; }
            set
            {   // Tjekker om den indsatte værdi er nyere end dags dato.
                if (value < DateTime.Now) dob = value;
                else
                {
                    Console.WriteLine("Indtastning fejlede, din fødelsdag skal være før i dag!");
                    dob = null;
                }
            }
        }
        public string? Email
        {
            get { return email; }
            set
            {   // Tjekker om den indtastede værdi indeholder de angivende krav.
                if (value != null && value.Contains("@") && value.Contains(".")) email = value;
                else Console.WriteLine("Din indtastning skal indeholde et >@< og >.<!");
            }
        }
        public string? Password
        {
            get { return password; }
            set
            {   // Tjekker om den indtastede værdi indeholder de angivende krav.
                if (value != null && value.Length > 6 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsDigit) && !value.Contains(" ")) password = value;
                else Console.WriteLine("Dit password skal indeholde min. 6 karakter, indehodle både stort OG småt bogstav, og må ikke indehodle mellemrum!");
            }
        }
        public int Age
        {
            get
            {
                if (DoB != null)
                {
                    DateTime today = DateTime.Today;
                    int age = today.Year - ((DateTime)DoB).Year;

                    // Udskriver den indtastede fødelsdags fyldte alder ud i år.
                    if (today < new DateTime(today.Year, ((DateTime)DoB).Month, ((DateTime)DoB).Day)) age--;
                    return age;
                }
                else return 0;

            }
        }

        //automastik implementeret property
        public string? Description { get; set; }
    }
}