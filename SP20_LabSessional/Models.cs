using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP20_LabSessional
{
    class Instructor
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string ContactNo { get; set; }
        public Address PresentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public List<DegreeCertificate> Degrees { get; set; }
    }
    class CourseAllocation
    {
        public Instructor Instructor { get; set; }
        public List<Course> Courses { get; set; }
    }
    class DegreeCertificate
    {
        public string DegreeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InstituteName { get; set; }
        public List<Course> MajorCourses { get; set; }
    }
    class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
