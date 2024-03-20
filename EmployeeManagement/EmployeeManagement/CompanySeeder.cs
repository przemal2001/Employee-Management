using EmployeeManagement.Entities;
using EmployeeManagement.Entities.Enums;
using System.Reflection;

namespace EmployeeManagement
{
    public class CompanySeeder
    {
        private readonly CompanyDbContext _dbContext;

        public CompanySeeder(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Companies.Any())
                {
                    var companies = GetCompanies();
                    _dbContext.Companies.AddRange(companies);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Company> GetCompanies()
        {
            var Companies = new List<Company>()
            {
                new Company()
                {
                    Name = "Indays",
                    Description = "Large company managing a chain of restaurants.",
                    ContactEmail = "indays@gamil.com",
                    Address = new Address()
                    {
                        City = "Nashvil",
                        Street = "Clifton 55",
                        PostalCode = "37227-37230"
                    },
                    Employees = new List<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "Michael",
                            LastName = "Diuck",
                            JobPosition = JobPosition.President,
                            Salary = 5500,
                            Duties = new List<Duty>
                            {
                                new Duty()
                                {
                                    Title = "Manage",
                                    Description = "Manage human resources in the company.",
                                    Prioryty = Prioryty.Critical
                                },
                                new Duty()
                                {
                                    Title = "Create meetings",
                                    Description = "Create company board meetings to discuss important matters.",
                                    Prioryty = Prioryty.High
                                }
                            }
                        },
                        new Employee()
                        {
                            FirstName = "Ken",
                            LastName = "Drickey",
                            JobPosition = JobPosition.Marketer,
                            Salary = 3500,
                            Duties = new List<Duty>
                            {
                                new Duty()
                                {
                                    Title = "Advertising campaigns",
                                    Description = "Create new advertising campaigns on large advertising surfaces.",
                                    Prioryty = Prioryty.High
                                },
                                new Duty()
                                {
                                    Title = "Consults with colleagues",
                                    Description = "Discuss changes with colleagues and seek advice on advertising.",
                                    Prioryty = Prioryty.Medium
                                },
                                new Duty()
                                {
                                    Title = "Contact with companies",
                                    Description = "Contact with friendly companies about new advertising campaigns.",
                                    Prioryty = Prioryty.High
                                }
                            }
                        }
                    }
                },
                new Company()
                {
                    Name = "Kangriees",
                    Description = "A company that delivers clothes to stores.",
                    ContactEmail = "kangriees@gamil.com",
                    Address = new Address()
                    {
                        City = "Cliffton",
                        Street = "Charlotte Pike 25",
                        PostalCode = "07011-07015"
                    },
                    Employees = new List<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "Cornell",
                            LastName = "Amanni",
                            JobPosition = JobPosition.President,
                            Salary = 4900,
                            Duties = new List<Duty>
                            {
                                new Duty()
                                {
                                    Title = "Manage employees",
                                    Description = "Manage human resources in the company.",
                                    Prioryty = Prioryty.Critical
                                },
                                new Duty()
                                {
                                    Title = "Contact your subordinates",
                                    Description = "Contact subordinates about new collaborations with related companies.",
                                    Prioryty = Prioryty.Medium
                                }
                            }
                        },
                        new Employee()
                        {
                            FirstName = "Benny",
                            LastName = "Ortega",
                            JobPosition = JobPosition.Sales_Manager,
                            Salary = 3600,
                            Duties = new List<Duty>
                            {
                                new Duty()
                                {
                                    Title = "Contact with companies",
                                    Description = "Contact with companies about new deliveries.",
                                    Prioryty = Prioryty.Very_High
                                },
                                new Duty()
                                {
                                    Title = "Keep your sales going",
                                    Description = "Keep your supply sales at a constant point.",
                                    Prioryty = Prioryty.High
                                }
                            }
                        },
                        new Employee()
                        {
                            FirstName = "Caren",
                            LastName = "Tursky",
                            JobPosition = JobPosition.Chief_Financial_Officer,
                            Salary = 3400,
                            Duties = new List<Duty>
                            {
                                new Duty()
                                {
                                    Title = "Deal with invoices",
                                    Description = "Deal with important invoices from largest deliveries.",
                                    Prioryty = Prioryty.Critical
                                },
                                new Duty()
                                {
                                    Title = "Taking care of finances",
                                    Description = "Taking care of the money spent and earned in the company.",
                                    Prioryty = Prioryty.Very_High
                                },
                                new Duty()
                                {
                                    Title = "Contact with other departments",
                                    Description = "Liaise with other departments regarding inaccuracies in documents.",
                                    Prioryty = Prioryty.Medium
                                }
                            }
                        }
                    }
                }
            };

            return Companies;
        }
         

            
    }
}
