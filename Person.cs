using System;

namespace PRS
{
    using System;
   
    class Person
    { 
        // Privata fält
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;
        /*
        // Publika properties med get och set
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("The entered number most be a number higher than zero");
                }
            }
        }

        public string FirstName
        {
            get { return fName; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("First names have to be with the range of 2-10 letters");
                }
            }
        }

        public string LastName
        {
            get { return lName; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else 
                {
                    throw new ArgumentException("Last Names have to be within the range of 3-15 letters");
                }
            
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
    */
    class PersonHandler
    {
        public Person CreatePerson(int age, string Fname, string LName, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FirstName = Fname;
            person.LastName = LName;
            person.Weight = weight;
            person.Height = height;

            return person;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFirstName(Person pers, string FName)
        {
            pers.FirstName = FName;
        }

        public void SetLastName(Person person, string LName)
        {
            person.LastName = LName;
        }

        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }

        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();
            // Instansiera en Person
            Person person = new Person();

            personHandler.SetAge(person, 30);

            try
            {
                personHandler.SetAge(person, -5);
                //Access to the properties
                person.Age = 30;
                person.FirstName = "John";
                person.LastName = "Doe";
                person.Height = 175.5;
                person.Weight = 70.2;

                //Incorrect input examples
                person.Age = -5;
                person.FirstName = "A"; // För kort
                person.LastName = "AveryVeryLongLastName";
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Incorrect input");
            }

            // Hämta värden från properties
            Console.WriteLine($"Namn: {person.FirstName} {person.LastName}");
            Console.WriteLine($"Ålder: {person.Age} år");
            Console.WriteLine($"Höjd: {person.Height} cm");
            Console.WriteLine($"Vikt: {person.Weight} kg");
        }
    }

}