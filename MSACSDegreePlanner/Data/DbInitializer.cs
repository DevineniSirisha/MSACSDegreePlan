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
                Console.WriteLine("Degree Plans already exists!");
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
                    new DegreePlanTermRequirement{ DegreePlanTermRequirementId =1,DegreePlanId=10,TermId=1,RequirementId=460},
                     new DegreePlanTermRequirement{ DegreePlanTermRequirementId =2,DegreePlanId=10,TermId=1,RequirementId=356}
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
