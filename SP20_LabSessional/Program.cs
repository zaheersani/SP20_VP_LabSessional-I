using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP20_LabSessional
{
    class Program
    {
        static List<Instructor> faculties;

        static void Main(string[] args)
        {
            CreateInstructorObjects();

            foreach (var item in faculties)
            {
                Console.WriteLine(item);
            }

            /* TODO:
             * 1. Convert Department field of Instructor class from string to enumerator having 
             * departments: Computer Science, Management Sciences, Electrical Engineering, Mathematics, Physics
             * 2. Convert Country field in Address class from string to enumerator having at least 7 Countries
             * 3. Override ToString methods so that Instructor objects display information of Instructor when printing objects
             * 4. Display a list of Instructors working in 'Management Sciences' Department
             * 5. Display a list of Instructors whose permanent address city is not Islamabad
             * 6. Implement > operator in Instructor Class based on Designation
             * 7. Implement indexer to return DegreeCertificate of Instructor by providing degree name
             * Sample usage: instructorObject["PhD"]
            */

            Console.ReadKey();
        }

        static void CreateInstructorObjects()
        {
            faculties = new List<Instructor>()
            {
                new Instructor()
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
                new Instructor()
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
