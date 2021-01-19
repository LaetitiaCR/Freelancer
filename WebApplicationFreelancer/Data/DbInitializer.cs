using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFreelancer.Data;
using WebApplicationFreelancer.Models;

namespace WebApplicationFreelancer.Data
{
    public class DbInitializer
    {
        public static void Initialize(FreelancerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {


                new Customer{CustomerName="Jean", CustomerEmail="jean@outlook.fr", CustomercatId=1},
                new Customer{CustomerName="Pierre", CustomerEmail="pierre@outlook.fr", CustomercatId=3},
                new Customer { CustomerName = "Laura", CustomerEmail = "laura@outlook.fr", CustomercatId=2 }
             };

            //new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();





            var customercats = new Customercat[]
                {
                new Customercat { CustomercatName = "Pont", CustomercatDescription = "description de pont" },
                new Customercat { CustomercatName = "Bois", CustomercatDescription= "desciption de bois" },
                new Customercat { CustomercatName = "Poids", CustomercatDescription = "description de poids" }

                };


            foreach (Customercat cc in customercats)
            {
                context.Customercats.Add(cc);
            }
            context.SaveChanges();





            var jobs = new Job[]
            {
                new Job{JobState="A", JobTitle="Job A", JobStart=new DateTime(12/01/2021), JobEnd=new DateTime(15/01/2021), JobDescription="description A", CustomerId=2},
                new Job{JobState="B", JobTitle="Job B", JobStart=new DateTime(14/01/2021), JobEnd=new DateTime(16/01/2021), JobDescription="description B", CustomerId=1},
                new Job{JobState="C", JobTitle="Job C", JobStart=new DateTime(13/01/2021), JobEnd=new DateTime(17/01/2021), JobDescription="description C", CustomerId=3}

            };
            foreach (Job j in jobs)
            {
                context.Jobs.Add(j);
            }
            context.SaveChanges();







            var quotes = new Quote[]
            {
                new Quote{QuoteState="F", QuoteDate=new DateTime(16/01/2021), QuoteAmount=231, QuoteFinalDate=new DateTime(18/01/2021), QuoteFinalAmount=342, JobId=2 },
                new Quote{QuoteState="H", QuoteDate=new DateTime(12/01/2021), QuoteAmount=212, QuoteFinalDate=new DateTime(15/01/2021), QuoteFinalAmount=243, JobId=3 },
                new Quote{QuoteState="I", QuoteDate=new DateTime(11/01/2021), QuoteAmount=243, QuoteFinalDate=new DateTime(16/01/2021), QuoteFinalAmount=253, JobId=1 }

            };

            foreach (Quote q in quotes) {
                context.Quotes.Add(q);
            }
            context.SaveChanges();


        }

    }
}
