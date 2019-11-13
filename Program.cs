using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPopulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commonFirstNames = new List<string>()
            {
                "Jacob",
                "Michael",
                "Matthew",
                "Joshua",
                "Christopher",
                "Nicholas",
                "Andrew",
                "Joseph",
                "William",
                "Anthony",
                "David",
                "Alexander",
                "Ethan",
                "Daniel",
                "Ryan",
                "Tyler",
                "James",
                "John",
                "Jonathan",
                "Noah",
                "Brandon",
                "Christian",
                "Dylan",
                "Samuel",
                "Benjamin",
                "Nathan",
                "Zachary",
                "Logan",
                "Justin",
                "Gabriel",
                "Jose",
                "Austin",
                "Kevin",
                "Elijah",
                "Caleb",
                "Robert",
                "Thomas",
                "Jordan",
                "Cameron",
                "Jack",
                "Hunter",
                "Jackson",
                "Angel",
                "Isaiah",
                "Evan",
                "Isaac",
                "Luke",
                "Mason",
                "Jayden",
                "Jason",
                "Gavin",
                "Connor",
                "Aiden",
                "Aidan",
                "Kyle",
                "Juan",
                "Charles",
                "Luis",
                "Adam",
                "Lucas",
                "Brian",
                "Eric",
                "Adrian",
                "Nathaniel",
                "Sean",
                "Alex",
                "Carlos",
                "Bryan",
                "Ian",
                "Owen",
                "Jesus",
                "Landon",
                "Julian",
                "Chase",
                "Cole",
                "Diego",
                "Jeremiah",
                "Steven",
                "Sebastian",
                "Xavier",
                "Timothy",
                "Carter",
                "Wyatt",
                "Brayden",
                "Blake",
                "Hayden",
                "Devin",
                "Cody",
                "Richard",
                "Seth",
                "Dominic",
                "Jaden",
                "Antonio",
                "Miguel",
                "Liam",
                "Patrick",
                "Carson",
                "Jesse",
                "Tristan",

                "Emily",
                "Madison",
                "Emma",
                "Olivia",
                "Hannah",
                "Abigail",
                "Isabella",
                "Samantha",
                "Ashley",
                "Alexis",
                "Sarah",
                "Sophia",
                "Alyssa",
                "Grace",
                "Ava",
                "Taylor",
                "Brianna",
                "Lauren",
                "Chloe",
                "Natalie",
                "Kayla",
                "Jessica",
                "Anna",
                "Victoria",
                "Mia",
                "Hailey",
                "Sydney",
                "Jasmine",
                "Julia",
                "Morgan",
                "Destiny",
                "Rachel",
                "Ella",
                "Kaitlyn",
                "Megan",
                "Katherine",
                "Savannah",
                "Jennifer",
                "Alexandra",
                "Allison",
                "Haley",
                "Maria",
                "Kaylee",
                "Lily",
                "Makayla",
                "Brooke",
                "Nicole",
                "Mackenzie",
                "Addison",
                "Lillian",
                "Andrea",
                "Faith",
                "Zoe",
                "Kimberly",
                "Madeline",
                "Alexa",
                "Katelyn",
                "Gabriella",
                "Gabrielle",
                "Trinity",
                "Amanda",
                "Kylie",
                "Mary",
                "Paige",
                "Riley",
                "Leah",
                "Jenna",
                "Sara",
                "Rebecca",
                "Michelle",
                "Sofia",
                "Vanessa",
                "Jordan",
                "Angelina",
                "Caroline",
                "Avery",
                "Audrey",
                "Evelyn",
                "Maya",
                "Claire",
                "Autumn",
                "Jocelyn",
                "Ariana",
                "Nevaeh",
                "Arianna",
                "Jada",
                "Bailey",
                "Brooklyn",
                "Aaliyah",
                "Amber",
                "Isabel",
                "Mariah",
                "Danielle",
                "Melanie",
                "Sierra",
                "Erin",
                "Amelia",
                "Molly",

            };

            List<string> commonLastNames = new List<string>()
            {
                "Smith",
                "Johnson",
                "Williams",
                "Jones",
                "Brown",
                "Davis",
                "Miller",
                "Wilson",
                "Moore",
                "Taylor",
                "Anderson",
                "Thomas",
                "Jackson",
                "White",
                "Harris",
                "Martin",
                "Thompson",
                "Garcia",
                "Martinez",
                "Robinson",
                "Clark",
                "Rodriguez",
                "Lewis",
                "Lee",
                "Walker",
                "Hall",
                "Allen",
                "Young",
                "Hernandez",
                "King",
                "Wright",
                "Lopez",
                "Hill",
                "Scott",
                "Green",
                "Adams",
                "Baker",
                "Gonzalez",
                "Nelson",
                "Carter",
                "Mitchell",
                "Perez",
                "Roberts",
                "Turner",
                "Phillips",
                "Campbell",
                "Parker",
                "Evans",
                "Edwards",
                "Collins",
                "Stewart",
                "Sanchez",
                "Morris",
                "Rogers",
                "Reed",
                "Cook",
                "Morgan",
                "Bell",
                "Murphy",
                "Bailey",
                "Rivera",
                "Cooper",
                "Richardson",
                "Cox",
                "Howard",
                "Ward",
                "Torres",
                "Peterson",
                "Gray",
                "Ramirez",
                "James",
                "Watson",
                "Brooks",
                "Kelly",
                "Sanders",
                "Price",
                "Bennett",
                "Wood",
                "Barnes",
                "Ross",
                "Henderson",
                "Coleman",
                "Jenkins",
                "Perry",
                "Powell",
                "Long",
                "Patterson",
                "Hughes",
                "Flores",
                "Washington",
                "Butler",
                "Simmons",
                "Foster",
                "Gonzales",
                "Bryant",
                "Alexander",
                "Russell",
                "Griffin",
                "Diaz",
                "Hayes",

            };

            LMSEntities context = new LMSEntities();

            Random rng = new Random();

            // Add students
            for (int i = 0; i < 200; i++)
            {
                string firstName = commonFirstNames.ElementAt(rng.Next(commonFirstNames.Count));
                string lastName = commonLastNames.ElementAt(rng.Next(commonLastNames.Count));
                bool emailConflict = context.Students.Select(a => a.Email).Contains(firstName + '.' + lastName + "@mail.weber.edu");
                string lastConflictingEmail = context.Students.Select(a => a.Email).Where(a => a.Contains(firstName + '.' + lastName + "@mail.weber.edu")).Last();
                int numericAdditive = int.TryParse(lastConflictingEmail?.Substring(lastConflictingEmail.LastIndexOf(lastName) + lastName.Length, lastConflictingEmail.IndexOf('@') - lastConflictingEmail.LastIndexOf(lastName) + lastName.Length), out int tempConflictEmail) ? tempConflictEmail : 0;
                numericAdditive++;
                string streetPreDirection = "";
                string streetPostDirection = "";
                switch (rng.Next(4))
                {
                    case 1:
                        streetPreDirection = "N";
                        break;
                    case 2:
                        streetPreDirection = "S";
                        break;
                    case 3:
                        streetPreDirection = "E";
                        break;
                    case 4:
                        streetPreDirection = "W";
                        break;
                }
                switch (rng.Next(4))
                {
                    case 1:
                        streetPostDirection = "N";
                        break;
                    case 2:
                        streetPostDirection = "S";
                        break;
                    case 3:
                        streetPostDirection = "E";
                        break;
                    case 4:
                        streetPostDirection = "W";
                        break;
                }
                context.Students.Add(new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = (emailConflict ? (firstName + '.' + lastName + numericAdditive + "@mail.weber.edu") : (firstName + '.' + lastName + "@mail.weber.edu")),
                    StudentID = context.Students.OrderBy(a => a.StudentID).LastOrDefault() != null ? context.Students.OrderBy(a => a.StudentID).Last().StudentID + 1 : 1,
                    Address = rng.Next(5000) + streetPreDirection + (rng.Next(500) * 10) + streetPostDirection,
                    Zip = 80000 + rng.Next(5000)
                });


            }
            // Add 20 instructors

            for (int i = 0; i < 20; i++)
            {
                string firstName = commonFirstNames.ElementAt(rng.Next(commonFirstNames.Count));
                string lastName = commonLastNames.ElementAt(rng.Next(commonLastNames.Count));
                bool emailConflict = context.Instructors.Select(a => a.Email).Contains(firstName + '.' + lastName + "@weber.edu");
                string lastConflictingEmail = context.Instructors.Select(a => a.Email).Where(a => a.Contains(firstName + '.' + lastName + "@weber.edu")).Last();
                int numericAdditive = int.TryParse(lastConflictingEmail?.Substring(lastConflictingEmail.LastIndexOf(lastName) + lastName.Length, lastConflictingEmail.IndexOf('@') - lastConflictingEmail.LastIndexOf(lastName) + lastName.Length), out int tempConflictEmail) ? tempConflictEmail : 0;
                numericAdditive++;
                string streetPreDirection = "";
                string streetPostDirection = "";
                switch (rng.Next(4))
                {
                    case 1:
                        streetPreDirection = "N";
                        break;
                    case 2:
                        streetPreDirection = "S";
                        break;
                    case 3:
                        streetPreDirection = "E";
                        break;
                    case 4:
                        streetPreDirection = "W";
                        break;
                }
                switch (rng.Next(4))
                {
                    case 1:
                        streetPostDirection = "N";
                        break;
                    case 2:
                        streetPostDirection = "S";
                        break;
                    case 3:
                        streetPostDirection = "E";
                        break;
                    case 4:
                        streetPostDirection = "W";
                        break;
                }
                context.Instructors.Add(new Instructor()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = (emailConflict ? (firstName + '.' + lastName + numericAdditive + "@weber.edu") : (firstName + '.' + lastName + "@weber.edu")),
                    InstructorID = context.Students.OrderBy(a => a.StudentID).LastOrDefault() != null ? context.Students.OrderBy(a => a.StudentID).Last().StudentID + 1 : 1,
                    Address = rng.Next(5000) + streetPreDirection + (rng.Next(500) * 10) + streetPostDirection,
                    Zip = 80000 + rng.Next(5000),
                });
            }
        }
    }
}
