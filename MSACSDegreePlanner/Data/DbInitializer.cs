using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSACSDegreePlanner;
using MSACSDegreePlanner.Data;
using MSACSDegreePlanner.Models;

namespace MSACSDegreePlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree Plan Term Requirements already exists!");
            }
            else {

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
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree Plan Term Requirements already exists!");
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

        }
    }
}
