using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSACSDegreePlanner;
using MSACSDegreePlanner.Data;
using MSACSDegreePlanner.Models;
using MSACSDegreePlanner.Models;

namespace MSACSDegreePlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exists!");
            }
            else
            {

                var degrees = new Degree[]
               {
                    new Degree{ DegreeId =1,DegreeAbbrev="ACS+2",DegreePlanName="MS ACS +2"}
               };
                Console.WriteLine($"Inserted {degrees.Length} new degrees");
                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }


            if (context.Requirements.Any())
            {
                Console.WriteLine("Requirements already exists!");
            }
            else
            {

                var requirements = new Requirement[]
               {
                   new Requirement{RequirementId=460,RequirementAbbrev="DB",RequirementName="44-460 Database"} ,
                   new Requirement { RequirementId = 356, RequirementAbbrev = "NF", RequirementName = "44-356 Network Fundamemtals" },
                   new Requirement { RequirementId = 542, RequirementAbbrev = "OOP", RequirementName = "44-542 OOP with Java" },
                   new Requirement { RequirementId = 563, RequirementAbbrev = "Web apps", RequirementName = "44-563 Web apps" },
                   new Requirement { RequirementId = 560, RequirementAbbrev = "ADB", RequirementName = "44-560 ADB" },
                   new Requirement { RequirementId = 555, RequirementAbbrev = "NS", RequirementName = "44-555 Network Security" },
                   new Requirement { RequirementId = 618, RequirementAbbrev = "PM", RequirementName = "44-618 PM" },
                   new Requirement { RequirementId = 1, RequirementAbbrev = "Mobile", RequirementName = "44-643 or 44-644" },
                   new Requirement { RequirementId = 664, RequirementAbbrev = "UX", RequirementName = "44-664 UX" },
                   new Requirement { RequirementId = 10, RequirementAbbrev = "E1", RequirementName = "Elective 1" },
                   new Requirement { RequirementId = 20, RequirementAbbrev = "E2", RequirementName = "Elective 2" },
                   new Requirement { RequirementId = 691, RequirementAbbrev = "GDP1", RequirementName = "GDP1" },
                   new Requirement { RequirementId = 692, RequirementAbbrev = "GDP2", RequirementName = "GDP2" }

               };
                Console.WriteLine($"Inserted {requirements.Length} new requirements");
                foreach (Requirement r in requirements)
                {
                    context.Requirements.Add(r);
                }
                context.SaveChanges();
            }
            //Degreeplan

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree Plans already exists!");
            }
            else
            {
                var degreePlans = new DegreePlan[]
                {
                    new DegreePlan{DegreePlanId=10,DegreeId=1,StudentId=531367,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanId=11,DegreeId=1,StudentId=531367,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"},
                    new DegreePlan{DegreePlanId=30,DegreeId=1,StudentId=533900,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanId=31,DegreeId=1,StudentId=533900,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"},
                    new DegreePlan{DegreePlanId=12,DegreeId=1,StudentId=533985,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanId=13,DegreeId=1,StudentId=533985,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"},
                    new DegreePlan{DegreePlanId=14,DegreeId=1,StudentId=521315,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanId=15,DegreeId=1,StudentId=521315,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"}

                };
                Console.WriteLine($"Inserted {degreePlans.Length} new degree plan term requirements");
                foreach (DegreePlan d in degreePlans)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }

            //Student
            if (context.Students.Any())
            {
                Console.WriteLine("Student records already exists!");
            }
            else
            {
                var students = new Student[]
                {
                    new Student{StudentId=531367,LastName="Devineni",FirstName="Sai Sirisha",Snumber="s531367",_919number=562438},
                    new Student{StudentId=533985,LastName="Marasini",FirstName="Dristi",Snumber="s533985",_919number=569178},
                    new Student{StudentId=521315,LastName="Joshi",FirstName="Aawaj",Snumber="s521315",_919number=480684},
                    new Student{StudentId=533900,LastName="Bourishetty",FirstName="Karun ",Snumber="s533900",_919number=568896}				
				};
                Console.WriteLine($"Inserted {students.Length} new student record");
                foreach (Student d in students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }

            //DegreeRequirement
            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("Degree Requirements already exists!");
            }
            else
            {
                var degreeRequirements = new DegreeRequirement[]
                {
                    new DegreeRequirement{ DegreeRequirementId = 1, DegreeId = 1, RequirementId = 460},
                    new DegreeRequirement{ DegreeRequirementId = 2, DegreeId = 1, RequirementId = 356},
                    new DegreeRequirement{ DegreeRequirementId = 3, DegreeId = 1, RequirementId = 542},
                    new DegreeRequirement{ DegreeRequirementId = 4, DegreeId = 1, RequirementId = 563},
                    new DegreeRequirement{ DegreeRequirementId = 5, DegreeId = 1, RequirementId = 560},
                    new DegreeRequirement{ DegreeRequirementId = 6, DegreeId = 1, RequirementId = 555},
                    new DegreeRequirement{ DegreeRequirementId = 7, DegreeId = 1, RequirementId = 618},
                    new DegreeRequirement{ DegreeRequirementId = 8, DegreeId = 1, RequirementId = 1},
                    new DegreeRequirement{ DegreeRequirementId = 9, DegreeId = 1, RequirementId = 664},
                    new DegreeRequirement{ DegreeRequirementId = 10, DegreeId = 1, RequirementId = 10},
                    new DegreeRequirement{ DegreeRequirementId = 11, DegreeId = 1, RequirementId = 20},
                    new DegreeRequirement{ DegreeRequirementId = 12, DegreeId = 1, RequirementId = 691},
                    new DegreeRequirement{ DegreeRequirementId = 13, DegreeId = 1, RequirementId = 692},
                };
                Console.WriteLine($"Inserted {degreeRequirements.Length} new degree requirements");
                foreach (DegreeRequirement dr in degreeRequirements)
                {
                    context.DegreeRequirements.Add(dr);
                }
                context.SaveChanges();
            }


            //StudentTerm
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("StudentTerm Requirements already exists!");
            }
            else
            {
                var studentTerms = new StudentTerm[]
                {
                    new StudentTerm{ StudentTermId = 13, StudentId = 521315, Term = 12, TermLabel = "Spring 2018"},
                    new StudentTerm{ StudentTermId = 14, StudentId = 521315, Term = 13, TermLabel = "Fall 2018"},
                    new StudentTerm{ StudentTermId = 15, StudentId = 521315, Term = 14, TermLabel = "Spring 2019"},
                    new StudentTerm{ StudentTermId = 16, StudentId = 521315, Term = 15, TermLabel = "Summer 2018"},
                    new StudentTerm{ StudentTermId = 17, StudentId = 521315, Term = 16, TermLabel = "Fall 2018"},
                };
                Console.WriteLine($"Inserted {studentTerms.Length} new student terms");
                foreach (StudentTerm st in studentTerms)
                {
                    context.StudentTerms.Add(st);
                }
                context.SaveChanges();
            }

            if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("Degree Plan Term Requirements already exists!");
            }
            else
            {
                var degreePlanTermRequirements = new DegreePlanTermRequirement[]
                {
<<<<<<< HEAD
                    new DegreePlanTermRequirement{ DegreePlanTermRequirementId =1,DegreePlanId=10,TermId=1,RequirementId=460},
                     new DegreePlanTermRequirement{ DegreePlanTermRequirementId =2,DegreePlanId=10,TermId=1,RequirementId=356}
=======
                    new DegreePlanTermRequirement{ DegreePlanTermRequirementID =1,DegreePlanID=10,TermID=1,RequirementID=460},
                     new DegreePlanTermRequirement{ DegreePlanTermRequirementID =2,DegreePlanID=10,TermID=1,RequirementID=356},
                     new DegreePlanTermRequirement{DegreePlanTermRequirementID=3,DegreePlanID=10,TermID=1,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=4,DegreePlanID=10,TermID=1,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=5,DegreePlanID=10,TermID=2,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=6,DegreePlanID=10,TermID=2,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=7,DegreePlanID=10,TermID=2,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=8,DegreePlanID=10,TermID=3,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=9,DegreePlanID=10,TermID=3,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=10,DegreePlanID=10,TermID=3,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=11,DegreePlanID=10,TermID=4,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=12,DegreePlanID=10,TermID=4,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=13,DegreePlanID=10,TermID=4,RequirementID=692 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=14,DegreePlanID=11,TermID=1,RequirementID=460 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=15,DegreePlanID=11,TermID=1,RequirementID=356 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=16,DegreePlanID=11,TermID=1,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=17,DegreePlanID=11,TermID=1,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=18,DegreePlanID=11,TermID=2,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=19,DegreePlanID=11,TermID=2,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=20,DegreePlanID=11,TermID=2,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=21,DegreePlanID=11,TermID=4,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=22,DegreePlanID=11,TermID=4,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=23,DegreePlanID=11,TermID=4,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=24,DegreePlanID=11,TermID=5,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=25,DegreePlanID=11,TermID=5,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=26,DegreePlanID=11,TermID=5,RequirementID=692 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=27,DegreePlanID=30,TermID=18,RequirementID=460 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=28,DegreePlanID=30,TermID=18,RequirementID=356 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=29,DegreePlanID=30,TermID=18,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=30,DegreePlanID=30,TermID=18,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=31,DegreePlanID=30,TermID=19,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=32,DegreePlanID=30,TermID=19,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=33,DegreePlanID=30,TermID=19,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=34,DegreePlanID=30,TermID=21,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=35,DegreePlanID=30,TermID=21,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=36,DegreePlanID=30,TermID=21,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=37,DegreePlanID=30,TermID=21,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=38,DegreePlanID=30,TermID=22,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=39,DegreePlanID=30,TermID=22,RequirementID=692 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=40,DegreePlanID=31,TermID=18,RequirementID=460 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=41,DegreePlanID=31,TermID=18,RequirementID=356 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=42,DegreePlanID=31,TermID=18,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=43,DegreePlanID=31,TermID=18,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=44,DegreePlanID=31,TermID=19,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=45,DegreePlanID=31,TermID=19,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=46,DegreePlanID=31,TermID=19,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=47,DegreePlanID=31,TermID=20,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=48,DegreePlanID=31,TermID=21,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=49,DegreePlanID=31,TermID=21,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=50,DegreePlanID=31,TermID=21,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=51,DegreePlanID=31,TermID=22,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=52,DegreePlanID=31,TermID=22,RequirementID=692 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=53,DegreePlanID=12,TermID=1,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=54,DegreePlanID=12,TermID=1,RequirementID=460 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=55,DegreePlanID=12,TermID=1,RequirementID=356 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=56,DegreePlanID=12,TermID=3,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=57,DegreePlanID=12,TermID=3,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=58,DegreePlanID=12,TermID=3,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=59,DegreePlanID=12,TermID=2,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=60,DegreePlanID=12,TermID=2,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=61,DegreePlanID=12,TermID=4,RequirementID=692 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=62,DegreePlanID=12,TermID=4,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=63,DegreePlanID=12,TermID=6,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=64,DegreePlanID=12,TermID=6,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=65,DegreePlanID=12,TermID=6,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=66,DegreePlanID=13,TermID=1,RequirementID=356 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=67,DegreePlanID=13,TermID=1,RequirementID=460 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=68,DegreePlanID=13,TermID=1,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=69,DegreePlanID=13,TermID=1,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=70,DegreePlanID=13,TermID=3,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=71,DegreePlanID=13,TermID=3,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=72,DegreePlanID=13,TermID=3,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=73,DegreePlanID=13,TermID=3,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=74,DegreePlanID=13,TermID=4,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=75,DegreePlanID=13,TermID=4,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=76,DegreePlanID=13,TermID=4,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=77,DegreePlanID=13,TermID=6,RequirementID=692 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=78,DegreePlanID=13,TermID=6,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=79,DegreePlanID=14,TermID=1,RequirementID=460 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=80,DegreePlanID=14,TermID=1,RequirementID=356 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=81,DegreePlanID=14,TermID=1,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=82,DegreePlanID=14,TermID=1,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=83,DegreePlanID=14,TermID=2,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=84,DegreePlanID=14,TermID=2,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=85,DegreePlanID=14,TermID=2,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=86,DegreePlanID=14,TermID=4,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=87,DegreePlanID=14,TermID=4,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=88,DegreePlanID=14,TermID=4,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=89,DegreePlanID=14,TermID=5,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=90,DegreePlanID=14,TermID=5,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=91,DegreePlanID=14,TermID=5,RequirementID=692 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=92,DegreePlanID=15,TermID=1,RequirementID=460 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=93,DegreePlanID=15,TermID=1,RequirementID=356 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=94,DegreePlanID=15,TermID=1,RequirementID=542 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=95,DegreePlanID=15,TermID=1,RequirementID=563 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=96,DegreePlanID=15,TermID=2,RequirementID=560 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=97,DegreePlanID=15,TermID=2,RequirementID=664 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=98,DegreePlanID=15,TermID=2,RequirementID=1 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=99,DegreePlanID=15,TermID=3,RequirementID=555 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=100,DegreePlanID=15,TermID=3,RequirementID=618 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=101,DegreePlanID=15,TermID=3,RequirementID=691 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=102,DegreePlanID=15,TermID=4,RequirementID=10 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=103,DegreePlanID=15,TermID=4,RequirementID=20 },
new DegreePlanTermRequirement{DegreePlanTermRequirementID=104,DegreePlanID=15,TermID=4,RequirementID=692 }

>>>>>>> a2c3ca1e89da137f9c543147abc5502f957557b1
                };
                Console.WriteLine($"Inserted {degreePlanTermRequirements.Length} new degree plan term requirements");
                foreach (DegreePlanTermRequirement d in degreePlanTermRequirements)
                {
                    context.DegreePlanTermRequirements.Add(d);
                }
                context.SaveChanges();
            }


        }
    }
}
