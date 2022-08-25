namespace OOP1Person
{


    internal class StartUp
    {
        // Her oprettes en ny list.
        public List<Person> People = new();


        public StartUp()
        {
            // Dette loop gør programmet vil køre forevigt indtil man selv lukker det.
            while (true)
            {   
                // Dette gør consolet bliver "clearet" altså alt indhold bliver slettet
                Console.Clear();
                
                // Her giver vi en variabel vores indtastede værdier i object og returner det til "p"
                Person p = CreatePerson();
            }
        }

        private Person CreatePerson()
        {
            // Opretter ny instance af vores person Object.
            Person person = new();

         
            // Her kaldes alle vores diverse metoder, som gør user selv kan indtaste værdier i objectets private fields gennem "Person".
            GetName(person);
            Console.Clear();
            Console.WriteLine($"Velkommen: {person.Name}!");

            GetDoB(person);
            Console.Clear();
            Console.WriteLine($"Du er fyldt: {person.Age} år, og født d. {person.DoB}.");

            GetEmail(person);
            Console.Clear();
            Console.WriteLine($"Din email-adresse er: {person.Email}");

            GetPassword(person);
            Console.Clear();
            Console.WriteLine($"Dit password er: {person.Password}, del det ikke med nogen!\nTryk ind tast for at indskrive igen!");

            // Her er en readkey som blot gør man kan nå at læse den sidste writeline inden programmet kører loopet igen.
            Console.ReadKey();
            return person;
        }

        //Metode for at få navnet fra indtastning.
        private void GetName(Person person)
        {
            do
            {
                Console.Write("Indtast venligst dit navn!: ");

                // Indtaster en værdi ind i person objektets private field.
                person.Name = Console.ReadLine();
            }
            // Loopet kører så længe den indtastede værdi er null altså der ingen værdi er indtastet.
            while (person.Name == null);
        }

        // Metode for at få personens fødelsdagsdato.
        private void GetDoB(Person person)
        {
            do
            {
                Console.Write("Indtast den dato du blev født på (f.eks. 14-04-2001): ");

                // Her tjekkes om den indtastede værdi er en dato, og indsætter værdien i objektet.
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                else person.DoB = null;
            }
            while (person.DoB == null);
        }

        // Metode for at få e-mail, dette er den samme metode som at få navn.
        private void GetEmail(Person person)
        {
            do
            {
                Console.Write("Indtast din email: ");
                person.Email = Console.ReadLine();
            }
            while (person.Email == null);
        }

        // Metode for at få kodeord
        private void GetPassword(Person person)
        {
            do
            {
                Console.Write("Indtast dit hemmlige password: ");
                person.Password = Console.ReadLine();
            }
            while (person.Password == null);
        }
    }
}