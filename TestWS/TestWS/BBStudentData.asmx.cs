using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TestWS
{
    /// <summary>
    /// Summary description for BBStudentData
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BBStudentData : System.Web.Services.WebService
    {
        private static string studentID;
        private static string firstName;
        private static string lastName;
        private static string dob;
        private static string gpa;
        private static string majorCode;
        private static string addDate;
        private static string changeDate;
        private static string changeTime;
        private static string email;

        [WebMethod]
        public string getStudentID()
        {
            return studentID;
        }

        [WebMethod]
        public void setStudentID(string id)
        {
            studentID = id;
        }

        [WebMethod]
        public string getFirstName()
        {
            return firstName;
        }

        [WebMethod]
        public void setFirstName(string fn)
        {
            firstName = fn;
        }

        [WebMethod]
        public string getLastName()
        {
            return lastName;
        }

        [WebMethod]
        public string getEmail()
        {
            return email;
        }

        [WebMethod]
        public void setLastName(string ln)
        {
            lastName = ln;
        }

        [WebMethod]
        public string getDOB()
        {
            return dob;
        }

        [WebMethod]
        public void setDOB(string birth)
        {
            dob = birth;
        }

        [WebMethod]
        public string getGPA()
        {
            return gpa;
        }

        [WebMethod]
        public void setGPA(string grade)
        {
            gpa = grade;
        }

        [WebMethod]
        public string getMajorCode()
        {
            return majorCode;
        }

        [WebMethod]
        public void setMajorCode(string mc)
        {
            majorCode = mc;
        }

        [WebMethod]
        public string getAddDate()
        {
            return addDate;
        }

        [WebMethod]
        public void setAddDate(string ad)
        {
            addDate = ad;
        }

        [WebMethod]
        public string getChangeDate()
        {
            return changeDate;
        }

        [WebMethod]
        public void setChangeDate(string cd)
        {
            changeDate = cd;
        }

        [WebMethod]
        public string getChangeTime()
        {
            return changeTime;
        }

        [WebMethod]
        public void setChangeTime(string ct)
        {
            changeTime = ct;
        }

        [WebMethod]
        public void setEmail(string e)
        {
            email = e;
        }
    }
}
