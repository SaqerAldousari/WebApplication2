using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Static;
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
                            Address = "Abdullah Al-Mobarak block 6"
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
                            Address = "Byan block 9"
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
                            Address = "Hawalli block 4"
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
                            State = "Completed"
                        },
                        new Survey()
                        {
                            title = "HR New policy",
                            description= "Questions regarding HR new policy ",
                            startdate = DateTime.Now,
                            AnswerDate = DateTime.Now.AddDays(7),
                            State = "Completed"
                        },
                        new Survey()
                        {
                            title = "KFH Digital transformation",
                            description= "Questions regarding to KFH approach to Digital transformation ",
                            startdate = DateTime.Now,
                            AnswerDate = DateTime.Now.AddDays(10),
                            State = "Completed"
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

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                var adminUser = await userManager.FindByEmailAsync("admin@etickets.com");
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Saqer Aldousari",
                        UserName = "admin-user",
                        Email = "Admin@etickets.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                var appUser = await userManager.FindByEmailAsync("user@etickets.com");
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Maha Aldousari",
                        UserName = "app-user",
                        Email = "user@etickets.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
