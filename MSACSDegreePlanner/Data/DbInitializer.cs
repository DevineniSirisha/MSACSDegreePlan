using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSACSDegreePlanner;
using MSACSDegreePlanner.Data;
using MSACSDegreePlanner.Models;
using Team01Section01Project.Models;

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
                    new Degree{ DegreeID =1,DegreeAbbrev="ACS+2",DegreePlanName="MS ACS +2"}
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
                   new Requirement{RequirementID=460,RequirementAbbrev="DB",RequirementName="44-460 Database"} ,
                   new Requirement { RequirementID = 356, RequirementAbbrev = "NF", RequirementName = "44-356 Network Fundamemtals" },
                   new Requirement { RequirementID = 542, RequirementAbbrev = "OOP", RequirementName = "44-542 OOP with Java" },
                   new Requirement { RequirementID = 563, RequirementAbbrev = "Web apps", RequirementName = "44-563 Web apps" },
                   new Requirement { RequirementID = 560, RequirementAbbrev = "ADB", RequirementName = "44-560 ADB" },
                   new Requirement { RequirementID = 555, RequirementAbbrev = "NS", RequirementName = "44-555 Network Security" },
                   new Requirement { RequirementID = 618, RequirementAbbrev = "PM", RequirementName = "44-618 PM" },
                   new Requirement { RequirementID = 1, RequirementAbbrev = "Mobile", RequirementName = "44-643 or 44-644" },
                   new Requirement { RequirementID = 664, RequirementAbbrev = "UX", RequirementName = "44-664 UX" },
                   new Requirement { RequirementID = 10, RequirementAbbrev = "E1", RequirementName = "Elective 1" },
                   new Requirement { RequirementID = 20, RequirementAbbrev = "E2", RequirementName = "Elective 2" },
                   new Requirement { RequirementID = 691, RequirementAbbrev = "GDP1", RequirementName = "GDP1" },
                   new Requirement { RequirementID = 692, RequirementAbbrev = "GDP2", RequirementName = "GDP2" }

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
                    new DegreePlan{DegreePlanID=10,DegreeID=1,StudentID=531367,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanID=11,DegreeID=1,StudentID=531367,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"},
                    new DegreePlan{DegreePlanID=30,DegreeID=1,StudentID=533900,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanID=31,DegreeID=1,StudentID=533900,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"},
                    new DegreePlan{DegreePlanID=12,DegreeID=1,StudentID=533985,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanID=13,DegreeID=1,StudentID=533985,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"},
                    new DegreePlan{DegreePlanID=14,DegreeID=1,StudentID=521315,DegreePlanAbrev="No summer off",DegreePlanName="No summer off"},
                    new DegreePlan{DegreePlanID=15,DegreeID=1,StudentID=521315,DegreePlanAbrev="Summer Off",DegreePlanName="summer off"}

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
                Console.WriteLine("Degree Plans already exists!");
            }
            else
            {
                var students = new Student[]
                {
                    new Student{StudentID=531367,LastName="Devineni",FirstName="Sai Sirisha",Snumber="s531367",_919number=562438},
                    new Student{StudentID=533985,LastName="Marasini",FirstName="Dristi",Snumber="s533985",_919number=569178},
                    new Student{StudentID=521315,LastName="Joshi",FirstName="Aawaj",Snumber="s521315",_919number=480684},
                    new Student{StudentID=533900,LastName="Bourishetty",FirstName="Karun ",Snumber="s533900",_919number=568896}				
				};
                Console.WriteLine($"Inserted {students.Length} new degree plan term requirements");
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
                    new DegreeRequirement{ DegreeRequirementID = 1, DegreeID = 1, RequirementID = 460},
                    new DegreeRequirement{ DegreeRequirementID = 2, DegreeID = 1, RequirementID = 356},
                    new DegreeRequirement{ DegreeRequirementID = 3, DegreeID = 1, RequirementID = 542},
                    new DegreeRequirement{ DegreeRequirementID = 4, DegreeID = 1, RequirementID = 563},
                    new DegreeRequirement{ DegreeRequirementID = 5, DegreeID = 1, RequirementID = 560},
                    new DegreeRequirement{ DegreeRequirementID = 6, DegreeID = 1, RequirementID = 555},
                    new DegreeRequirement{ DegreeRequirementID = 7, DegreeID = 1, RequirementID = 618},
                    new DegreeRequirement{ DegreeRequirementID = 8, DegreeID = 1, RequirementID = 1},
                    new DegreeRequirement{ DegreeRequirementID = 9, DegreeID = 1, RequirementID = 664},
                    new DegreeRequirement{ DegreeRequirementID = 10, DegreeID = 1, RequirementID = 10},
                    new DegreeRequirement{ DegreeRequirementID = 11, DegreeID = 1, RequirementID = 20},
                    new DegreeRequirement{ DegreeRequirementID = 12, DegreeID = 1, RequirementID = 691},
                    new DegreeRequirement{ DegreeRequirementID = 13, DegreeID = 1, RequirementID = 692},
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
                    new StudentTerm{ StudentTermID = 13, StudentID = 521315, Term = 12, TermLabel = "Spring 2018"},
                    new StudentTerm{ StudentTermID = 14, StudentID = 521315, Term = 13, TermLabel = "Fall 2018"},
                    new StudentTerm{ StudentTermID = 15, StudentID = 521315, Term = 14, TermLabel = "Spring 2019"},
                    new StudentTerm{ StudentTermID = 16, StudentID = 521315, Term = 15, TermLabel = "Summer 2018"},
                    new StudentTerm{ StudentTermID = 17, StudentID = 521315, Term = 16, TermLabel = "Fall 2018"},
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
                    new DegreePlanTermRequirement{ DegreePlanTermRequirementID =1,DegreePlanID=10,TermID=1,RequirementID=460},
                     new DegreePlanTermRequirement{ DegreePlanTermRequirementID =2,DegreePlanID=10,TermID=1,RequirementID=356}
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
