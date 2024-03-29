﻿using System;
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

            List<string> utahCities = new List<string>()
            {
                "Farr West",
                "Harrisville",
                "Huntsville",
                "Hooper",
                "Marriott-Slaterville",
                "North Ogden",
                "Ogden",
                "Plain City",
                "Pleasant View",
                "Riverdale",
                "Roy",
                "South Ogden",
                "Uintah",
                "Washington Terrace",
                "West Haven",
                "Eden",
                "Liberty",
                "Nordic Valley",
                "Reese",
                "Taylor",
                "Warren",
                "West Weber",
                "Bountiful",
                "Centerville",
                "Clearfield",
                "Clinton",
                "Farmington",
                "Fruit Heights",
                "Kaysville",
                "Layton",
                "North Salt Lake",
                "South Weber",
                "Sunset",
                "Syracuse",
                "West Bountiful",
                "West Point",
                "Woods Cross",
                "Harrisville",
                "Brigham City",
                "Tremonton",
                "Mantua",
                "Honeyville",
                "Bear River City",
                "Willard",
                "Garland",
                "Deweyville",
                "Snowville",
                "Corinne",
                "Perry",
                "Fielding",
                "Plymouth",
                "Portage",
                "Howell",
                "Riverside",
                "Elwood",
                "Thatcher",
                "South Willard",
                "Kelton",
                "Salt Lake City",
                "Sandy",
                "West Valley City",
                "West Jordan",
                "South Jordan",
                "Murray",
                "Midvale",
                "Taylorsville",
                "Riverton",
                "South Salt Lake",
                "Millcreek",
                "Cottonwood Heights",
                "Holladay",
                "Herriman",
                "Magna",
                "Kearns",
                "Alta",
                "White City",
                "Granite",
            };

             List<int> ziplist = new List<int>()
            {
                84404,
                84414,
                84001,
                84978,
                84632,
                84752,
                84002,
                84003,
                84444,
                84037,
                84054,
                84065,
                84012,
                84013,
                84014,
                84066,
                84091,
                84071,
                84053,
                84041,
                85264,
                81254,
                81234,
                87415,
                86495,
                86321,
                89715,
                81111,
                81112,
                81113,
                84232,
                84233,
                89662,
                86248,
                87754,
                85234,
                82913,
                89426,
                86315,
                84368,
                86258,
                89156,
                89465,
                87495,
                89456,
                84651,
                86515,
                81532,
                87325,
                87211,
                81236,
                81225,
                82156,
                81645,
                85241,
                89745,
                83455,
                80019,
                80143,
                80156,
                80652,
                84068,
                86110,
                86111,
                86112,
                86113,
                89126,
                89129,
                89185,
                85136,
                81439,
                84911,
                84922,
                89751,
                87367,
                89513,
                85573

            };

            LMSEntities context = new LMSEntities();

            const int numberOfStudents = 200, numberofInstructors = 20;

            Random rng = new Random();
           
            // Add Zip information------------------------------------------------------------
            int zipnumber = ziplist.Count;
            for (int i = 0; i < zipnumber;)
            {
                context.Zipcodes.Add(new Zipcode()
                {
                    city = utahCities.ElementAt(i),
                    state = "Utah",
                    zip = ziplist.ElementAt(i)
                });
                i++;
            };
            context.SaveChanges();

            //ADD BASIC ASSIGNMENT TYPES------------------------------------------------------------
            int id = 0;
            context.AssignmentTypes.Add(new AssignmentType()
            {
                AssignmentTypeID = ++id,
                Description = "Exams"
            });
            context.AssignmentTypes.Add(new AssignmentType()
            {
                AssignmentTypeID = ++id,
                Description = "Assignments"
            });
            context.AssignmentTypes.Add(new AssignmentType()
            {
                AssignmentTypeID = ++id,
                Description = "Quizzes"
            });
            context.AssignmentTypes.Add(new AssignmentType()
            {
                AssignmentTypeID = ++id,
                Description = "Discussions"
            });
            context.AssignmentTypes.Add(new AssignmentType()
            {
                AssignmentTypeID = ++id,
                Description = "Misc"
            });
            context.AssignmentTypes.Add(new AssignmentType()
            {
                AssignmentTypeID = ++id,
                Description = "Extra Credit"
            });

            context.SaveChanges();

            var StudentIDs = context.Students.Select(x => x.StudentID);
            List<int> SIDs = StudentIDs.ToList();
            int lastSID;
            if(SIDs.Count > 0)
            {
                lastSID = SIDs.Max();
            }
            else
            {
                lastSID = 0;
            }
            
            // Add students------------------------------------------------------------
            for (int i = 0; i < numberOfStudents; i++)
            {
                string firstName = commonFirstNames.ElementAt(rng.Next(commonFirstNames.Count));
                string lastName = commonLastNames.ElementAt(rng.Next(commonLastNames.Count));

                //generate email based on name, check for conflicts, and add number if true
                string email = firstName + "." + lastName + "@mail.weber.edu";
                int numericAdditive = 0;
                while(context.Students.Select(a => a.Email).Contains(email))
                {
                    email = firstName + "." + lastName + (++numericAdditive).ToString() + "@mail.weber.edu";
                }               
                
                string streetPreDirection = "";
                string streetPostDirection = "";
                switch (rng.Next(0,4))
                {
                    case 0:
                        streetPreDirection = "N";
                        break;
                    case 1:
                        streetPreDirection = "S";
                        break;
                    case 2:
                        streetPreDirection = "E";
                        break;
                    case 3:
                        streetPreDirection = "W";
                        break;
                }
                switch (rng.Next(0,4))
                {
                    case 0:
                        streetPostDirection = "N";
                        break;
                    case 1:
                        streetPostDirection = "S";
                        break;
                    case 2:
                        streetPostDirection = "E";
                        break;
                    case 3:
                        streetPostDirection = "W";
                        break;
                }

                context.Students.Add(new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    StudentID = ++lastSID,
                    Address = rng.Next(5000) + " " + streetPreDirection + " " + (rng.Next(500) * 10) + " " + streetPostDirection,
                    Zip = ziplist[rng.Next(0,ziplist.Count)]
                });
            }
            
            var IntIDs = context.Instructors.Select(x => x.InstructorID);
            List<int> IIDs = IntIDs.ToList();
            int lastIID;
            if(IIDs.Count > 0)
            {
                lastIID = IIDs.Max();
            }
            else
            {
                lastIID = 0;
            }
            context.SaveChanges();
            // Add 20 instructors------------------------------------------------------------
            for (int i = 0; i < numberofInstructors; i++)
            {
                string firstName = commonFirstNames.ElementAt(rng.Next(commonFirstNames.Count));
                string lastName = commonLastNames.ElementAt(rng.Next(commonLastNames.Count));

                //generate email, check for conflicts, and add number if true
                string email = firstName + "." + lastName + "@weber.edu";
                int numericAdditive = 0;
                while(context.Instructors.Select(a => a.Email).Contains(email))
                {
                    email = firstName + "." + lastName + (++numericAdditive).ToString() + "@weber.edu";
                }

                string streetPreDirection = "";
                string streetPostDirection = "";
                bool preDirectionNS = false;
                switch (rng.Next(0,4))
                {
                    case 0:
                        streetPreDirection = "N";
                        break;
                    case 1:
                        streetPreDirection = "S";
                        break;
                    case 2:
                        streetPreDirection = "E";
                        break;
                    case 3:
                        streetPreDirection = "W";
                        break;
                }
                if(streetPreDirection == "N" || streetPreDirection == "S")
                {
                    preDirectionNS = true;
                }
                int nextDirection = rng.Next(0, 2);
                if (preDirectionNS)
                {
                    if (nextDirection == 0) streetPostDirection = "E";
                    else streetPostDirection = "W";
                }
                else
                {
                    if (nextDirection == 0) streetPostDirection = "N";
                    else streetPostDirection = "S";
                }

                context.Instructors.Add(new Instructor()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    InstructorID = ++lastIID,
                    Address = rng.Next(5000) + " " + streetPreDirection + " " + (rng.Next(500) * 10) + " " + streetPostDirection,
                    Zip = ziplist[rng.Next(0,ziplist.Count)]
                });
            }
            context.SaveChanges();
            //ADD COURSES----------------------------------
            //Possible Course Subjects
            List<string> CourseSubjects = new List<string>()
            {
                "MATH",
                "ENGL",
                "CS",
                "GEOG",
                "GEO",
                "SPAN",
                "ENGR",
                "QUAN",
                "BSAD",
                "SOC",
                "ACTG",
            };

            //Corresponding Course Title Words
            List<List<string>> TitleWords = new List<List<string>>();
            TitleWords.Add(new List<string> { "Algebra", "Calculus", "Differential Equation" });
            TitleWords.Add(new List<string> { "Writing", "Reading", "Literature Classics" });
            TitleWords.Add(new List<string> { "Java", "C#", "Algorithm" });
            TitleWords.Add(new List<string> { "Regional", "Weather and Climate", "Geography" });
            TitleWords.Add(new List<string> { "Earth Study", "Mineral", "Soil" });
            TitleWords.Add(new List<string> { "Grammar", "Literature", "Translation" });
            TitleWords.Add(new List<string> { "Mechanical", "Static", "Dynamic" });
            TitleWords.Add(new List<string> { "Statistics", "Business Calculus", "Probability" });
            TitleWords.Add(new List<string> { "Management", "Leadership", "Business Modeling" });
            TitleWords.Add(new List<string> { "Sociology", "Social Problem", "Criminology" });
            TitleWords.Add(new List<string> { "Accounting", "Taxation", "Auditing" });

            //Possible Descriptor words for the titles
            List<string> TitleDescriptors = new List<string>()
            {
                "Methods",
                "Analysis",
                "Theory",
                "I",
                "II",
                "III",
                "Studies",
                "Research",
                "Development",
                ", History of"
            };

            //create 10 courses
            for (int i = 0; i < 10; ++i)
            {
                //get the course number for the course 1050, 1670, etc.
                int Num = rng.Next(100, 500) * 10;

                //get the subject of the course
                int SubjectNum = rng.Next(0, CourseSubjects.Count);

                //assign course prefix based on course number generated
                string CoursePrefix;
                if (Num >= 1000 && Num < 2000)
                {
                    CoursePrefix = "Beginning";
                }
                else if (Num >= 2000 && Num < 3000)
                {
                    CoursePrefix = "Intermediate";
                }
                else
                {
                    CoursePrefix = "Advanced";
                }

                //Generate Course Num and Title
                string CourseNo = CourseSubjects[SubjectNum] + " " + Num.ToString();
                string CourseTitle = CoursePrefix + " " + TitleWords[SubjectNum][rng.Next(0, TitleWords[SubjectNum].Count)] + " " + TitleDescriptors[rng.Next(0, TitleDescriptors.Count)];

                //Check for conflicts and adjust if necessary
                while (context.Courses.Select(x => x.CourseID).Contains(CourseNo))
                {
                    CourseNo = CourseSubjects[SubjectNum] + " " + (Num + rng.Next(0, 10)).ToString();
                }
                while (context.Courses.Select(x => x.CourseName).Contains(CourseTitle))
                {
                    CourseTitle = CoursePrefix + " " + TitleWords[SubjectNum][rng.Next(0, TitleWords[SubjectNum].Count)] + " " + TitleDescriptors[rng.Next(0, TitleDescriptors.Count)];
                }

                //Add the course and save changes
                context.Courses.Add(new Course()
                {
                    CourseID = CourseNo,
                    CourseName = CourseTitle
                });
            }

            context.SaveChanges();
            //ADD Sections-----------------------------------
            var queryCourses = context.Courses.Select(x => x.CourseID);
            List<string> queryCourseList = queryCourses.ToList();

            var usedCourses = context.Sections.Select(x => x.CourseID);
            List<string> usedCourse = usedCourses.ToList();

            //add sections for each course
            foreach (string Course_No in queryCourseList.Except(usedCourse))
            {
                //add a number of sections between 1 and 3
                for (int i = 0; i < rng.Next(1, 4); ++i)
                {
                    //get SectionID
                    int SectID = rng.Next(0, 10000);

                    //get current dates for date calculations
                    int Month = DateTime.Now.Month;
                    int Year = DateTime.Now.Year;
                    DateTime BDate;
                    DateTime EDate;

                    //Summer Registration
                    if (Month >= 1 && Month < 5)
                    {
                        //add term identifier and set dates
                        SectID += 10000;
                        //check for conflicts
                        while (context.Sections.Any(x => x.SectionID == SectID))
                        {
                            SectID = rng.Next(0, 10000) + 10000;
                        }
                        BDate = new DateTime(Year, 5, 1);
                        EDate = new DateTime(Year, 8, 31);
                    }
                    //Fall Registration
                    else if (Month >= 5 && Month < 9)
                    {
                        //add term identifier and set dates
                        SectID += 20000;
                        //check for conflicts
                        while (context.Sections.Any(x => x.SectionID == SectID))
                        {
                            SectID = rng.Next(0, 10000) + 20000;
                        }
                        BDate = new DateTime(Year, 9, 1);
                        EDate = new DateTime(Year, 12, 31);
                    }
                    //Spring Registration
                    else
                    {
                        //add term identifier and set dates
                        SectID += 30000;
                        //check for conflicts
                        while (context.Sections.Any(x => x.SectionID == SectID))
                        {
                            SectID = rng.Next(0, 10000) + 30000;
                        }
                        BDate = new DateTime(Year + 1, 1, 1);
                        EDate = new DateTime(Year + 1, 4, 30);
                    }

                    //Get a list of instructors who aren't already teaching 4 sections
                    var InstructorIDs = context.Instructors.GroupBy(x => x.InstructorID).Where(grp => grp.Count() < 4).Select(grp => grp.Key);
                    List<int> InstIDs = InstructorIDs.ToList();

                    //if there are no available professors, don't add another section
                    if (InstIDs.Count == 0)
                    {
                        break;
                    }

                    int InstID = InstIDs[rng.Next(0, InstIDs.Count)];

                    //add section and save change
                    context.Sections.Add(new Section()
                    {
                        SectionID = SectID,
                        CourseID = Course_No,
                        InstructorID = InstID,
                        BeginDate = BDate,
                        EndDate = EDate,
                        HTMLPath = null
                    });
                }
            }
            context.SaveChanges();
            //ADD STUDENT ENROLLMENTS TO EACH SECTION-----------------------------------
            //get a list of the sections
            var querySections = context.Sections.Select(x => x.SectionID);
            List<int> querySectionList = querySections.ToList();

            //get a list of student IDs
            var possibleStudents = context.Students.Select(x => x.StudentID);
            List<int> possibleStudentIDs = possibleStudents.ToList();
            
            var enrolledSections = context.Enrollments.Select(x => x.SectionID);
            List<int> enrolledSect = enrolledSections.ToList();
            //for each section add between 15,25 students
            foreach (int SectID in querySectionList.Except(enrolledSect))
            {
                List<int> usedIDs = new List<int>();
                //if there are no more possible students, go to next section
                if(usedIDs.Count == possibleStudentIDs.Count)
                {
                    continue;
                }
                for (int i = 0; i < rng.Next(15, 26); ++i)
                {
                    //check for duplicate enrollments
                    int StudID = possibleStudentIDs[rng.Next(0, possibleStudentIDs.Count)];

                    while(usedIDs.Contains(StudID))
                    {
                        StudID = possibleStudentIDs[rng.Next(0, possibleStudentIDs.Count)];
                    }
                    usedIDs.Add(StudID);

                    //Set the enrollment term 201710, 201720, 201730 etc.
                    string Enroll;
                    if (SectID < 20000)
                    {
                        Enroll = (DateTime.Now.Year + 1).ToString() + "10";
                    }
                    else if (SectID < 30000)
                    {
                        Enroll = (DateTime.Now.Year + 1).ToString() + "20";
                    }
                    else
                    {
                        Enroll = (DateTime.Now.Year + 1).ToString() + "30";
                    }

                    //add the enrollment and save changes
                    context.Enrollments.Add(new Enrollment()
                    {
                        StudentID = StudID,
                        SectionID = SectID,
                        EnrollmentTerm = Enroll,
                        LetterGrade = "IP"
                    });
                }
            }
            context.SaveChanges();
            //ADD GRADE TYPE WEIGHTS FOR EACH SECTION------------------------------------------------------------
            foreach (int SectID in querySectionList.Except(enrolledSect))
            {
                //calculate weight percentages for assignment types such that they add up to 100%
                int total = 10;
                int tempid = 0;
                double exam = (rng.Next(3, 6) / 10.00);
                total -= Convert.ToInt32(exam * 10.00);
                exam = (Math.Round(exam, 2));

                double assign = rng.Next(0, total) / 10.00;
                total -= Convert.ToInt32(assign * 10.00);
                assign = (Math.Round(assign, 2));

                double quiz = rng.Next(0, total) / 10.00;
                total -= Convert.ToInt32(quiz * 10.00);
                quiz = (Math.Round(quiz, 2));

                double discuss = rng.Next(0, total) / 10.00;
                total -= Convert.ToInt32(discuss * 10.00);
                discuss = (Math.Round(discuss, 2));

                double misc = total / 10.0F;
                misc = (Math.Round(misc, 2));

                double excred = rng.Next(1, 4) / 100.00;

                //Add grade weights
                context.GradeWeights.Add(new GradeWeight()
                {
                    SectionID = SectID,
                    AssignmentTypeID = ++tempid,
                    WeightPercent = exam
                });
                context.GradeWeights.Add(new GradeWeight()
                {
                    SectionID = SectID,
                    AssignmentTypeID = ++tempid,
                    WeightPercent = assign
                });
                context.GradeWeights.Add(new GradeWeight()
                {
                    SectionID = SectID,
                    AssignmentTypeID = ++tempid,
                    WeightPercent = quiz
                });
                context.GradeWeights.Add(new GradeWeight()
                {
                    SectionID = SectID,
                    AssignmentTypeID = ++tempid,
                    WeightPercent = discuss
                });
                context.GradeWeights.Add(new GradeWeight()
                {
                    SectionID = SectID,
                    AssignmentTypeID = ++tempid,
                    WeightPercent = misc
                });
                context.GradeWeights.Add(new GradeWeight()
                {
                    SectionID = SectID,
                    AssignmentTypeID = ++tempid,
                    WeightPercent = excred
                });
            }
            context.SaveChanges();
            //ADD LETTER GRADE SCALE FOR EACH SECTION------------------------------------------------------------
            foreach (int SectID in querySectionList.Except(enrolledSect))
            {
                //lsit of letter grades
                List<string> Letters = new List<string>()
                {
                    "A",
                    "A-",
                    "B+",
                    "B",
                    "B-",
                    "C+",
                    "C",
                    "C-",
                    "D+",
                    "D",
                    "D-",
                    "E"
                };

                //assign grading scale for each letter
                foreach (string letter in Letters)
                {
                    double High;
                    double Low;

                    if(letter == "A")
                    {
                        High = 200.00;
                        Low = 94.00;
                    }
                    else if(letter == "A-")
                    {
                        High = 93.99;
                        Low = 90.00;
                    }
                    else if (letter == "B+")
                    {
                        High = 89.99;
                        Low = 87.00;
                    }
                    else if (letter == "B")
                    {
                        High = 86.99;
                        Low = 84.00;
                    }
                    else if (letter == "B-")
                    {
                        High = 83.99;
                        Low = 80.00;
                    }
                    else if (letter == "C+")
                    {
                        High = 79.99;
                        Low = 77.00;
                    }
                    else if (letter == "C")
                    {
                        High = 76.99;
                        Low = 74.00;
                    }
                    else if (letter == "C-")
                    {
                        High = 73.99;
                        Low = 70.00;
                    }
                    else if (letter == "D+")
                    {
                        High = 69.99;
                        Low = 67.00;
                    }
                    else if (letter == "D")
                    {
                        High = 66.99;
                        Low = 64.00;
                    }
                    else if (letter == "D-")
                    {
                        High = 63.99;
                        Low = 60.00;
                    }
                    else
                    {
                        High = 59.99;
                        Low = 0.00;
                    }
                    
                    //add the letter grade to the database
                    context.LetterGradeScales.Add(new LetterGradeScale()
                    {
                        SectionID = SectID,
                        LetterGrade = letter,
                        GradeHigh = High,
                        GradeLow = Low
                    });
                }
            }
            context.SaveChanges();
            //Generate assignment details
            var AssgnIDs = context.AssignmentDetails.Select(x => x.AssignmentID);
            List<int> AIDs = AssgnIDs.ToList();
            int lastAID;
            if(AIDs.Count > 0)
            {
                lastAID = AIDs.Max();
            }
            else
            {
                lastAID = 0;
            }
            for(int i = 0; i < context.Sections.Count() *10; i++)
            {
                int assignmentID = context.AssignmentDetails.Any() ? context.AssignmentDetails.OrderBy(a => a.AssignmentID).Last().AssignmentID + 1 : 1;
                List<AssignmentType> TypeList = context.AssignmentTypes.ToList();
                context.AssignmentDetails.Add(new AssignmentDetail()
                {
                    AssignmentID = ++lastAID,

                    PointValue = rng.Next(0, 11) * 10,
                    AssignmentTitle = "Assignment " + i,
                    AssignmentTypeID = TypeList.ElementAt(rng.Next(context.AssignmentTypes.Count())).AssignmentTypeID,
                });
            }

            context.SaveChanges();
            // Add assignments to sections
            foreach(var section in context.Sections)
            {
                var sectionID = section.SectionID;
                int daysDiff = ((TimeSpan)(section.EndDate - section.BeginDate)).Days;
                List<AssignmentDetail> DetailList = context.AssignmentDetails.ToList();
                for (int i = 0; i < rng.Next(5, 10); i++)
                {
                    var dueDate = section.BeginDate.AddDays(rng.Next(daysDiff));
                    var assignID = DetailList.ElementAt(rng.Next(context.AssignmentDetails.Count())).AssignmentID;
                    var secAssignment = new SectionAssignment()
                    {
                        AssignmentId = assignID,
                        DueDate = dueDate,
                        OpenDate = dueDate.AddDays(-7 * rng.Next(0, 2)),
                        SectionId = section.SectionID,
                        Section = section,
                        AssignmentDetail = context.AssignmentDetails.First(a => a.AssignmentID == assignID)
                    };
                    context.SectionAssignments.Add(secAssignment);
                    // This below statement may not be needed.  Double check.
                    //section.SectionAssignments.Add(secAssignment);
                }
            }
            context.SaveChanges();

            //TODO:  Add assignmentgrades
            // Add grades for assignments
            
            foreach(var sectionAssignment in context.SectionAssignments)
            {
                
                var enrollmentsInSection = context.Enrollments.Where(a => a.SectionID == sectionAssignment.SectionId);
                var studentsEnrolled = context.Students.Where(a => enrollmentsInSection.Select(b => b.StudentID).Contains(a.StudentID));
                foreach(var student in studentsEnrolled)
                {
                    
                    var timeSpan = ((TimeSpan)(sectionAssignment.DueDate - sectionAssignment.OpenDate)).Days;
                    var subDate = ((DateTime)sectionAssignment.OpenDate).AddDays(InverseBellCurve(rng) * timeSpan);
                      
                    context.AssignmentGrades.Add(new AssignmentGrade()
                    {
                        StudentId = student.StudentID,
                        SectionAssignmentId = sectionAssignment.SectionAssignmentId,
                        Grade = InverseBellCurve(rng) * 100,
                        SubmissionNum = 1,
                        SubmissionDate = subDate
                            
                    });
                }

            }
            
            context.SaveChanges();         
        } 
        // Bell curves courtesy of https://stackoverflow.com/questions/5816985/random-number-generator-which-gravitates-numbers-to-any-given-number-in-range
            /// <summary>
            /// generate a random number where the likelihood of a large number is greater than the likelihood of a small number
            /// </summary>
            /// <param name="rnd">the random number generator used to spawn the number</param>
            /// <returns>the random number</returns>
            public static double InverseBellCurve(Random rnd)
            {
                return 1 - BellCurve(rnd);
            }
            /// <summary>
            /// generate a random number where the likelihood of a small number is greater than the likelihood of a Large number
            /// </summary>
            /// <param name="rnd">the random number generator used to spawn the number</param>
            /// <returns>the random number</returns>
            public static double BellCurve(Random rnd)
            {
                return Math.Pow(rnd.NextDouble(), 8);
            }
    }
}
