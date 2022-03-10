using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Leader
                if(!context.Leader.Any())
                {
                    context.Leader.AddRange(new List<Leader>()
                    {
                        new Leader()
                        {
                            UserName = "Salem Aldousari",
                            Password = "Salem123",
                            Email = "Salem@gmail.com",
                            Department = "HR"
                        },
                        new Leader()
                        {
                            UserName = "Ahmed Aldousari",
                            Password = "Ahmed123",
                            Email = "Ahmed@gmail.com",
                            Department = "IT"
                        },
                        new Leader()
                        {
                            UserName = "Saqer Aldousari",
                            Password = "Saqer123",
                            Email = "Saqer@gmail.com",
                            Department = "TR"
                        },
                    });
                    context.SaveChanges();
                }
                //Admin
                if (!context.Admin.Any())
                {
                    context.Admin.AddRange(new List<Admin>()
                    {
                        new Admin()
                        {
                            username = "Mahamad Aldousari",
                            email= "Mahamad@gmail.com",
                            password = "Mahamad123"
                        },
                        new Admin()
                        {
                            username = "Sara Aldousari",
                            email= "Sara@gmail.com",
                            password = "Sara@gmail.com"
                        },
                        new Admin()
                        {
                            username = "Maha Aldousari",
                            email= "Maha@gmail.com",
                            password = "Maha"
                        },
                    });
                    context.SaveChanges();

                }
                //Employee
                if (!context.Employee.Any())
                {
                    context.Employee.AddRange(new List<Employee>()
                    {
                        new Employee()
                        {
                            name = "Abdullah Aldousari",
                            StartDate = DateTime.Now,
                            grade = "DP1",
                            Salary = "600KD",
                            color = "Red",
                            weight = "74 Kg",
                            ChildrenTotal = "5",
                            Address = "Abdullah Al-Mobarak block 6",
                            LeaderId = 1
                        },
                        new Employee()
                        {
                            name = "Salma Aldousari",
                            StartDate = DateTime.Now.AddDays(500),
                            grade = "DP2",
                            Salary = "800KD",
                            color = "Blue",
                            weight = "85 Kg",
                            ChildrenTotal = "2",
                            Address = "Byan block 9",
                            LeaderId = 2
                        },
                        new Employee()
                        {
                            name = "Nora Aldousari",
                            StartDate = DateTime.Now.AddDays(2500),
                            grade = "DP1",
                            Salary = "900KD",
                            color = "Black",
                            weight = "98 Kg",
                            ChildrenTotal = "6",
                            Address = "Hawalli block 4",
                            LeaderId = 3
                        },
                    });
                    context.SaveChanges();

                }
                //Survey
                if (!context.Survey.Any())
                {
                    context.Survey.AddRange(new List<Survey>()
                    {
                        new Survey()
                        {
                            title = "IT .Net departmnt employee evolution",
                            description= "Questions about IT .Net Department training program ",
                            startdate = DateTime.Now,
                            AnswerDate = DateTime.Now.AddDays(3),
                            State = "Completed",
                            AdminId = 1,
                            LeaderId = 1,
                        },
                        new Survey()
                        {
                            title = "HR New policy",
                            description= "Questions regarding HR new policy ",
                            startdate = DateTime.Now,
                            AnswerDate = DateTime.Now.AddDays(7),
                            State = "Completed",
                            AdminId = 2,
                            LeaderId = 2,
                        },
                        new Survey()
                        {
                            title = "KFH Digital transformation",
                            description= "Questions regarding to KFH approach to Digital transformation ",
                            startdate = DateTime.Now,
                            AnswerDate = DateTime.Now.AddDays(10),
                            State = "Completed",
                            AdminId = 3,
                            LeaderId = 3,
                        },
                    });
                    context.SaveChanges();

                }
                //Question
                if (!context.Question.Any())
                {
                    context.Question.AddRange(new List<Question>()
                    {
                        new Question()
                        {
                            number = 1,
                            type = "opentext",
                            question = "How do IT .Net department train their employees",
                            Answer = "We train them by using multiple methods like eLearning, Coaching, and assign simulation case studies for them to do",
                            SurveyId = 1
                        },
                        new Question()
                        {
                            number = 1,
                            type = "opentext",
                            question = "What was Added to the HR last policy",
                            Answer = "We changed the grace period for working hours from 1 hour to 15 minutes",
                            SurveyId = 2
                        },
                        new Question()
                        {
                            number = 1,
                            type = "opentext",
                            question = "How will KFH start implementing this transformation",
                            Answer = "We Will start first by creating the infrastructure that will support this transformation and we will move one from there",
                            SurveyId = 3
                        },
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
