using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP20_LabSessional
{
    class Program
    {
        static List<Faculty> faculties;

        static void Main(string[] args)
        {
            CreateFacultyObjects();

            foreach (var item in faculties)
            {
                Console.WriteLine(item);
            }

            /* TODO:
             * 1. Display a list of faculty members working in 'Management Sciences' Department
             * 2. Display a list of faculty members whose permanent address city is not Islamabad
             * 3. Implement > operator in Faculty Class based on Designation
             * 4. Implement indexer to return DegreeCertificate of a faculty by providing degree name
             * Sample usage: facultyObject["PhD"]
            */

            Console.ReadKey();
        }

        static void CreateFacultyObjects()
        {
            faculties = new List<Faculty>()
            {
                new Faculty()
                {
                    Name = "Faculty 1",
                    Department = "Computer Science",
                    Designation = "Associate Professor",
                    PresentAddress = new Address()
                    {
                        StreetAddress = "House 88, St 33",
                        City = "Islamabad",
                        District = "Federal",
                        Country = "Pakistan"
                    },
                    ContactNo = "+9234532424242",
                    Degrees = new List<DegreeCertificate>()
                    {
                        new DegreeCertificate()
                        {
                            DegreeName = "PhD",
                            InstituteName = "MIT",
                            FromDate = new DateTime(1992, 5, 5),
                            EndDate = new DateTime(1994, 10, 1),
                            MajorCourses = new List<Course>()
                            {
                                new Course()
                                {
                                    Title = "Machine Learning"
                                },
                                new Course()
                                {
                                    Title = "AI"
                                },
                                new Course()
                                {
                                    Title = "Data Science"
                                },
                            }
                        }
                    }
                },
                new Faculty()
                {
                    Name = "Faculty 2",
                    Department = "Computer Science",
                    Designation = "Assitant Professor",
                    PresentAddress = new Address()
                    {
                        StreetAddress = "House 88, St 33",
                        City = "Islamabad",
                        District = "Federal",
                        Country = "Pakistan"
                    },
                    ContactNo = "+9234532424242",
                    Degrees = new List<DegreeCertificate>()
                    {
                        new DegreeCertificate()
                        {
                            DegreeName = "MS",
                            InstituteName = "Standfornd",
                            FromDate = new DateTime(2010, 1, 15),
                            EndDate = new DateTime(2012, 10, 10),
                            MajorCourses = new List<Course>()
                            {
                                new Course()
                                {
                                    Title = "Software Engineering"
                                },
                                new Course()
                                {
                                    Title = "Machine Learning"
                                },
                                new Course()
                                {
                                    Title = "Data Science"
                                },
                            }
                        }
                    }
                }
            };
        }
    }
        
    
}
