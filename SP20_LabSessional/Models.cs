using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP20_LabSessional
{
    enum Designation { Lecturer, AssistantProfessor, AssociateProfessor, Professor }
    enum City { Islamabad, Lahore, Karachi, Peshawar, Multan, Quetta }
    class Faculty
    {
        public string Name { get; set; }
        public Designation Designation { get; set; }
        public string Department { get; set; }
        public string ContactNo { get; set; }
        public Address PresentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public List<DegreeCertificate> Degrees { get; set; }
        public override string ToString()
        {
            return "Name: " + this.Name + ", Designation: " +
                this.Designation + ", Department: " + this.Department +
                ", ContactNo: " + this.ContactNo + ", Present Address:" + this.PresentAddress.ToString() +
                ", Permanent Address:" + (this.PermanentAddress != null ? this.PermanentAddress.ToString() : "") + ", Degrees:" + this.Degrees.ToString();
        }
        public static bool operator >(Faculty f1, Faculty f2)
        {
            return f1.Designation > f2.Designation;
        }
        public static bool operator <(Faculty f1, Faculty f2)
        {
            return f1.Designation < f2.Designation;
        }

        public DegreeCertificate this[string degree]
        {
            get {
                return this.Degrees.Find(x => x.DegreeName == degree);
            }
        }

    }
    class CourseAllocation
    {
        public Faculty Instructor { get; set; }
        public List<Course> Courses { get; set; }
    }
    class DegreeCertificate
    {
        public string DegreeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public string InstituteName { get; set; }
        public List<Course> MajorCourses { get; set; }

        public override string ToString()
        {
            return "Degree: " + this.DegreeName + 
                ", From-To:" + this.FromDate.ToString() + "-" + this.EndDate.ToString() +
                ", Institute: " + this.InstituteName + 
                " MajorCourses: " + this.MajorCourses.ToString();
        }
    }
    class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return this.Code + ":" + this.Title + ", " + this.Description;
        }
    }
    class Address
    {
        public string StreetAddress { get; set; }
        public City City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return "Street: " + this.StreetAddress + ", City: " +
                this.City + ", District: " + this.District + ", Country: " + this.Country;
        }
    }
}
